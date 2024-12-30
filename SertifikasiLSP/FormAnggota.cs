using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;

namespace BelajarSertifikasiLSP
{
    public partial class FormAnggota : Form
    {

        public FormAnggota()
        {
            InitializeComponent();
            LoadAnggota();
        }

        private void LoadAnggota()
        {
            panel1.Visible = false;
            btnPinjam.Visible = false;
            btnEditAnggota.Visible = false;
            try
            {
                listBoxAnggota.Items.Clear();

                string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                string sql = "SELECT ANGGOTA_ID, ANGGOTA_NAMA FROM ANGGOTA WHERE STATUS_DEL=0";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Mengisi listBoxAnggota dengan id dan nama anggota
                while (reader.Read())
                {
                    listBoxAnggota.Items.Add($"{reader["ANGGOTA_ID"]} - {reader["ANGGOTA_NAMA"]}");
                }

                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Anggota tidak ditemukan", "Anggota tidak ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListBoxAnggota_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnPinjam.Visible = true;
            btnEditAnggota.Visible = true;

            if (listBoxAnggota.SelectedIndex == -1) return;

            try
            {
                // Mengambil idAnggota saja (listBoxAnggota.SelectedItem di sebelum tanda -)
                string selectedItem = listBoxAnggota.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');
                string idAnggota = parts[0].Trim();

                string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                // Mendapatkan detail anggota dengan id=idAnggota
                string sqlAnggota = "SELECT ANGGOTA_ID, ANGGOTA_NAMA FROM ANGGOTA WHERE ANGGOTA_ID = @id AND STATUS_DEL=0";
                MySqlCommand cmdAnggota = new MySqlCommand(sqlAnggota, con);
                cmdAnggota.Parameters.AddWithValue("@id", idAnggota);

                MySqlDataReader reader = cmdAnggota.ExecuteReader();

                if (reader.Read())
                {
                    // Menampilkan detail anggota
                    lblDetailAnggota.Text = $"ID: {reader["ANGGOTA_ID"]}\n" +
                                            $"Nama: {reader["ANGGOTA_NAMA"]}";

                    btnPinjam.Enabled = true;
                }
                else
                {
                    lblDetailAnggota.Text = "Detail anggota tidak ditemukan.";
                    btnPinjam.Enabled = false;
                }

                reader.Close();

                // Mendapatkan semua buku yang dipinjam oleh idAnggota
                string sqlBukuDipinjam = @"
                                SELECT B.BUKU_JUDUL, P.TANGGAL_HARUSKEMBALI
                                FROM PEMINJAMAN P
                                JOIN BUKU B ON P.BUKU_ID = B.BUKU_ID
                                WHERE P.ANGGOTA_ID = @id AND P.STATUS_PEMINJAMAN = 0";

                MySqlCommand cmdBuku = new MySqlCommand(sqlBukuDipinjam, con);
                cmdBuku.Parameters.AddWithValue("@id", idAnggota);

                using (MySqlDataReader bukuReader = cmdBuku.ExecuteReader())
                {
                    StringBuilder bukuDipinjam = new StringBuilder();
                    int bukuTerlambat = 0; // Hitung buku terlambat
                    int totalBukuDipinjam = 0; // Hitung total buku dipinjam

                    DateTime today = DateTime.Today;  // Mendapatkan tanggal hari ini

                    while (bukuReader.Read())
                    {
                        string bukuJudul = bukuReader["BUKU_JUDUL"].ToString();
                        DateTime tanggalHarusKembali = Convert.ToDateTime(bukuReader["TANGGAL_HARUSKEMBALI"]);

                        // Periksa apakah buku terlambat
                        if (tanggalHarusKembali < today)
                        {
                            bukuTerlambat++;
                            bukuDipinjam.Append($"{bukuJudul} (MELEWATI TENGGAT PENGEMBALIAN)\n");
                        }
                        else
                        {
                            bukuDipinjam.Append(bukuJudul);
                        }

                        totalBukuDipinjam++; // Tambah hitung buku dipinjam
                    }

                    if (totalBukuDipinjam > 1 && bukuTerlambat > 0)
                    {
                        // Jika ada lebih dari 1 buku yang dipinjam dan ada yang terlambat
                        MessageBox.Show("Anggota ini tidak dapat meminjam lagi karena ada 2 buku yang belum dikembalikan dan melewati tenggat pengembalian.",
                                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnPinjam.Enabled = false; // Nonaktifkan tombol pinjam
                    }
                    else
                    {
                        // Jika tidak ada buku terlambat
                        btnPinjam.Enabled = true;
                    }

                    if (bukuDipinjam.Length > 0)
                    {
                        lblDetailAnggota.Text += $"\n\nBuku yang dipinjam: {bukuDipinjam}";
                    }
                    else
                    {
                        lblDetailAnggota.Text += "\n\nBuku yang dipinjam: Tidak ada";
                    }
                }

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // Mendapatkan isi dari tBoxCari
            string searchTerm = tBoxCari.Text.Trim();

            try
            {
                listBoxAnggota.Items.Clear();

                string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                // Query untuk mendapatkan id dan nama anggota
                string sql = "SELECT ANGGOTA_ID, ANGGOTA_NAMA FROM ANGGOTA WHERE STATUS_DEL=0";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    sql += " AND ANGGOTA_NAMA LIKE @searchTerm";
                }

                MySqlCommand cmd = new MySqlCommand(sql, con);

                // Parameter untuk search term
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Memasukkan id anggota dan nama anggota ke listBoxAnggota
                    listBoxAnggota.Items.Add($"{reader["ANGGOTA_ID"]} - {reader["ANGGOTA_NAMA"]}");
                }

                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Anggota tidak ditemukan", "Anggota tidak ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            string selectedItem = listBoxAnggota.SelectedItem.ToString();
            string[] parts = selectedItem.Split('-');
            string idAnggota = parts[0].Trim();

            FormListBukuUntukDipinjam formListBukuUntukDipinjam = new FormListBukuUntukDipinjam(idAnggota);
            formListBukuUntukDipinjam.ShowDialog();
        }

        private void btnEditAnggota_Click(object sender, EventArgs e)
        {

            string selectedItem = listBoxAnggota.SelectedItem.ToString();
            string[] parts = selectedItem.Split('-');
            string idAnggota = parts[0].Trim();

            FormEditAnggota formEditAnggota = new FormEditAnggota(idAnggota);
            formEditAnggota.ShowDialog();

            LoadAnggota();
            lblDetailAnggota.Text = "";

        }

        private void btnTambahAnggota_Click(object sender, EventArgs e)
        {

            FormTambahAnggota formTambahAnggota = new FormTambahAnggota();
            formTambahAnggota.ShowDialog();
            LoadAnggota();

        }
    }
}
