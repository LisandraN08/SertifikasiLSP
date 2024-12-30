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
    public partial class FormEditAnggota : Form
    {
        private string idAnggota;
        public FormEditAnggota(string anggotaId)
        {
            idAnggota = anggotaId;
            InitializeComponent();
        }

        private void FormEditPelanggan_Load(object sender, EventArgs e)
        {
            LoadItemToTextBox();
        }

        private void LoadItemToTextBox()
        {
            tBoxNamaAnggota.Text = "";
            string sql = "SELECT ANGGOTA_NAMA FROM ANGGOTA WHERE ANGGOTA_ID=@idAnggota";
            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@idAnggota", idAnggota);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            // Mengisi tBoxNamaAnggota dengan nilai dari database
                            tBoxNamaAnggota.Text = reader["ANGGOTA_NAMA"].ToString();
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
            // Mendapatkan input dari pengguna
            string namaAnggota = tBoxNamaAnggota.Text;

            string connString = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();

                    // Query untuk menambahkan update data dari tabel ANGGOTA
                    string updateAnggotaQuery = "UPDATE ANGGOTA " +
                                             "SET ANGGOTA_NAMA=@namaAnggota WHERE ANGGOTA_ID=@idAnggota";

                    using (MySqlCommand cmd = new MySqlCommand(updateAnggotaQuery, con))
                    {
                        // Menambahkan parameter untuk query ANGGOTA
                        cmd.Parameters.AddWithValue("@idAnggota", idAnggota);
                        cmd.Parameters.AddWithValue("@namaAnggota", namaAnggota);

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

                    string sql = "UPDATE ANGGOTA SET STATUS_DEL = 1 WHERE ANGGOTA_ID = @idAnggota";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@idAnggota", idAnggota);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Anggota berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
