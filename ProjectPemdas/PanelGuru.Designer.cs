namespace ProjectPemdas
{
    partial class PanelGuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelGuru));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelKiri = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnLihatSoal = new System.Windows.Forms.Button();
            this.btnBerkasSoal = new System.Windows.Forms.Button();
            this.btnBuatSoal = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usrCtrlHome = new ProjectPemdas.Home();
            this.usrCtlLihatNilai = new ProjectPemdas.LihatNilaiSiswa();
            this.z = new ProjectPemdas.BrankasSoal();
            this.usrCtrlBuatSoal = new ProjectPemdas.AddSoal();
            this.usrCtrlLihatSoal = new ProjectPemdas.LihatSoal();
            this.addSoal3 = new ProjectPemdas.AddSoal();
            this.addSoal1 = new ProjectPemdas.AddSoal();
            this.lihatDaftarSiswa1 = new ProjectPemdas.LihatDaftarSiswa();
            this.manageSoal1 = new ProjectPemdas.ManageSoal();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelKiri);
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Controls.Add(this.btnLihatSoal);
            this.panel1.Controls.Add(this.btnBerkasSoal);
            this.panel1.Controls.Add(this.btnBuatSoal);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 615);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(10, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Edit Soal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "List Siswa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nilai";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelKiri
            // 
            this.panelKiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panelKiri.Location = new System.Drawing.Point(0, 101);
            this.panelKiri.Name = "panelKiri";
            this.panelKiri.Size = new System.Drawing.Size(13, 47);
            this.panelKiri.TabIndex = 8;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(176, 92);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 7;
            this.pictureLogo.TabStop = false;
            // 
            // btnLihatSoal
            // 
            this.btnLihatSoal.FlatAppearance.BorderSize = 0;
            this.btnLihatSoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLihatSoal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatSoal.ForeColor = System.Drawing.Color.White;
            this.btnLihatSoal.Image = ((System.Drawing.Image)(resources.GetObject("btnLihatSoal.Image")));
            this.btnLihatSoal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihatSoal.Location = new System.Drawing.Point(12, 260);
            this.btnLihatSoal.Name = "btnLihatSoal";
            this.btnLihatSoal.Size = new System.Drawing.Size(167, 47);
            this.btnLihatSoal.TabIndex = 6;
            this.btnLihatSoal.Text = "Lihat Soal";
            this.btnLihatSoal.UseVisualStyleBackColor = true;
            this.btnLihatSoal.Click += new System.EventHandler(this.btnLihatSoal_Click);
            // 
            // btnBerkasSoal
            // 
            this.btnBerkasSoal.FlatAppearance.BorderSize = 0;
            this.btnBerkasSoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBerkasSoal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerkasSoal.ForeColor = System.Drawing.Color.White;
            this.btnBerkasSoal.Image = ((System.Drawing.Image)(resources.GetObject("btnBerkasSoal.Image")));
            this.btnBerkasSoal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBerkasSoal.Location = new System.Drawing.Point(12, 207);
            this.btnBerkasSoal.Name = "btnBerkasSoal";
            this.btnBerkasSoal.Size = new System.Drawing.Size(167, 47);
            this.btnBerkasSoal.TabIndex = 5;
            this.btnBerkasSoal.Text = "Berkas Soal";
            this.btnBerkasSoal.UseVisualStyleBackColor = true;
            this.btnBerkasSoal.Click += new System.EventHandler(this.btnBerkasSoal_Click);
            // 
            // btnBuatSoal
            // 
            this.btnBuatSoal.FlatAppearance.BorderSize = 0;
            this.btnBuatSoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuatSoal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuatSoal.ForeColor = System.Drawing.Color.White;
            this.btnBuatSoal.Image = ((System.Drawing.Image)(resources.GetObject("btnBuatSoal.Image")));
            this.btnBuatSoal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuatSoal.Location = new System.Drawing.Point(12, 154);
            this.btnBuatSoal.Name = "btnBuatSoal";
            this.btnBuatSoal.Size = new System.Drawing.Size(167, 47);
            this.btnBuatSoal.TabIndex = 4;
            this.btnBuatSoal.Text = "Buat Soal";
            this.btnBuatSoal.UseVisualStyleBackColor = true;
            this.btnBuatSoal.Click += new System.EventHandler(this.btnBuatSoal_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 101);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(167, 47);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(178, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 100);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(105, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(315, 30);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Muhammad Zidane Nahla Qowy";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(106, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(496, 16);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to Dashboard, You are look so good, have a nice day !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // usrCtrlHome
            // 
            this.usrCtrlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.usrCtrlHome.Location = new System.Drawing.Point(178, 125);
            this.usrCtrlHome.Name = "usrCtrlHome";
            this.usrCtrlHome.Size = new System.Drawing.Size(972, 517);
            this.usrCtrlHome.TabIndex = 4;
            // 
            // usrCtlLihatNilai
            // 
            this.usrCtlLihatNilai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(89)))));
            this.usrCtlLihatNilai.Location = new System.Drawing.Point(178, 125);
            this.usrCtlLihatNilai.Name = "usrCtlLihatNilai";
            this.usrCtlLihatNilai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usrCtlLihatNilai.Size = new System.Drawing.Size(972, 517);
            this.usrCtlLihatNilai.TabIndex = 8;
            // 
            // z
            // 
            this.z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.z.Location = new System.Drawing.Point(178, 125);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(972, 517);
            this.z.TabIndex = 7;
            // 
            // usrCtrlBuatSoal
            // 
            this.usrCtrlBuatSoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.usrCtrlBuatSoal.ForeColor = System.Drawing.Color.Black;
            this.usrCtrlBuatSoal.Location = new System.Drawing.Point(178, 125);
            this.usrCtrlBuatSoal.Name = "usrCtrlBuatSoal";
            this.usrCtrlBuatSoal.Size = new System.Drawing.Size(972, 517);
            this.usrCtrlBuatSoal.TabIndex = 3;
            this.usrCtrlBuatSoal.Load += new System.EventHandler(this.usrCtrlBuatSoal_Load);
            // 
            // usrCtrlLihatSoal
            // 
            this.usrCtrlLihatSoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(89)))));
            this.usrCtrlLihatSoal.Location = new System.Drawing.Point(178, 125);
            this.usrCtrlLihatSoal.Name = "usrCtrlLihatSoal";
            this.usrCtrlLihatSoal.Size = new System.Drawing.Size(972, 517);
            this.usrCtrlLihatSoal.TabIndex = 5;
            // 
            // addSoal3
            // 
            this.addSoal3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.addSoal3.ForeColor = System.Drawing.Color.White;
            this.addSoal3.Location = new System.Drawing.Point(179, 125);
            this.addSoal3.Name = "addSoal3";
            this.addSoal3.Size = new System.Drawing.Size(968, 517);
            this.addSoal3.TabIndex = 4;
            // 
            // addSoal1
            // 
            this.addSoal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.addSoal1.ForeColor = System.Drawing.Color.White;
            this.addSoal1.Location = new System.Drawing.Point(504, 333);
            this.addSoal1.Name = "addSoal1";
            this.addSoal1.Size = new System.Drawing.Size(8, 8);
            this.addSoal1.TabIndex = 3;
            // 
            // lihatDaftarSiswa1
            // 
            this.lihatDaftarSiswa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.lihatDaftarSiswa1.Location = new System.Drawing.Point(178, 128);
            this.lihatDaftarSiswa1.Name = "lihatDaftarSiswa1";
            this.lihatDaftarSiswa1.Size = new System.Drawing.Size(972, 514);
            this.lihatDaftarSiswa1.TabIndex = 9;
            // 
            // manageSoal1
            // 
            this.manageSoal1.Location = new System.Drawing.Point(178, 125);
            this.manageSoal1.Name = "manageSoal1";
            this.manageSoal1.Size = new System.Drawing.Size(972, 514);
            this.manageSoal1.TabIndex = 10;
            // 
            // PanelGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.usrCtrlHome);
            this.Controls.Add(this.lihatDaftarSiswa1);
            this.Controls.Add(this.usrCtlLihatNilai);
            this.Controls.Add(this.z);
            this.Controls.Add(this.usrCtrlBuatSoal);
            this.Controls.Add(this.usrCtrlLihatSoal);
            this.Controls.Add(this.manageSoal1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PanelGuru";
            this.Text = "Panel Guru";
            this.Load += new System.EventHandler(this.PanelGuru_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLihatSoal;
        private System.Windows.Forms.Button btnBerkasSoal;
        private System.Windows.Forms.Button btnBuatSoal;
        private System.Windows.Forms.PictureBox pictureLogo;
        private AddSoal addSoal1;
        private AddSoal addSoal3;
        private AddSoal usrCtrlBuatSoal;
        private System.Windows.Forms.Panel panelKiri;
        private Home usrCtrlHome;
        private LihatSoal usrCtrlLihatSoal;
        private System.Windows.Forms.Button button1;
        private BrankasSoal z;
        private LihatNilaiSiswa usrCtlLihatNilai;
        private LihatDaftarSiswa lihatDaftarSiswa1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ManageSoal manageSoal1;
    }
}