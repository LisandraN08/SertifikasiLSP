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
            string idBuku = tBoxIDBuku.Text.Trim();
            string judulBuku = tBoxJudulBuku.Text.Trim();
            string namaPengarang = tBoxNamaPengarang.Text.Trim();
            DateTime tanggalTerbit = dateTimePickerTanggalTerbit.Value;

            // Validasi input tidak boleh kosong
            if (string.IsNullOrEmpty(idBuku))
            {
                MessageBox.Show("ID Buku tidak boleh kosong.");
                return;
            }
            if (string.IsNullOrEmpty(judulBuku))
            {
                MessageBox.Show("Judul Buku tidak boleh kosong.");
                return;
            }
            if (string.IsNullOrEmpty(namaPengarang))
            {
                MessageBox.Show("Nama Pengarang tidak boleh kosong.");
                return;
            }
            if (tanggalTerbit == DateTime.MinValue)
            {
                MessageBox.Show("Tanggal terbit tidak valid.");
                return;
            }

            string connString = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();

                    // Cek apakah ID buku sudah ada
                    string checkIdQuery = "SELECT COUNT(*) FROM BUKU WHERE BUKU_ID = @idBuku";
                    using (MySqlCommand checkIdCmd = new MySqlCommand(checkIdQuery, con))
                    {
                        checkIdCmd.Parameters.AddWithValue("@idBuku", idBuku);
                        int idCount = Convert.ToInt32(checkIdCmd.ExecuteScalar());

                        if (idCount > 0)
                        {
                            MessageBox.Show("Buku dengan ID yang sama sudah ada di database.");
                            return; // Hentikan proses jika ID buku sudah ada
                        }
                    }

                    // Cek apakah judul buku sudah ada
                    string checkJudulQuery = "SELECT COUNT(*) FROM BUKU WHERE BUKU_JUDUL = @judulBuku";
                    using (MySqlCommand checkJudulCmd = new MySqlCommand(checkJudulQuery, con))
                    {
                        checkJudulCmd.Parameters.AddWithValue("@judulBuku", judulBuku);
                        int judulCount = Convert.ToInt32(checkJudulCmd.ExecuteScalar());

                        if (judulCount > 0)
                        {
                            MessageBox.Show("Buku dengan judul yang sama sudah ada di database.");
                            return; // Hentikan proses jika judul buku sudah ada
                        }
                    }

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
