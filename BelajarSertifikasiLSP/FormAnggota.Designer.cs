
namespace BelajarSertifikasiLSP
{
    partial class FormAnggota
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
            this.btnTambahAnggota = new System.Windows.Forms.Button();
            this.lblDetailAnggota = new System.Windows.Forms.Label();
            this.listBoxAnggota = new System.Windows.Forms.ListBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.tBoxCari = new System.Windows.Forms.TextBox();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnEditAnggota = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTambahAnggota
            // 
            this.btnTambahAnggota.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTambahAnggota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambahAnggota.Location = new System.Drawing.Point(696, 14);
            this.btnTambahAnggota.Name = "btnTambahAnggota";
            this.btnTambahAnggota.Size = new System.Drawing.Size(156, 51);
            this.btnTambahAnggota.TabIndex = 12;
            this.btnTambahAnggota.Text = "Tambah Anggota";
            this.btnTambahAnggota.UseVisualStyleBackColor = false;
            this.btnTambahAnggota.Click += new System.EventHandler(this.btnTambahAnggota_Click);
            // 
            // lblDetailAnggota
            // 
            this.lblDetailAnggota.AutoSize = true;
            this.lblDetailAnggota.Location = new System.Drawing.Point(48, 306);
            this.lblDetailAnggota.Name = "lblDetailAnggota";
            this.lblDetailAnggota.Size = new System.Drawing.Size(0, 17);
            this.lblDetailAnggota.TabIndex = 11;
            // 
            // listBoxAnggota
            // 
            this.listBoxAnggota.FormattingEnabled = true;
            this.listBoxAnggota.ItemHeight = 16;
            this.listBoxAnggota.Location = new System.Drawing.Point(37, 59);
            this.listBoxAnggota.Name = "listBoxAnggota";
            this.listBoxAnggota.Size = new System.Drawing.Size(633, 228);
            this.listBoxAnggota.TabIndex = 10;
            this.listBoxAnggota.SelectedIndexChanged += new System.EventHandler(this.ListBoxAnggota_SelectedIndexChanged);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(595, 14);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 29);
            this.btnCari.TabIndex = 9;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // tBoxCari
            // 
            this.tBoxCari.Location = new System.Drawing.Point(37, 17);
            this.tBoxCari.Name = "tBoxCari";
            this.tBoxCari.Size = new System.Drawing.Size(552, 22);
            this.tBoxCari.TabIndex = 7;
            // 
            // btnPinjam
            // 
            this.btnPinjam.Location = new System.Drawing.Point(36, 482);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(75, 29);
            this.btnPinjam.TabIndex = 13;
            this.btnPinjam.Text = "Pinjam";
            this.btnPinjam.UseVisualStyleBackColor = true;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnEditAnggota
            // 
            this.btnEditAnggota.Location = new System.Drawing.Point(526, 247);
            this.btnEditAnggota.Name = "btnEditAnggota";
            this.btnEditAnggota.Size = new System.Drawing.Size(133, 29);
            this.btnEditAnggota.TabIndex = 14;
            this.btnEditAnggota.Text = "Edit Anggota";
            this.btnEditAnggota.UseVisualStyleBackColor = true;
            this.btnEditAnggota.Click += new System.EventHandler(this.btnEditAnggota_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(37, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 183);
            this.panel1.TabIndex = 15;
            // 
            // FormAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 533);
            this.Controls.Add(this.btnEditAnggota);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.btnTambahAnggota);
            this.Controls.Add(this.lblDetailAnggota);
            this.Controls.Add(this.listBoxAnggota);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.tBoxCari);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnggota";
            this.Text = "FormAnggota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTambahAnggota;
        private System.Windows.Forms.Label lblDetailAnggota;
        private System.Windows.Forms.ListBox listBoxAnggota;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox tBoxCari;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.Button btnEditAnggota;
        private System.Windows.Forms.Panel panel1;
    }
}