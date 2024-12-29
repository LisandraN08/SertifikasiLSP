
namespace BelajarSertifikasiLSP
{
    partial class FormHomePetugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePetugas));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblPerpustakaan = new System.Windows.Forms.Label();
            this.btnAnggota = new System.Windows.Forms.Button();
            this.btnBuku = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1257, 27);
            this.panelHeader.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1219, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(253, 27);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1004, 588);
            this.mainPanel.TabIndex = 11;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // lblPerpustakaan
            // 
            this.lblPerpustakaan.AutoSize = true;
            this.lblPerpustakaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerpustakaan.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPerpustakaan.Location = new System.Drawing.Point(35, 151);
            this.lblPerpustakaan.Name = "lblPerpustakaan";
            this.lblPerpustakaan.Size = new System.Drawing.Size(187, 25);
            this.lblPerpustakaan.TabIndex = 0;
            this.lblPerpustakaan.Text = "PERPUSTAKAAN";
            this.lblPerpustakaan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAnggota
            // 
            this.btnAnggota.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAnggota.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnggota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnggota.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnggota.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAnggota.Image = ((System.Drawing.Image)(resources.GetObject("btnAnggota.Image")));
            this.btnAnggota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnggota.Location = new System.Drawing.Point(33, 236);
            this.btnAnggota.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnggota.Name = "btnAnggota";
            this.btnAnggota.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAnggota.Size = new System.Drawing.Size(197, 40);
            this.btnAnggota.TabIndex = 7;
            this.btnAnggota.Text = "ANGGOTA";
            this.btnAnggota.UseVisualStyleBackColor = false;
            this.btnAnggota.Click += new System.EventHandler(this.btnAnggota_Click);
            // 
            // btnBuku
            // 
            this.btnBuku.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuku.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuku.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuku.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnBuku.Image = ((System.Drawing.Image)(resources.GetObject("btnBuku.Image")));
            this.btnBuku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuku.Location = new System.Drawing.Point(33, 292);
            this.btnBuku.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBuku.Size = new System.Drawing.Size(197, 40);
            this.btnBuku.TabIndex = 8;
            this.btnBuku.Text = "BUKU";
            this.btnBuku.UseVisualStyleBackColor = false;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(67, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 133);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSide.Controls.Add(this.btnPeminjaman);
            this.panelSide.Controls.Add(this.pictureBox2);
            this.panelSide.Controls.Add(this.btnBuku);
            this.panelSide.Controls.Add(this.btnAnggota);
            this.panelSide.Controls.Add(this.lblPerpustakaan);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 27);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(253, 588);
            this.panelSide.TabIndex = 9;
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPeminjaman.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeminjaman.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPeminjaman.Image = ((System.Drawing.Image)(resources.GetObject("btnPeminjaman.Image")));
            this.btnPeminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeminjaman.Location = new System.Drawing.Point(33, 348);
            this.btnPeminjaman.Margin = new System.Windows.Forms.Padding(0);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnPeminjaman.Size = new System.Drawing.Size(197, 40);
            this.btnPeminjaman.TabIndex = 9;
            this.btnPeminjaman.Text = "PEMINJAMAN";
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // FormHomePetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 615);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomePetugas";
            this.Text = "FormHomePetugas";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblPerpustakaan;
        private System.Windows.Forms.Button btnAnggota;
        private System.Windows.Forms.Button btnBuku;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnPeminjaman;
    }
}