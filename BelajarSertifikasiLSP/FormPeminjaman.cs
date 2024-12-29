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
    public partial class FormPeminjaman : Form
    {
        public FormPeminjaman()
        {
            InitializeComponent();
            LoadPeminjamanToDataGridView();
        }

        private void LoadPeminjamanToDataGridView()
        {
            // Connection string
            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";

            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                try
                {
                    // Buka koneksi
                    con.Open();

                    // Query untuk mengambil data
                    string sql = @"
                SELECT 
                    P.PEMINJAMAN_NO,
                    P.ANGGOTA_ID,
                    A.ANGGOTA_NAMA,
                    P.BUKU_ID,
                    B.BUKU_JUDUL,
                    P.TANGGAL_PINJAM,
                    P.TANGGAL_HARUSKEMBALI,
                    P.TANGGAL_KEMBALI,
                    CASE 
                        WHEN P.STATUS_PEMINJAMAN = 1 THEN 'SUDAH DIKEMBALIKAN'
                        WHEN P.STATUS_PEMINJAMAN = 0 THEN 'BELUM DIKEMBALIKAN'
                    END AS STATUS_PEMINJAMAN
                FROM PEMINJAMAN P
                JOIN ANGGOTA A ON P.ANGGOTA_ID = A.ANGGOTA_ID
                JOIN BUKU B ON P.BUKU_ID = B.BUKU_ID";

                    // Membuat adapter untuk mengambil data
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);

                    // Membuat DataTable untuk menampung data
                    DataTable dt = new DataTable();

                    // Isi DataTable dengan data dari database
                    adapter.Fill(dt);

                    // Bind DataTable ke DataGridView
                    dataGridViewPeminjaman.DataSource = dt;

                    // Atur ulang header kolom jika diperlukan
                    dataGridViewPeminjaman.Columns["PEMINJAMAN_NO"].HeaderText = "Nomor Peminjaman";
                    dataGridViewPeminjaman.Columns["ANGGOTA_ID"].HeaderText = "ID Anggota";
                    dataGridViewPeminjaman.Columns["ANGGOTA_NAMA"].HeaderText = "Nama Anggota";
                    dataGridViewPeminjaman.Columns["BUKU_ID"].HeaderText = "ID Buku";
                    dataGridViewPeminjaman.Columns["BUKU_JUDUL"].HeaderText = "Judul Buku";
                    dataGridViewPeminjaman.Columns["TANGGAL_PINJAM"].HeaderText = "Tanggal Pinjam";
                    dataGridViewPeminjaman.Columns["TANGGAL_HARUSKEMBALI"].HeaderText = "Tanggal Harus Kembali";
                    dataGridViewPeminjaman.Columns["TANGGAL_KEMBALI"].HeaderText = "Tanggal Kembali";
                    dataGridViewPeminjaman.Columns["STATUS_PEMINJAMAN"].HeaderText = "Status Peminjaman";

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
