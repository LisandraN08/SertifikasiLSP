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
    public partial class FormHome : Form
    {

        public FormHome()
        {

            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            loadform(new FormBuku());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            FormLoginPetugas formLoginPetugas = new FormLoginPetugas();

            formLoginPetugas.Show();
            this.Hide();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
