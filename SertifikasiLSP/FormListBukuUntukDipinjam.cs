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
    public partial class FormListBukuUntukDipinjam : Form
    {
        private string idAnggota;
        public FormListBukuUntukDipinjam(string anggotaId)
        {
            idAnggota = anggotaId;
            InitializeComponent();
            LoadAvailableBooks();
        }

        private void LoadAvailableBooks()
        {
            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string sql = @"
                        SELECT B.BUKU_ID, B.BUKU_JUDUL
                        FROM BUKU B
                        LEFT JOIN PEMINJAMAN P ON B.BUKU_ID = P.BUKU_ID AND P.STATUS_PEMINJAMAN = 0
                        WHERE P.BUKU_ID IS NULL OR P.STATUS_PEMINJAMAN = 1";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            listBoxBukuAvailable.Items.Clear();

            while (reader.Read())
            {
                // Manambahkan id buku dan judul buku yang belum dipinjam ke listBoxBukuAvailable
                listBoxBukuAvailable.Items.Add($"{reader["BUKU_ID"]} - {reader["BUKU_JUDUL"]}");
            }

            reader.Close();
            con.Close();
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            // Mengecek apakah listBoxBukuAvailable.SelectedItem tidak kosong
            if (listBoxBukuAvailable.SelectedItem != null)
            {
                string selectedItem = listBoxBukuAvailable.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');
                string idBuku = parts[0].Trim();

                string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                try
                {
                    string sqlInsert = @"
                                        INSERT INTO PEMINJAMAN (ANGGOTA_ID, BUKU_ID, TANGGAL_PINJAM, STATUS_PEMINJAMAN, TANGGAL_HARUSKEMBALI)
                                        VALUES (@idAnggota, @idBuku, @tanggalPinjam, 0, @tanggalHarusKembali)";

                    MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, con);
                    cmdInsert.Parameters.AddWithValue("@idAnggota", idAnggota);
                    cmdInsert.Parameters.AddWithValue("@idBuku", idBuku);
                    cmdInsert.Parameters.AddWithValue("@tanggalPinjam", DateTime.Now); // DateTime sekarang
                    cmdInsert.Parameters.AddWithValue("@tanggalHarusKembali", DateTime.Now.AddDays(7)); // 7 hari setelah hari ini

                    int rowsAffected = cmdInsert.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Buku berhasil dipinjam.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal meminjam buku. Silakan coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    con.Close();
            }
            else
            {
                MessageBox.Show("Silakan pilih buku yang ingin dipinjam.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
