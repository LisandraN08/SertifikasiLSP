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
    public partial class FormLoginPetugas : Form
    {
        public FormLoginPetugas()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tBoxUsername.Text.Trim();
            string password = tBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query untuk memeriksa username dan password
            string sql = "SELECT COUNT(*) FROM PETUGAS WHERE PETUGAS_USERNAME = @username AND PETUGAS_PASSWORD = @password";

            string connstring = "server=sub7.sift-uc.id;uid=subsift8_lsp_user;pwd=BLT-?[aYWgkp;database=subsift8_lsp";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    // Menambahkan parameter untuk username dan password
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Pastikan password terenkripsi jika digunakan dalam aplikasi asli

                    int count = Convert.ToInt32(cmd.ExecuteScalar()); // Mengeksekusi query untuk mendapatkan jumlah kecocokan

                    if (count > 0)
                    {
                        // Jika ada kecocokan, login berhasil
                        MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormHomePetugas formPetugas = new FormHomePetugas();
                        formPetugas.Show();
                        this.Hide();

                        formPetugas.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        // Jika username atau password tidak cocok
                        MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
