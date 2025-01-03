﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BelajarSertifikasiLSP
{

    // Derived class untuk buku dengan status peminjaman
    public class BukuDipinjam : Buku
    {
        public string Peminjam { get; set; }

        public override string TampilkanDetail()
        {
            return base.TampilkanDetail() + $"\n\nStatus: Terpinjam\nDipinjam oleh: {Peminjam}";
        }
    }

    public class BukuTersedia : Buku
    {
        public override string TampilkanDetail()
        {
            return base.TampilkanDetail() + $"\n\nStatus: Tersedia";
        }
    }

    public partial class FormBuku1 : Form
    {

        private string idBuku;

        public FormBuku1()
        {
            InitializeComponent();
            LoadAllBooks();
        }

        private void LoadAllBooks()
        {
            cBoxStatusBuku.SelectedIndex = cBoxStatusBuku.Items.Count - 1;  // Secara default pilih "Semua"
            panel1.Visible = false;
            btnEditBuku.Visible = false;
            btnKembalikan.Visible = false;

            try
            {
                listBoxBuku.Items.Clear();

                string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                string sql = "SELECT BUKU_ID, BUKU_JUDUL FROM BUKU WHERE STATUS_DEL=0";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Mengisi listBoxBuku dengan id buku dan judul buku
                while (reader.Read())
                {
                    listBoxBuku.Items.Add($"{reader["BUKU_ID"]} - {reader["BUKU_JUDUL"]}");
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string searchTerm = tBoxCari.Text;  // Kata kunci untuk pencarian Judul
            string statusBuku = cBoxStatusBuku.SelectedItem != null ? cBoxStatusBuku.SelectedItem.ToString() : null;  // Mengambil status dari ComboBox (Tersedia/Terpinjam)

            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            try
            {
                Buku buku = new Buku();  // Buat objek buku

                // Jika status ditentukan
                if (!string.IsNullOrEmpty(statusBuku) && statusBuku != "Semua")
                {
                    buku.Search(searchTerm, statusBuku);  // Pencarian berdasarkan Judul dan Status Buku
                }
                else
                {
                    buku.Search(searchTerm);  // Pencarian berdasarkan Judul saja
                }

                // Query untuk mencari buku berdasarkan Judul
                string sql = "SELECT BUKU_ID, BUKU_JUDUL FROM BUKU WHERE BUKU_JUDUL LIKE @searchTerm AND STATUS_DEL=0 ";

                // Menambahkan kondisi untuk status berdasarkan ComboBox
                if (statusBuku == "Tersedia")
                {
                    sql += "AND BUKU_ID NOT IN (SELECT BUKU_ID FROM PEMINJAMAN WHERE STATUS_PEMINJAMAN = 0)";
                }
                else if (statusBuku == "Terpinjam")
                {
                    sql += "AND BUKU_ID IN (SELECT BUKU_ID FROM PEMINJAMAN WHERE STATUS_PEMINJAMAN = 0)";
                }

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    // Menambahkan parameter pencarian Judul
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxBuku.Items.Clear(); // Bersihkan hasil pencarian sebelumnya

                        // Menambahkan id buku dan judul buku sesuai pencarian ke listBoxBuku
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
            btnEditBuku.Visible = true;
            if (listBoxBuku.SelectedItem != null)
            {
                // Ambil item yang dipilih
                string selectedItem = listBoxBuku.SelectedItem.ToString();

                // Ekstrak id buku sebelum tanda '-'
                idBuku = selectedItem.Split('-')[0].Trim();

                // Query detail buku dari database
                ShowBookDetails(idBuku);
            }
        }

        private string idAnggota = "";
        private void ShowBookDetails(string idBuku)
        {
            btnKembalikan.Visible = false;

            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            Buku buku = null;

            // Ambil detail buku
            string sqlBuku = "SELECT * FROM BUKU WHERE BUKU_ID = @idBuku AND STATUS_DEL=0";
            using (MySqlCommand cmdBuku = new MySqlCommand(sqlBuku, con))
            {
                cmdBuku.Parameters.AddWithValue("@idBuku", idBuku);

                using (MySqlDataReader reader = cmdBuku.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        buku = new BukuTersedia
                        {
                            ID = reader["BUKU_ID"].ToString(),
                            Judul = reader["BUKU_JUDUL"].ToString(),
                            Pengarang = reader["BUKU_PENGARANG"].ToString(),
                            TanggalTerbit = Convert.ToDateTime(reader["BUKU_TANGGALTERBIT"])
                        };
                    }
                }
            }

            // Periksa status peminjaman buku
            string sqlPeminjaman = @"
                                    SELECT A.ANGGOTA_NAMA
                                    FROM PEMINJAMAN P
                                    JOIN ANGGOTA A ON P.ANGGOTA_ID = A.ANGGOTA_ID
                                    WHERE P.BUKU_ID = @idBuku AND P.STATUS_PEMINJAMAN = 0";

            bool isTerpinjam = false;
            using (MySqlCommand cmdPeminjaman = new MySqlCommand(sqlPeminjaman, con))
            {
                cmdPeminjaman.Parameters.AddWithValue("@idBuku", idBuku);

                using (MySqlDataReader reader = cmdPeminjaman.ExecuteReader())
                {
                    if (reader.Read() && buku != null)
                    {
                        buku = new BukuDipinjam
                        {
                            ID = buku.ID,
                            Judul = buku.Judul,
                            Pengarang = buku.Pengarang,
                            TanggalTerbit = buku.TanggalTerbit,
                            Peminjam = reader["ANGGOTA_NAMA"].ToString()
                        };
                        isTerpinjam = true;
                        btnKembalikan.Visible = true;
                    }
                }
            }

            // Jika buku tidak dipinjam, tampilkan status "Tersedia"
            if (buku != null)
            {
                lblDetailBuku.Text = buku.TampilkanDetail(); // Tampilkan detail, status sudah ditangani di masing-masing kelas
            }
            else
            {
                lblDetailBuku.Text = "Detail buku tidak ditemukan.";
            }

            con.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormTambahHalaman
            FormTambahBuku formTambahBuku = new FormTambahBuku();

            // Menampilkan FormTambahHalaman
            formTambahBuku.ShowDialog();
            LoadAllBooks();
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {

            // Mengambil idAnggota yang sudah diisi di ShowBookDetails
            if (!string.IsNullOrEmpty(idAnggota))
            {
                // Query untuk memperbarui TANGGAL_KEMBALI dan STATUS_PEMINJAMAN dengan filter ANGGOTA_ID
                string sql = "UPDATE PEMINJAMAN SET TANGGAL_KEMBALI=@tanggalKembali, STATUS_PEMINJAMAN=1 WHERE BUKU_ID=@idBuku AND ANGGOTA_ID=@idAnggota";

                string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        // Menambahkan parameter untuk idBuku, idAnggota, dan tanggal pengembalian
                        cmd.Parameters.AddWithValue("@idBuku", idBuku);
                        cmd.Parameters.AddWithValue("@idAnggota", idAnggota);
                        cmd.Parameters.AddWithValue("@tanggalKembali", DateTime.Now); // Tanggal pengembalian (hari ini)

                        // Mengeksekusi query untuk memperbarui status peminjaman
                        cmd.ExecuteNonQuery();

                        // Menampilkan pesan sukses
                        MessageBox.Show("Buku berhasil dikembalikan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Menampilkan pesan error jika terjadi kesalahan
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void btnEditBuku_Click(object sender, EventArgs e)
        {
            string selectedItem = listBoxBuku.SelectedItem.ToString();
            string[] parts = selectedItem.Split('-');
            string idBuku = parts[0].Trim();

            FormEditBuku formEditBuku = new FormEditBuku(idBuku);
            formEditBuku.ShowDialog();

            LoadAllBooks();
            lblDetailBuku.Text = "";
        }
    }
}
