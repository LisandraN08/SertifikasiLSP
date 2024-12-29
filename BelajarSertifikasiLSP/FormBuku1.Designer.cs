
namespace BelajarSertifikasiLSP
{
    partial class FormBuku1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.listBoxBuku = new System.Windows.Forms.ListBox();
            this.lblDetailBuku = new System.Windows.Forms.Label();
            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.btnKembalikan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditBuku = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxCari
            // 
            this.tBoxCari.Location = new System.Drawing.Point(62, 47);
            this.tBoxCari.Name = "tBoxCari";
            this.tBoxCari.Size = new System.Drawing.Size(501, 22);
            this.tBoxCari.TabIndex = 0;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(569, 42);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 29);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // listBoxBuku
            // 
            this.listBoxBuku.FormattingEnabled = true;
            this.listBoxBuku.ItemHeight = 16;
            this.listBoxBuku.Location = new System.Drawing.Point(62, 89);
            this.listBoxBuku.Name = "listBoxBuku";
            this.listBoxBuku.Size = new System.Drawing.Size(581, 228);
            this.listBoxBuku.TabIndex = 3;
            this.listBoxBuku.SelectedIndexChanged += new System.EventHandler(this.listBoxBuku_SelectedIndexChanged);
            // 
            // lblDetailBuku
            // 
            this.lblDetailBuku.AutoSize = true;
            this.lblDetailBuku.Location = new System.Drawing.Point(10, 13);
            this.lblDetailBuku.Name = "lblDetailBuku";
            this.lblDetailBuku.Size = new System.Drawing.Size(0, 17);
            this.lblDetailBuku.TabIndex = 4;
            this.lblDetailBuku.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTambahBuku.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambahBuku.Location = new System.Drawing.Point(657, 42);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Size = new System.Drawing.Size(131, 47);
            this.btnTambahBuku.TabIndex = 5;
            this.btnTambahBuku.Text = "Tambah Buku";
            this.btnTambahBuku.UseVisualStyleBackColor = false;
            this.btnTambahBuku.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKembalikan
            // 
            this.btnKembalikan.BackColor = System.Drawing.Color.Lime;
            this.btnKembalikan.Location = new System.Drawing.Point(62, 523);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.Size = new System.Drawing.Size(234, 33);
            this.btnKembalikan.TabIndex = 6;
            this.btnKembalikan.Text = "Buku Sudah Dikembalikan";
            this.btnKembalikan.UseVisualStyleBackColor = false;
            this.btnKembalikan.Click += new System.EventHandler(this.btnKembalikan_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDetailBuku);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(62, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 194);
            this.panel1.TabIndex = 16;
            // 
            // btnEditBuku
            // 
            this.btnEditBuku.Location = new System.Drawing.Point(500, 278);
            this.btnEditBuku.Name = "btnEditBuku";
            this.btnEditBuku.Size = new System.Drawing.Size(133, 29);
            this.btnEditBuku.TabIndex = 17;
            this.btnEditBuku.Text = "Edit Buku";
            this.btnEditBuku.UseVisualStyleBackColor = true;
            this.btnEditBuku.Click += new System.EventHandler(this.btnEditBuku_Click);
            // 
            // FormBuku1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.btnEditBuku);
            this.Controls.Add(this.btnTambahBuku);
            this.Controls.Add(this.listBoxBuku);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.tBoxCari);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuku1";
            this.Text = "FormBuku1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ListBox listBoxBuku;
        private System.Windows.Forms.Label lblDetailBuku;
        private System.Windows.Forms.Button btnTambahBuku;
        private System.Windows.Forms.Button btnKembalikan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditBuku;
    }
}