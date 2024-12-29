
namespace BelajarSertifikasiLSP
{
    partial class FormTambahAnggota
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
            this.lblIDAnggota = new System.Windows.Forms.Label();
            this.lblNamaAnggota = new System.Windows.Forms.Label();
            this.tBoxIDAnggota = new System.Windows.Forms.TextBox();
            this.tBoxNamaAnggota = new System.Windows.Forms.TextBox();
            this.btnTambahAnggota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDAnggota
            // 
            this.lblIDAnggota.AutoSize = true;
            this.lblIDAnggota.Location = new System.Drawing.Point(111, 54);
            this.lblIDAnggota.Name = "lblIDAnggota";
            this.lblIDAnggota.Size = new System.Drawing.Size(99, 17);
            this.lblIDAnggota.TabIndex = 0;
            this.lblIDAnggota.Text = "ID ANGGOTA:";
            // 
            // lblNamaAnggota
            // 
            this.lblNamaAnggota.AutoSize = true;
            this.lblNamaAnggota.Location = new System.Drawing.Point(85, 108);
            this.lblNamaAnggota.Name = "lblNamaAnggota";
            this.lblNamaAnggota.Size = new System.Drawing.Size(125, 17);
            this.lblNamaAnggota.TabIndex = 1;
            this.lblNamaAnggota.Text = "NAMA ANGGOTA:";
            // 
            // tBoxIDAnggota
            // 
            this.tBoxIDAnggota.Location = new System.Drawing.Point(216, 49);
            this.tBoxIDAnggota.Name = "tBoxIDAnggota";
            this.tBoxIDAnggota.Size = new System.Drawing.Size(502, 22);
            this.tBoxIDAnggota.TabIndex = 3;
            // 
            // tBoxNamaAnggota
            // 
            this.tBoxNamaAnggota.Location = new System.Drawing.Point(216, 103);
            this.tBoxNamaAnggota.Name = "tBoxNamaAnggota";
            this.tBoxNamaAnggota.Size = new System.Drawing.Size(502, 22);
            this.tBoxNamaAnggota.TabIndex = 4;
            // 
            // btnTambahAnggota
            // 
            this.btnTambahAnggota.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTambahAnggota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambahAnggota.Location = new System.Drawing.Point(307, 204);
            this.btnTambahAnggota.Name = "btnTambahAnggota";
            this.btnTambahAnggota.Size = new System.Drawing.Size(178, 57);
            this.btnTambahAnggota.TabIndex = 6;
            this.btnTambahAnggota.Text = "Tambah Anggota";
            this.btnTambahAnggota.UseVisualStyleBackColor = false;
            this.btnTambahAnggota.Click += new System.EventHandler(this.btnTambahAnggota_Click);
            // 
            // FormTambahAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTambahAnggota);
            this.Controls.Add(this.tBoxNamaAnggota);
            this.Controls.Add(this.tBoxIDAnggota);
            this.Controls.Add(this.lblNamaAnggota);
            this.Controls.Add(this.lblIDAnggota);
            this.Name = "FormTambahAnggota";
            this.Text = "FormTambahAnggota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDAnggota;
        private System.Windows.Forms.Label lblNamaAnggota;
        private System.Windows.Forms.TextBox tBoxIDAnggota;
        private System.Windows.Forms.TextBox tBoxNamaAnggota;
        private System.Windows.Forms.Button btnTambahAnggota;
    }
}