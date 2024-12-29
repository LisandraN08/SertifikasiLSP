
namespace BelajarSertifikasiLSP
{
    partial class FormEditBuku
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
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tBoxJudulBuku = new System.Windows.Forms.TextBox();
            this.lblJudulBuku = new System.Windows.Forms.Label();
            this.lblNamaPengarang = new System.Windows.Forms.Label();
            this.lblTanggalTerbit = new System.Windows.Forms.Label();
            this.tBoxNamaPengarang = new System.Windows.Forms.TextBox();
            this.dateTimePickerTanggalTerbit = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(613, 346);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(130, 49);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus Buku";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(189, 205);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(157, 49);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan Perubahan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tBoxJudulBuku
            // 
            this.tBoxJudulBuku.Location = new System.Drawing.Point(189, 55);
            this.tBoxJudulBuku.Name = "tBoxJudulBuku";
            this.tBoxJudulBuku.Size = new System.Drawing.Size(495, 22);
            this.tBoxJudulBuku.TabIndex = 7;
            // 
            // lblJudulBuku
            // 
            this.lblJudulBuku.AutoSize = true;
            this.lblJudulBuku.Location = new System.Drawing.Point(84, 58);
            this.lblJudulBuku.Name = "lblJudulBuku";
            this.lblJudulBuku.Size = new System.Drawing.Size(99, 17);
            this.lblJudulBuku.TabIndex = 6;
            this.lblJudulBuku.Text = "JUDUL BUKU:";
            // 
            // lblNamaPengarang
            // 
            this.lblNamaPengarang.AutoSize = true;
            this.lblNamaPengarang.Location = new System.Drawing.Point(40, 106);
            this.lblNamaPengarang.Name = "lblNamaPengarang";
            this.lblNamaPengarang.Size = new System.Drawing.Size(143, 17);
            this.lblNamaPengarang.TabIndex = 10;
            this.lblNamaPengarang.Text = "NAMA PENGARANG:";
            // 
            // lblTanggalTerbit
            // 
            this.lblTanggalTerbit.AutoSize = true;
            this.lblTanggalTerbit.Location = new System.Drawing.Point(51, 154);
            this.lblTanggalTerbit.Name = "lblTanggalTerbit";
            this.lblTanggalTerbit.Size = new System.Drawing.Size(132, 17);
            this.lblTanggalTerbit.TabIndex = 11;
            this.lblTanggalTerbit.Text = "TANGGAL TERBIT:";
            // 
            // tBoxNamaPengarang
            // 
            this.tBoxNamaPengarang.Location = new System.Drawing.Point(189, 106);
            this.tBoxNamaPengarang.Name = "tBoxNamaPengarang";
            this.tBoxNamaPengarang.Size = new System.Drawing.Size(495, 22);
            this.tBoxNamaPengarang.TabIndex = 12;
            // 
            // dateTimePickerTanggalTerbit
            // 
            this.dateTimePickerTanggalTerbit.Location = new System.Drawing.Point(189, 154);
            this.dateTimePickerTanggalTerbit.Name = "dateTimePickerTanggalTerbit";
            this.dateTimePickerTanggalTerbit.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTanggalTerbit.TabIndex = 13;
            // 
            // FormEditBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerTanggalTerbit);
            this.Controls.Add(this.tBoxNamaPengarang);
            this.Controls.Add(this.lblTanggalTerbit);
            this.Controls.Add(this.lblNamaPengarang);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tBoxJudulBuku);
            this.Controls.Add(this.lblJudulBuku);
            this.Name = "FormEditBuku";
            this.Text = "FormEditBuku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox tBoxJudulBuku;
        private System.Windows.Forms.Label lblJudulBuku;
        private System.Windows.Forms.Label lblNamaPengarang;
        private System.Windows.Forms.Label lblTanggalTerbit;
        private System.Windows.Forms.TextBox tBoxNamaPengarang;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalTerbit;
    }
}