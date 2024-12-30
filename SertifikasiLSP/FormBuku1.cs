using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BelajarSertifikasiLSP
{
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

            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            // Query untuk mencari buku berdasarkan Judul
            string sql = "SELECT BUKU_ID, BUKU_JUDUL FROM BUKU WHERE BUKU_JUDUL LIKE @searchTerm AND STATUS_DEL=0 ";

            try
            {

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {

                    // Parameter untuk mencari judul buku berdasarkan teks yang dimasukkan di tBoxCari
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

            string sqlBuku = "SELECT * FROM BUKU WHERE BUKU_ID = @idBuku AND STATUS_DEL=0";

            using (MySqlCommand cmdBuku = new MySqlCommand(sqlBuku, con))
            {
                cmdBuku.Parameters.AddWithValue("@idBuku", idBuku);

                using (MySqlDataReader reader = cmdBuku.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Format detail buku
                        string detailBuku = $"ID: {reader["BUKU_ID"]}\n" +
                                            $"Judul: {reader["BUKU_JUDUL"]}\n" +
                                            $"Pengarang: {reader["BUKU_PENGARANG"]}\n" +
                                            $"Tanggal Terbit: {reader["BUKU_TANGGALTERBIT"]}";

                        // Tampilkan di lblDetailBuku sementara
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
                                    SELECT A.ANGGOTA_NAMA, A.ANGGOTA_ID 
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
                        string peminjam = reader["ANGGOTA_NAMA"].ToString();
                        idAnggota = reader["ANGGOTA_ID"].ToString(); // Ambil ID Anggota
                        lblDetailBuku.Text += $"\n\nStatus: Terpinjam\nDipinjam oleh: {peminjam}";
                        btnKembalikan.Visible = true;
                    }
                    else
                    {
                        lblDetailBuku.Text += "\n\nStatus: Tersedia";
                        btnKembalikan.Visible = false;
                    }
                }
            }
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
