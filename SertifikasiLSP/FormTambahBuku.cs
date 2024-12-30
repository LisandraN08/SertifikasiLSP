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
    public partial class FormTambahBuku : Form
    {
        public FormTambahBuku()
        {
            InitializeComponent();
        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            // Mendapatkan input dari pengguna
            string idBuku = tBoxIDBuku.Text;
            string judulBuku = tBoxJudulBuku.Text;
            string namaPengarang = tBoxNamaPengarang.Text;
            DateTime tanggalTerbit = dateTimePickerTanggalTerbit.Value;

            string connString = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();

                    // Query untuk menambahkan data ke tabel buku
                    string insertBukuQuery = "INSERT INTO BUKU (BUKU_ID, BUKU_JUDUL, BUKU_PENGARANG, BUKU_TANGGALTERBIT, STATUS_DEL) " +
                                             "VALUES (@idBuku, @judulBuku, @namaPengarang, @tanggalTerbit, 0)";

                    using (MySqlCommand cmd = new MySqlCommand(insertBukuQuery, con))
                    {
                        // Menambahkan parameter untuk query buku
                        cmd.Parameters.AddWithValue("@idBuku", idBuku);
                        cmd.Parameters.AddWithValue("@judulBuku", judulBuku);
                        cmd.Parameters.AddWithValue("@namaPengarang", namaPengarang);
                        cmd.Parameters.AddWithValue("@tanggalTerbit", tanggalTerbit);

                        // Eksekusi query
                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Buku berhasil ditambahkan!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
                }
            }
        }

    }
}
