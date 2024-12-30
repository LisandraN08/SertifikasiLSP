
namespace BelajarSertifikasiLSP
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnPetugas = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuku = new System.Windows.Forms.Button();
            this.lblPerpustakaan = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(243, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 450);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSide.Controls.Add(this.btnPetugas);
            this.panelSide.Controls.Add(this.pictureBox2);
            this.panelSide.Controls.Add(this.btnBuku);
            this.panelSide.Controls.Add(this.lblPerpustakaan);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 27);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(253, 588);
            this.panelSide.TabIndex = 5;
            // 
            // btnPetugas
            // 
            this.btnPetugas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPetugas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetugas.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetugas.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPetugas.Image = ((System.Drawing.Image)(resources.GetObject("btnPetugas.Image")));
            this.btnPetugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPetugas.Location = new System.Drawing.Point(22, 527);
            this.btnPetugas.Margin = new System.Windows.Forms.Padding(0);
            this.btnPetugas.Name = "btnPetugas";
            this.btnPetugas.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnPetugas.Size = new System.Drawing.Size(217, 40);
            this.btnPetugas.TabIndex = 9;
            this.btnPetugas.Text = "LOGIN SEBAGAI PETUGAS";
            this.btnPetugas.UseVisualStyleBackColor = false;
            this.btnPetugas.Click += new System.EventHandler(this.btnPetugas_Click);
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
            // btnBuku
            // 
            this.btnBuku.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuku.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuku.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuku.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnBuku.Image = ((System.Drawing.Image)(resources.GetObject("btnBuku.Image")));
            this.btnBuku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuku.Location = new System.Drawing.Point(33, 236);
            this.btnBuku.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBuku.Size = new System.Drawing.Size(197, 40);
            this.btnBuku.TabIndex = 8;
            this.btnBuku.Text = "BUKU";
            this.btnBuku.UseVisualStyleBackColor = false;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click);
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1257, 27);
            this.panelHeader.TabIndex = 6;
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
            this.mainPanel.TabIndex = 7;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 615);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBuku;
        private System.Windows.Forms.Label lblPerpustakaan;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPetugas;
    }
}