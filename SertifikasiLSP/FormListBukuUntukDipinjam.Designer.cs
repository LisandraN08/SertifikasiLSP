
namespace BelajarSertifikasiLSP
{
    partial class FormListBukuUntukDipinjam
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
            this.listBoxBukuAvailable = new System.Windows.Forms.ListBox();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBukuAvailable
            // 
            this.listBoxBukuAvailable.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxBukuAvailable.FormattingEnabled = true;
            this.listBoxBukuAvailable.ItemHeight = 16;
            this.listBoxBukuAvailable.Location = new System.Drawing.Point(0, 0);
            this.listBoxBukuAvailable.Name = "listBoxBukuAvailable";
            this.listBoxBukuAvailable.Size = new System.Drawing.Size(800, 356);
            this.listBoxBukuAvailable.TabIndex = 0;
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPinjam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPinjam.Location = new System.Drawing.Point(25, 384);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(150, 37);
            this.btnPinjam.TabIndex = 1;
            this.btnPinjam.Text = "Pinjam Buku Ini";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // FormListBukuUntukDipinjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.listBoxBukuAvailable);
            this.Name = "FormListBukuUntukDipinjam";
            this.Text = "FormListBukuUntukDipinjam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBukuAvailable;
        private System.Windows.Forms.Button btnPinjam;
    }
}