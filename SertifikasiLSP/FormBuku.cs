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
    public partial class FormBuku : Form
    {

        private string idBuku;
        public FormBuku()
        {
            InitializeComponent();
        }

        private void FormBuku_Load(object sender, EventArgs e)
        {
            LoadAllBooks();
        }

        private void LoadAllBooks()
        {
            panel1.Visible = false;
            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            try
            {

                // Query untuk mengambil semua IDBUKU dan JUDULBUKU dari tabel BUKU
                string sql = "SELECT BUKU_ID, BUKU_JUDUL FROM BUKU WHERE STATUS_DEL=0";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxBuku.Items.Clear();  // Bersihkan listBox sebelumnya
                        while (reader.Read())
                        {
                            // Tambahkan IDBUKU dan JUDULBUKU ke dalam listBox
                            listBoxBuku.Items.Add($"{reader["BUKU_ID"]} - {reader["BUKU_JUDUL"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            con.Close();

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string searchTerm = tBoxCari.Text;  // Kata kunci untuk pencarian Judul

            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            // Query untuk mencari buku berdasarkan Judul yang diketik di tBoxCari
            string sql = "SELECT BUKU_ID, BUKU_JUDUL FROM BUKU WHERE BUKU_JUDUL LIKE @searchTerm AND STATUS_DEL=0";


            try
            {

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {

                    // Parameter untuk mencari judul buku berdasarkan teks yang dimasukkan di tBoxCari
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxBuku.Items.Clear(); // Bersihkan hasil pencarian sebelumnya

                        // Menambahkan IDBUKU dan JUDULBUKU ke ListBox
                        while (reader.Read())
                        {
                            listBoxBuku.Items.Add($"{reader["BUKU_ID"]} - {reader["BUKU_JUDUL"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Buku tidak ditemukan", "Buku tidak ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();

        }

        private void listBoxBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (listBoxBuku.SelectedItem != null)
            {
                // Ambil item yang dipilih
                string selectedItem = listBoxBuku.SelectedItem.ToString();

                // Ekstrak IDBUKU sebelum tanda '-'
                idBuku = selectedItem.Split('-')[0].Trim();

                // Query detail buku dari database
                ShowBookDetails(idBuku);
            }
        }

        private void ShowBookDetails(string idBuku)
        {
            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string sql = "SELECT * FROM BUKU WHERE BUKU_ID = @idBuku AND STATUS_DEL=0";

            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@idBuku", idBuku);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Format detail buku
                        string detailBuku = $"ID: {reader["BUKU_ID"]}\n" +
                                            $"Judul: {reader["BUKU_JUDUL"]}\n" +
                                            $"Pengarang: {reader["BUKU_PENGARANG"]}\n" +
                                            $"Tanggal Terbit: {reader["BUKU_TANGGALTERBIT"]}";


                        // Tampilkan di lblDetailBuku
                        lblDetailBuku.Text = detailBuku;
                    }
                    else
                    {
                        lblDetailBuku.Text = "Detail buku tidak ditemukan.";
                    }

                    reader.Close();
                }
            }

            // Cek status peminjaman buku
            string sqlPeminjaman = @"
                                    SELECT A.ANGGOTA_NAMA 
                                    FROM PEMINJAMAN P 
                                    JOIN ANGGOTA A ON P.ANGGOTA_ID = A.ANGGOTA_ID 
                                    WHERE P.BUKU_ID = @idBuku AND P.STATUS_PEMINJAMAN = 0";

            using (MySqlCommand cmdPeminjaman = new MySqlCommand(sqlPeminjaman, con))
            {
                cmdPeminjaman.Parameters.AddWithValue("@idBuku", idBuku);

                using (MySqlDataReader reader = cmdPeminjaman.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblDetailBuku.Text += $"\nStatus: Terpinjam";
                    }
                    else
                    {
                        lblDetailBuku.Text += "\nStatus: Tersedia";
                    }
                }
            }
        }
    }
}
