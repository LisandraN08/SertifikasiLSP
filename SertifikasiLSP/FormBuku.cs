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

    // Base Class: Buku
    public class Buku
    {
        public string ID { get; set; }
        public string Judul { get; set; }
        public string Pengarang { get; set; }
        public DateTime TanggalTerbit { get; set; }

        public virtual string TampilkanDetail()
        {
            return $"ID: {ID}\nJudul: {Judul}\nPengarang: {Pengarang}\nTanggal Terbit: {TanggalTerbit:dd-MM-yyyy}";
        }

        // Pencarian berdasarkan Judul
        public void Search(string judul)
        {
            // Logika pencarian berdasarkan Judul
            Console.WriteLine($"Mencari buku dengan Judul: {judul}");
        }

        // Pencarian berdasarkan Judul dan Status Buku
        public void Search(string judul, string status)
        {
            // Logika pencarian berdasarkan Judul dan Status
            Console.WriteLine($"Mencari buku dengan Judul: {judul} dan Status: {status}");
        }
    }


    public partial class FormBuku : Form
    {
        private string idBuku;
        private List<Buku> daftarBuku = new List<Buku>();

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
            cBoxStatusBuku.SelectedIndex = cBoxStatusBuku.Items.Count - 1;  // Secara default pilih "Semua"
            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string sql = "SELECT * FROM BUKU WHERE STATUS_DEL=0";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            listBoxBuku.Items.Clear();
            daftarBuku.Clear();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Buku buku = new Buku
                    {
                        ID = reader["BUKU_ID"].ToString(),
                        Judul = reader["BUKU_JUDUL"].ToString(),
                        Pengarang = reader["BUKU_PENGARANG"].ToString(),
                        TanggalTerbit = Convert.ToDateTime(reader["BUKU_TANGGALTERBIT"])
                    };

                    daftarBuku.Add(buku);
                    listBoxBuku.Items.Add($"{buku.ID} - {buku.Judul}");
                }
            }

            con.Close();
        }

        private void listBoxBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (listBoxBuku.SelectedItem != null)
            {
                string selectedItem = listBoxBuku.SelectedItem.ToString();
                idBuku = selectedItem.Split('-')[0].Trim();

                Buku selectedBuku = daftarBuku.Find(b => b.ID == idBuku);

                if (selectedBuku != null)
                {
                    lblDetailBuku.Text = selectedBuku.TampilkanDetail();
                }
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
                if (!string.IsNullOrEmpty(statusBuku) && statusBuku != "Pilih Status")
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

    }
}
