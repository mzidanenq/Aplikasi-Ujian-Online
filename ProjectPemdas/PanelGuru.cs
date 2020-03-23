using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPemdas
{
    public partial class PanelGuru : Form
    {
        public PanelGuru()
        {
            InitializeComponent();
            usrCtrlHome.BringToFront();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetText();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelGuru_Load(object sender, EventArgs e)
        {
            lblName.Text = Login.namaguru;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelKiri.Height = btnHome.Height;
            panelKiri.Top = btnHome.Top;
            usrCtrlHome.BringToFront();
        }

        private void btnBuatSoal_Click(object sender, EventArgs e)
        {
            panelKiri.Height = btnBuatSoal.Height;
            panelKiri.Top = btnBuatSoal.Top;
            usrCtrlBuatSoal.BringToFront();
        }

        private void btnBerkasSoal_Click(object sender, EventArgs e)
        {
            panelKiri.Height = btnBerkasSoal.Height;
            panelKiri.Top = btnBerkasSoal.Top;
            z.BringToFront();

        }

        private void btnLihatSoal_Click(object sender, EventArgs e)
        {
            panelKiri.Height = btnLihatSoal.Height;
            panelKiri.Top = btnLihatSoal.Top;
            usrCtrlLihatSoal.BringToFront();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void usrCtrlBuatSoal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelKiri.Height = button1.Height;
            panelKiri.Top = button1.Top;
            usrCtlLihatNilai.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelKiri.Height = button2.Height;
            panelKiri.Top = button2.Top;
            lihatDaftarSiswa1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelKiri.Height = button3.Height;
            panelKiri.Top = button3.Top;
            manageSoal1.BringToFront();

        }
    }
}
