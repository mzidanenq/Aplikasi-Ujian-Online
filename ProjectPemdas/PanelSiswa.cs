using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ProjectPemdas
{
    public partial class PanelSiswa : Form
    {
        public static string namaasiswaa;
        public static string idsiswaa;
        double nilai = 0;
        double point = 0;
        int timeLeft;
        int h = 0;
        int asem = 0;
        List<String> pertanyaan = new List<String>();
        List<String> jawabanA = new List<String>();
        List<String> jawabanB = new List<String>();
        List<String> jawabanC = new List<String>();
        List<String> jawabanD = new List<String>();
        List<String> jawabanE = new List<String>();
        List<String> jawabanBenar = new List<String>();
        //List<String> jawabandia = new List<String>();
        private static string[] jawabandia = new string[10];
        string mapel;
        string kelas;
        int jumlahsoal;
        string connectionString = @"Server=localhost;Database=unbk;Uid=root;Pwd=;";
        public PanelSiswa()
        {

            InitializeComponent();
            timer2.Start();
            disablebeforestart();
        }
        void sendSoal()
        {
            try
            {
                for (int zz = 0; zz < pertanyaan.Count();)
                {
                    //MessageBox.Show(zz + 1 + jawabandia[zz] + " == " + jawabanBenar[zz]);
                    if (jawabandia[zz] == jawabanBenar[zz])
                    {
                        nilai += point;
                        MessageBox.Show(nilai.ToString());
                    }
                    zz++;
                }
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand sendSoal = mysqlCon.CreateCommand();
                    sendSoal.CommandText = "INSERT INTO ujian(idSoal,idSiswa,tglPengerjaan,nilai) values('" + txtKodeSoal.Text + "', '" + Login.idsiswa + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + nilai + "')";
                    sendSoal.ExecuteNonQuery();
                    mysqlCon.Close();
                }
                MessageBox.Show("Selamat " + Login.namasiswa + " Anda Mendapatkan Nilai " + nilai);
                h = 0;
                nilai = 0;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void inputjawaban()
        {
            if (h < pertanyaan.Count())
            {
                if (rdA.Checked) { jawabandia[h] = "A"; }
                else if (rdB.Checked) { jawabandia[h] = "B"; }
                else if (rdC.Checked) { jawabandia[h] = "C"; }
                else if (rdD.Checked) { jawabandia[h] = "D"; }
                else if (rdE.Checked) { jawabandia[h] = "E"; }
            }
            
        }


        void getsoal()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand getsoal = mysqlCon.CreateCommand();
                getsoal.CommandText = "SELECT pertanyaan as 'Pertanyaan',jawabanA as 'jawabanA',jawabanB as 'jawabanB',jawabanC as 'jawabanC',jawabanD as 'jawabanD',jawabanE as 'jawabanE',jawabanBenar as 'Jawaban Benar'  ,IdNoSoal FROM detailsoal where idsoal='" + txtKodeSoal.Text + "'";
                getsoal.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(getsoal);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    pertanyaan.Add(row["Pertanyaan"].ToString());
                    jawabanA.Add(row["jawabanA"].ToString());
                    jawabanB.Add(row["jawabanB"].ToString());
                    jawabanC.Add(row["jawabanC"].ToString());
                    jawabanD.Add(row["jawabanD"].ToString());
                    jawabanE.Add(row["jawabanE"].ToString());
                    jawabanBenar.Add(row["Jawaban Benar"].ToString());
                }
                nextback();
            }
        }

        void nextback()
        {
            if (h < pertanyaan.Count())
            {
                asem = h + 1;
                txtNo.Text = asem.ToString();
                txtPertanyaan.Text = pertanyaan[h];
                txtA.Text = jawabanA[h];
                txtB.Text = jawabanB[h];
                txtC.Text = jawabanC[h];
                txtD.Text = jawabanD[h];
                txtE.Text = jawabanE[h];
                if (jawabandia.Count() > 0)
                {
                    if (jawabandia[h] == "A")
                    {
                        rdA.Checked = true;
                    }
                    else if (jawabandia[h] == "B")
                    {
                        rdB.Checked = true;
                    }
                    else if (jawabandia[h] == "C")
                    {
                        rdC.Checked = true;
                    }
                    else if (jawabandia[h] == "D")
                    {
                        rdD.Checked = true;
                    }
                    else if (jawabandia[h] == "E")
                    {
                        rdE.Checked = true;
                    }

                }
            }
            else
            {
                MessageBox.Show("Soal sudah habis !", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult dr = MessageBox.Show("Ingin merubah jawaban ?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dr == DialogResult.No) {
                    disablebeforestart();
                    MessageBox.Show("Silahkan klik tombol Submit");
                } else
                {
                    MessageBox.Show("Silahkan klik tombol back");
                }
            }
        }
        void disableafterstart()
        {
            btnNext.Enabled = true;
            button1.Enabled = true;
            btnSend.Enabled = false;
            rdA.Enabled = rdB.Enabled = rdC.Enabled = rdD.Enabled = rdE.Enabled = true;
        }
        void disablebeforestart()
        {
            btnNext.Enabled = false;
            button1.Enabled = false;
            btnSend.Enabled = true;
            rdA.Enabled = rdB.Enabled = rdC.Enabled = rdD.Enabled = rdE.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdA.Checked == false && rdB.Checked == false && rdC.Checked == false && rdD.Checked == false && rdE.Checked == false)
            {
                MessageBox.Show("Silahkan Pilih Jawaban Terlebih dahulu !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                
                DialogResult result = MessageBox.Show("Anda Yakin dengan Jawaban Anda ?", "Konfirmasi Jawaban", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    inputjawaban();
                    clear();
                    h++;
                    clearbtn();
                    nextback();
                }

               

            }

        }

        void clear()
        {
            txtNo.Text = txtPertanyaan.Text = txtA.Text = txtB.Text = txtC.Text = txtD.Text = txtE.Text = "";
        }
        void clearbtn() {
            rdA.Checked = rdB.Checked = rdC.Checked = rdD.Checked = rdE.Checked = false;
            }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getdata = mysqlCon.CreateCommand();
                    getdata.CommandText = "SELECT headersoal.jumlahSoal,mapel.namaMapel,kelas.namaKelas,headersoal.waktu FROM headersoal JOIN mapel ON headersoal.idMapel = mapel.idMapel JOIN kelas ON headersoal.idKelas = kelas.idKelas where headersoal.idSoal = '" + txtKodeSoal.Text + "' LIMIT 1";
                    getdata.ExecuteNonQuery();

                    MySqlDataAdapter dadata = new MySqlDataAdapter(getdata);
                    DataTable dtdata = new DataTable();
                    dadata.Fill(dtdata);

                    //check duplikat ngerjain
                    MySqlCommand getdup = mysqlCon.CreateCommand();
                    getdup.CommandText = "SELECT ujian.idSoal,headersoal.idSoal FROM ujian JOIN headersoal ON ujian.idSoal = headersoal.idSoal where ujian.idSoal = '" + txtKodeSoal.Text + "' and ujian.idSiswa = '" + txtIdSiswa.Text + "' LIMIT 1";
                    getdup.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(getdup);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    jumlahsoal = dtdata.Rows[0].Field<int>(0);
                    if (jumlahsoal >= 1)
                        {

                        if (dt.Rows.Count < 1)
                            {
                            string[] jawabandia = new string[jumlahsoal];
                            txtButirSoal.Text = jumlahsoal.ToString();
                            lblnoooo.Text = "/ " + jumlahsoal.ToString();
                            point = 100.00 / jumlahsoal;
                            txtMapel.Text = mapel = dtdata.Rows[0].Field<string>(1);
                            txtKelas.Text = kelas = dtdata.Rows[0].Field<string>(2);
                            txtKodeSoal.Enabled = false;
                            btnStart.Enabled = false;
                            disableafterstart();
                            getsoal();
                            timeLeft = dtdata.Rows[0].Field<int>(3);
                            int ggwp = timeLeft / 60;
                            txtWaktu.Text = ggwp.ToString() + " Menit";
                            timer1.Start();
                            }

                            else
                            {
                            MessageBox.Show("Anda Sudah Mengerjakan Soal Ini");
                            }


                            
                        }
                        else
                        {
                        MessageBox.Show("Kode Soal tidak Valid !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKodeSoal.Text = "";

                    }

                   


                    mysqlCon.Close();
                } catch (Exception)
                {
                    MessageBox.Show("Kode Soal tidak Valid !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKodeSoal.Text = "";
                }
                    
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendSoal();
            timer1.Stop();
            txtKodeSoal.Enabled = true;
            btnStart.Enabled = true;
            btnSend.Enabled = false;
            txtKodeSoal.Text = "";
            siswaLihatNilaiSiswa lhtnilai = new siswaLihatNilaiSiswa();
            lhtnilai.Show();
        }

        private void PanelSiswa_Load(object sender, EventArgs e)
        {
            txtIdSiswa.Text = Login.idsiswa;
            txtNama.Text = Login.namasiswa;
            idsiswaa = txtIdSiswa.Text;
            namaasiswaa = txtNama.Text;
        }

        private void txtWaktu_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                txtWaktu.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                btnSend.PerformClick();
                txtWaktu.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtJam.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }

        private void nilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siswaLihatNilaiSiswa lhtnilai = new siswaLihatNilaiSiswa();
            lhtnilai.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetText();
            pertanyaan.Clear();
            jawabanA.Clear();
            jawabanB.Clear();
            jawabanC.Clear();
            jawabanD.Clear();
            jawabanE.Clear();
            jawabanBenar.Clear();
            Array.Clear(jawabandia, 0, jawabandia.Length);
            clearbtn();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (h == 0)
            {
                MessageBox.Show("Soal tidak tersedia");
            } else
            {
                clear();
                h--;
                nextback();
            }
            
        }
    }
}
