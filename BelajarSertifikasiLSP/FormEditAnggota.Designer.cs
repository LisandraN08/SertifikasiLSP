
namespace BelajarSertifikasiLSP
{
    partial class FormEditAnggota
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxNamaAnggota = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA ANGGOTA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxNamaAnggota
            // 
            this.tBoxNamaAnggota.Location = new System.Drawing.Point(234, 98);
            this.tBoxNamaAnggota.Name = "tBoxNamaAnggota";
            this.tBoxNamaAnggota.Size = new System.Drawing.Size(495, 22);
            this.tBoxNamaAnggota.TabIndex = 2;
            this.tBoxNamaAnggota.TextChanged += new System.EventHandler(this.tBoxNamaAnggota_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(234, 166);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(157, 49);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan Perubahan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(658, 389);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(130, 49);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus Anggota";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // FormEditAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tBoxNamaAnggota);
            this.Controls.Add(this.label1);
            this.Name = "FormEditAnggota";
            this.Text = "FormEditAnggota";
            this.Load += new System.EventHandler(this.FormEditPelanggan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxNamaAnggota;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
    }
}