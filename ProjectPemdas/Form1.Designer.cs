namespace ProjectPemdas
{
    partial class Form1
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
            this.lihatNilaiSiswa1 = new ProjectPemdas.LihatNilaiSiswa();
            this.SuspendLayout();
            // 
            // lihatNilaiSiswa1
            // 
            this.lihatNilaiSiswa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(89)))));
            this.lihatNilaiSiswa1.Location = new System.Drawing.Point(1, -2);
            this.lihatNilaiSiswa1.Name = "lihatNilaiSiswa1";
            this.lihatNilaiSiswa1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lihatNilaiSiswa1.Size = new System.Drawing.Size(972, 517);
            this.lihatNilaiSiswa1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 514);
            this.Controls.Add(this.lihatNilaiSiswa1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LihatNilaiSiswa lihatNilaiSiswa1;
    }
}