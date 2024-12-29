
namespace BelajarSertifikasiLSP
{
    partial class FormBuku
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
            this.listBoxBuku = new System.Windows.Forms.ListBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.tBoxCari = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDetailBuku = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxBuku
            // 
            this.listBoxBuku.FormattingEnabled = true;
            this.listBoxBuku.ItemHeight = 16;
            this.listBoxBuku.Location = new System.Drawing.Point(91, 80);
            this.listBoxBuku.Name = "listBoxBuku";
            this.listBoxBuku.Size = new System.Drawing.Size(581, 228);
            this.listBoxBuku.TabIndex = 7;
            this.listBoxBuku.SelectedIndexChanged += new System.EventHandler(this.listBoxBuku_SelectedIndexChanged);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(598, 33);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 29);
            this.btnCari.TabIndex = 6;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // tBoxCari
            // 
            this.tBoxCari.Location = new System.Drawing.Point(91, 38);
            this.tBoxCari.Name = "tBoxCari";
            this.tBoxCari.Size = new System.Drawing.Size(501, 22);
            this.tBoxCari.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDetailBuku);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(91, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 155);
            this.panel1.TabIndex = 17;
            // 
            // lblDetailBuku
            // 
            this.lblDetailBuku.AutoSize = true;
            this.lblDetailBuku.Location = new System.Drawing.Point(10, 13);
            this.lblDetailBuku.Name = "lblDetailBuku";
            this.lblDetailBuku.Size = new System.Drawing.Size(0, 17);
            this.lblDetailBuku.TabIndex = 4;
            // 
            // FormBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxBuku);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.tBoxCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuku";
            this.Text = "FormBuku";
            this.Load += new System.EventHandler(this.FormBuku_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBuku;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox tBoxCari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDetailBuku;
    }
}