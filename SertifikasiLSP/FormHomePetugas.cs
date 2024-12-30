using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelajarSertifikasiLSP
{
    public partial class FormHomePetugas : Form
    {
        public FormHomePetugas()
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

        private void btnAnggota_Click(object sender, EventArgs e)
        {
            loadform(new FormAnggota());
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            loadform(new FormBuku1());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            loadform(new FormPeminjaman());
        }
    }
}
