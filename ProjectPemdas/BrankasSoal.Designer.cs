namespace ProjectPemdas
{
    partial class BrankasSoal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMapel = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbKelas = new System.Windows.Forms.ComboBox();
            this.cbMapel = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(880, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblMapel
            // 
            this.lblMapel.AutoSize = true;
            this.lblMapel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapel.Location = new System.Drawing.Point(28, 30);
            this.lblMapel.Name = "lblMapel";
            this.lblMapel.Size = new System.Drawing.Size(71, 30);
            this.lblMapel.TabIndex = 2;
            this.lblMapel.Text = "Mapel";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelas.Location = new System.Drawing.Point(28, 69);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(61, 30);
            this.lblKelas.TabIndex = 4;
            this.lblKelas.Text = "Kelas";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.btnReset);
            this.gb.Controls.Add(this.btnSearch);
            this.gb.Controls.Add(this.cbKelas);
            this.gb.Controls.Add(this.cbMapel);
            this.gb.Controls.Add(this.lblKelas);
            this.gb.Controls.Add(this.lblMapel);
            this.gb.Location = new System.Drawing.Point(48, 21);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(350, 160);
            this.gb.TabIndex = 5;
            this.gb.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(228, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbKelas
            // 
            this.cbKelas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKelas.FormattingEnabled = true;
            this.cbKelas.Location = new System.Drawing.Point(106, 70);
            this.cbKelas.Name = "cbKelas";
            this.cbKelas.Size = new System.Drawing.Size(200, 33);
            this.cbKelas.TabIndex = 6;
            // 
            // cbMapel
            // 
            this.cbMapel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMapel.FormattingEnabled = true;
            this.cbMapel.Location = new System.Drawing.Point(106, 31);
            this.cbMapel.Name = "cbMapel";
            this.cbMapel.Size = new System.Drawing.Size(200, 33);
            this.cbMapel.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(144, 109);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 27);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BrankasSoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.Controls.Add(this.gb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BrankasSoal";
            this.Size = new System.Drawing.Size(972, 517);
            this.Load += new System.EventHandler(this.BrankasSoal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMapel;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.ComboBox cbKelas;
        private System.Windows.Forms.ComboBox cbMapel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
    }
}
