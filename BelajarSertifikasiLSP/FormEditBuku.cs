using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BelajarSertifikasiLSP
{
    public partial class FormEditBuku : Form
    {
        private string idBuku;
        public FormEditBuku(string bukuId)
        {
            idBuku = bukuId;
            InitializeComponent();
            LoadItemToForm();
        }

        private void LoadItemToForm()
        {
            tBoxJudulBuku.Text = "";
            tBoxNamaPengarang.Text = "";
            string sql = "SELECT * FROM BUKU WHERE BUKU_ID=@idBuku";
            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@idBuku", idBuku);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            tBoxJudulBuku.Text = reader["BUKU_JUDUL"].ToString();
                            tBoxNamaPengarang.Text = reader["BUKU_PENGARANG"].ToString();

                            if (reader["BUKU_TANGGALTERBIT"] != DBNull.Value)
                            {
                                DateTime tanggalTerbit = Convert.ToDateTime(reader["BUKU_TANGGALTERBIT"]);
                                dateTimePickerTanggalTerbit.Value = tanggalTerbit;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}");
            }

            con.Close();

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string judulBuku = tBoxJudulBuku.Text;
            string namaPengarang = tBoxNamaPengarang.Text;
            DateTime tanggalTerbit = dateTimePickerTanggalTerbit.Value;

            // String koneksi ke database
            string connString = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    // Membuka koneksi
                    con.Open();

                    // Query untuk menambahkan update data dari tabel BUKU
                    string updateBukuQuery = "UPDATE BUKU " +
                                             "SET BUKU_JUDUL=@judulBuku, BUKU_PENGARANG=@namaPengarang, BUKU_TANGGALTERBIT=@tanggalTerbit WHERE BUKU_ID=@idBuku";

                    using (MySqlCommand cmd = new MySqlCommand(updateBukuQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@idBuku", idBuku);
                        cmd.Parameters.AddWithValue("@judulBuku", judulBuku);
                        cmd.Parameters.AddWithValue("@namaPengarang", namaPengarang);
                        cmd.Parameters.AddWithValue("@tanggalTerbit", tanggalTerbit);

                        // Eksekusi query
                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Data baru berhasil disimpan!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";

            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                try
                {
                    con.Open();

                    string sql = "UPDATE BUKU SET STATUS_DEL = 1 WHERE BUKU_ID = @idBuku";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@idBuku", idBuku);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Buku berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Kesalahan database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
