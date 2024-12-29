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

            // Load all members on form load
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

                // Populate the ListBox with data
                while (reader.Read())
                {
                    // Store both IDANGGOTA and NAMAANGGOTA as the ListBox item (e.g., "1 - John Doe")
                    listBoxAnggota.Items.Add($"{reader["ANGGOTA_ID"]} - {reader["ANGGOTA_NAMA"]}");
                }

                // Close the connection
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
                // Get the selected item (e.g., "1 - John Doe") and extract the IDANGGOTA
                string selectedItem = listBoxAnggota.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');
                string idAnggota = parts[0].Trim();

                // Connection string
                string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                // Query to get all details for the selected IDANGGOTA
                string sqlAnggota = "SELECT ANGGOTA_ID, ANGGOTA_NAMA FROM ANGGOTA WHERE ANGGOTA_ID = @id AND STATUS_DEL=0";
                MySqlCommand cmdAnggota = new MySqlCommand(sqlAnggota, con);
                cmdAnggota.Parameters.AddWithValue("@id", idAnggota);

                MySqlDataReader reader = cmdAnggota.ExecuteReader();

                if (reader.Read())
                {
                    // Display the details in the label
                    lblDetailAnggota.Text = $"ID: {reader["ANGGOTA_ID"]}\n" +
                                            $"Nama: {reader["ANGGOTA_NAMA"]}";

                    // Enable the "PINJAM" button
                    btnPinjam.Enabled = true;
                }
                else
                {
                    lblDetailAnggota.Text = "Detail anggota tidak ditemukan.";
                    btnPinjam.Enabled = false;
                }

                reader.Close();

                // Query to get books being borrowed by the selected IDANGGOTA
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
            // Get the search term and reload the ListBox with filtered results
            string searchTerm = tBoxCari.Text.Trim();

            try
            {
                // Clear existing items in the ListBox
                listBoxAnggota.Items.Clear();

                // Connection string
                string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                // Query to select NAMAANGGOTA
                string sql = "SELECT ANGGOTA_ID, ANGGOTA_NAMA FROM ANGGOTA WHERE STATUS_DEL=0";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    sql += " AND ANGGOTA_NAMA LIKE @searchTerm";
                }

                MySqlCommand cmd = new MySqlCommand(sql, con);

                // Add parameter for search term
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                // Populate the ListBox with data
                while (reader.Read())
                {
                    // Store both IDANGGOTA and NAMAANGGOTA as the ListBox item (e.g., "1 - John Doe")
                    listBoxAnggota.Items.Add($"{reader["ANGGOTA_ID"]} - {reader["ANGGOTA_NAMA"]}");
                }

                // Close the connection
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
            // Logic for the PINJAM button

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
