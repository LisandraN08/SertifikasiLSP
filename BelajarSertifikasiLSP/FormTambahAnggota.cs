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
    public partial class FormTambahAnggota : Form
    {
        public FormTambahAnggota()
        {
            InitializeComponent();
        }


        private void btnTambahAnggota_Click(object sender, EventArgs e)
        {
            // Mendapatkan input dari pengguna
            string idAnggota = tBoxIDAnggota.Text;
            string namaAnggota = tBoxNamaAnggota.Text;

            // String koneksi ke database
            string connString = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();

                    string insertBukuQuery = "INSERT INTO ANGGOTA (ANGGOTA_ID, ANGGOTA_NAMA, STATUS_DEL) " +
                                             "VALUES (@idAnggota, @namaAnggota, 0)";

                    using (MySqlCommand cmd = new MySqlCommand(insertBukuQuery, con))
                    {
                        // Menambahkan parameter untuk query BUKU
                        cmd.Parameters.AddWithValue("@idAnggota", idAnggota);
                        cmd.Parameters.AddWithValue("@namaAnggota", namaAnggota);

                        // Eksekusi query
                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Anggota berhasil ditambahkan!");
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
