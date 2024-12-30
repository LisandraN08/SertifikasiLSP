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
            string idAnggota = tBoxIDAnggota.Text.Trim();
            string namaAnggota = tBoxNamaAnggota.Text.Trim();

            // Validasi input tidak boleh kosong
            if (string.IsNullOrEmpty(idAnggota))
            {
                MessageBox.Show("ID Anggota tidak boleh kosong.");
                return;
            }
            if (string.IsNullOrEmpty(namaAnggota))
            {
                MessageBox.Show("Nama Anggota tidak boleh kosong.");
                return;
            }

            string connString = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();

                    // Cek apakah ID anggota sudah ada
                    string checkIdQuery = "SELECT COUNT(*) FROM ANGGOTA WHERE ANGGOTA_ID = @idAnggota";
                    using (MySqlCommand checkIdCmd = new MySqlCommand(checkIdQuery, con))
                    {
                        checkIdCmd.Parameters.AddWithValue("@idAnggota", idAnggota);
                        int idCount = Convert.ToInt32(checkIdCmd.ExecuteScalar());

                        if (idCount > 0)
                        {
                            MessageBox.Show("Anggota dengan ID yang sama sudah ada di database.");
                            return; // Hentikan proses jika ID anggota sudah ada
                        }
                    }

                    // Cek apakah nama anggota sudah ada
                    string checkNamaQuery = "SELECT COUNT(*) FROM ANGGOTA WHERE ANGGOTA_NAMA = @namaAnggota";
                    using (MySqlCommand checkNamaCmd = new MySqlCommand(checkNamaQuery, con))
                    {
                        checkNamaCmd.Parameters.AddWithValue("@namaAnggota", namaAnggota);
                        int namaCount = Convert.ToInt32(checkNamaCmd.ExecuteScalar());

                        if (namaCount > 0)
                        {
                            MessageBox.Show("Anggota dengan nama yang sama sudah ada di database.");
                            return; // Hentikan proses jika nama anggota sudah ada
                        }
                    }

                    // Query untuk menambahkan data ke tabel anggota
                    string insertAnggotaQuery = "INSERT INTO ANGGOTA (ANGGOTA_ID, ANGGOTA_NAMA, STATUS_DEL) " +
                                                "VALUES (@idAnggota, @namaAnggota, 0)";

                    using (MySqlCommand cmd = new MySqlCommand(insertAnggotaQuery, con))
                    {
                        // Menambahkan parameter untuk query anggota
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
