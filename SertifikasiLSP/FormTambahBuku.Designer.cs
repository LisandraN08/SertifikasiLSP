
namespace BelajarSertifikasiLSP
{
    partial class FormTambahBuku
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
            this.lblIDBuku = new System.Windows.Forms.Label();
            this.lblJudulBuku = new System.Windows.Forms.Label();
            this.lblNamaPengarang = new System.Windows.Forms.Label();
            this.lblTanggalTerbit = new System.Windows.Forms.Label();
            this.tBoxIDBuku = new System.Windows.Forms.TextBox();
            this.tBoxJudulBuku = new System.Windows.Forms.TextBox();
            this.tBoxNamaPengarang = new System.Windows.Forms.TextBox();
            this.dateTimePickerTanggalTerbit = new System.Windows.Forms.DateTimePicker();
            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDBuku
            // 
            this.lblIDBuku.AutoSize = true;
            this.lblIDBuku.Location = new System.Drawing.Point(231, 35);
            this.lblIDBuku.Name = "lblIDBuku";
            this.lblIDBuku.Size = new System.Drawing.Size(67, 17);
            this.lblIDBuku.TabIndex = 0;
            this.lblIDBuku.Text = "ID BUKU:";
            // 
            // lblJudulBuku
            // 
            this.lblJudulBuku.AutoSize = true;
            this.lblJudulBuku.Location = new System.Drawing.Point(199, 81);
            this.lblJudulBuku.Name = "lblJudulBuku";
            this.lblJudulBuku.Size = new System.Drawing.Size(99, 17);
            this.lblJudulBuku.TabIndex = 1;
            this.lblJudulBuku.Text = "JUDUL BUKU:";
            // 
            // lblNamaPengarang
            // 
            this.lblNamaPengarang.AutoSize = true;
            this.lblNamaPengarang.Location = new System.Drawing.Point(155, 132);
            this.lblNamaPengarang.Name = "lblNamaPengarang";
            this.lblNamaPengarang.Size = new System.Drawing.Size(143, 17);
            this.lblNamaPengarang.TabIndex = 2;
            this.lblNamaPengarang.Text = "NAMA PENGARANG:";
            // 
            // lblTanggalTerbit
            // 
            this.lblTanggalTerbit.AutoSize = true;
            this.lblTanggalTerbit.Location = new System.Drawing.Point(166, 183);
            this.lblTanggalTerbit.Name = "lblTanggalTerbit";
            this.lblTanggalTerbit.Size = new System.Drawing.Size(132, 17);
            this.lblTanggalTerbit.TabIndex = 3;
            this.lblTanggalTerbit.Text = "TANGGAL TERBIT:";
            // 
            // tBoxIDBuku
            // 
            this.tBoxIDBuku.Location = new System.Drawing.Point(304, 30);
            this.tBoxIDBuku.Name = "tBoxIDBuku";
            this.tBoxIDBuku.Size = new System.Drawing.Size(277, 22);
            this.tBoxIDBuku.TabIndex = 6;
            // 
            // tBoxJudulBuku
            // 
            this.tBoxJudulBuku.Location = new System.Drawing.Point(304, 81);
            this.tBoxJudulBuku.Name = "tBoxJudulBuku";
            this.tBoxJudulBuku.Size = new System.Drawing.Size(277, 22);
            this.tBoxJudulBuku.TabIndex = 7;
            // 
            // tBoxNamaPengarang
            // 
            this.tBoxNamaPengarang.Location = new System.Drawing.Point(304, 132);
            this.tBoxNamaPengarang.Name = "tBoxNamaPengarang";
            this.tBoxNamaPengarang.Size = new System.Drawing.Size(277, 22);
            this.tBoxNamaPengarang.TabIndex = 8;
            // 
            // dateTimePickerTanggalTerbit
            // 
            this.dateTimePickerTanggalTerbit.Location = new System.Drawing.Point(304, 183);
            this.dateTimePickerTanggalTerbit.Name = "dateTimePickerTanggalTerbit";
            this.dateTimePickerTanggalTerbit.Size = new System.Drawing.Size(277, 22);
            this.dateTimePickerTanggalTerbit.TabIndex = 9;
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTambahBuku.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambahBuku.Location = new System.Drawing.Point(294, 284);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Size = new System.Drawing.Size(206, 44);
            this.btnTambahBuku.TabIndex = 10;
            this.btnTambahBuku.Text = "Tambah Buku";
            this.btnTambahBuku.UseVisualStyleBackColor = false;
            this.btnTambahBuku.Click += new System.EventHandler(this.btnTambahBuku_Click);
            // 
            // FormTambahBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btnTambahBuku);
            this.Controls.Add(this.dateTimePickerTanggalTerbit);
            this.Controls.Add(this.tBoxNamaPengarang);
            this.Controls.Add(this.tBoxJudulBuku);
            this.Controls.Add(this.tBoxIDBuku);
            this.Controls.Add(this.lblTanggalTerbit);
            this.Controls.Add(this.lblNamaPengarang);
            this.Controls.Add(this.lblJudulBuku);
            this.Controls.Add(this.lblIDBuku);
            this.Name = "FormTambahBuku";
            this.Text = "FormTambahBuku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDBuku;
        private System.Windows.Forms.Label lblJudulBuku;
        private System.Windows.Forms.Label lblNamaPengarang;
        private System.Windows.Forms.Label lblTanggalTerbit;
        private System.Windows.Forms.TextBox tBoxIDBuku;
        private System.Windows.Forms.TextBox tBoxJudulBuku;
        private System.Windows.Forms.TextBox tBoxNamaPengarang;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalTerbit;
        private System.Windows.Forms.Button btnTambahBuku;
    }
}