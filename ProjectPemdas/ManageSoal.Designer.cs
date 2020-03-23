namespace ProjectPemdas
{
    partial class ManageSoal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pertanyaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetailSoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JawabanA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JawabanB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JawabanC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JawabanD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JawabanE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JawabanBenar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Pertanyaan,
            this.idDetailSoal,
            this.JawabanA,
            this.JawabanB,
            this.JawabanC,
            this.JawabanD,
            this.JawabanE,
            this.JawabanBenar});
            this.dataGridView1.Location = new System.Drawing.Point(3, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(116, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 33);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Soal";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(180, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 37);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Pertanyaan
            // 
            this.Pertanyaan.HeaderText = "Pertanyaan";
            this.Pertanyaan.Name = "Pertanyaan";
            // 
            // idDetailSoal
            // 
            this.idDetailSoal.HeaderText = "idDetailSoal";
            this.idDetailSoal.Name = "idDetailSoal";
            this.idDetailSoal.Visible = false;
            // 
            // JawabanA
            // 
            this.JawabanA.HeaderText = "Jawaban A";
            this.JawabanA.Name = "JawabanA";
            // 
            // JawabanB
            // 
            this.JawabanB.HeaderText = "Jawaban B";
            this.JawabanB.Name = "JawabanB";
            // 
            // JawabanC
            // 
            this.JawabanC.HeaderText = "Jawaban C";
            this.JawabanC.Name = "JawabanC";
            // 
            // JawabanD
            // 
            this.JawabanD.HeaderText = "Jawaban D";
            this.JawabanD.Name = "JawabanD";
            // 
            // JawabanE
            // 
            this.JawabanE.HeaderText = "Jawaban E";
            this.JawabanE.Name = "JawabanE";
            // 
            // JawabanBenar
            // 
            this.JawabanBenar.HeaderText = "Jawaban Benar";
            this.JawabanBenar.Name = "JawabanBenar";
            // 
            // ManageSoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageSoal";
            this.Size = new System.Drawing.Size(972, 514);
            this.Load += new System.EventHandler(this.ManageSoal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pertanyaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailSoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn JawabanA;
        private System.Windows.Forms.DataGridViewTextBoxColumn JawabanB;
        private System.Windows.Forms.DataGridViewTextBoxColumn JawabanC;
        private System.Windows.Forms.DataGridViewTextBoxColumn JawabanD;
        private System.Windows.Forms.DataGridViewTextBoxColumn JawabanE;
        private System.Windows.Forms.DataGridViewTextBoxColumn JawabanBenar;
    }
}
