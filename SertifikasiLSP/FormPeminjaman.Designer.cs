
namespace BelajarSertifikasiLSP
{
    partial class FormPeminjaman
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
            this.dataGridViewPeminjaman = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPeminjaman
            // 
            this.dataGridViewPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeminjaman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPeminjaman.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPeminjaman.Name = "dataGridViewPeminjaman";
            this.dataGridViewPeminjaman.RowHeadersWidth = 51;
            this.dataGridViewPeminjaman.RowTemplate.Height = 24;
            this.dataGridViewPeminjaman.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewPeminjaman.TabIndex = 0;
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPeminjaman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPeminjaman";
            this.Text = "FormPeminjaman";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPeminjaman;
    }
}