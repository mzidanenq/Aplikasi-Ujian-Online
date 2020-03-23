using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectPemdas
{
    public partial class LihatNilaiSiswa : UserControl
    {
        string connectionString = @"Server=localhost;Database=unbk;Uid=root;Pwd=;";
        public LihatNilaiSiswa()
        {
            InitializeComponent();
        }

        private void LihatNilaiSiswa_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getGuru = mysqlCon.CreateCommand();
                    getGuru.CommandText = "select ujian.idUjian as 'ID Ujian',ujian.idSoal as 'ID Soal', siswa.fullName as 'Nama', ujian.idSiswa as 'ID Siswa', ujian.tglPengerjaan as 'Tanggal Pengerjaan', ujian.nilai as 'Nilai', IF(mapel.kkm < ujian.nilai, 'LULUS', 'REMEDIAL') as 'Status' FROM ujian JOIN headersoal ON ujian.idSoal = headersoal.idSoal JOIN mapel ON mapel.idMapel = headersoal.idMapel JOIN siswa ON ujian.idSiswa = siswa.idSiswa";
                    getGuru.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getGuru);
                    da.Fill(dt);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dt;
                    
                    dataGridView1.DataSource = bSource;
                    mysqlCon.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtIdSiswa.Text == "" && txtKodeSoal.Text == "")
            {
                MessageBox.Show("Silahkan Masukkan ID Siswa atau ID Soal terlebih dahulu");
            }
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getGuru = mysqlCon.CreateCommand();
                    getGuru.CommandText = "select ujian.idUjian as 'ID Ujian',ujian.idSoal as 'ID Soal', siswa.fullName as 'Nama', ujian.idSiswa as 'ID Siswa', ujian.tglPengerjaan as 'Tanggal Pengerjaan', ujian.nilai as 'Nilai', IF(mapel.kkm < ujian.nilai, 'LULUS', 'REMEDIAL') as 'Status' FROM ujian JOIN headersoal ON ujian.idSoal = headersoal.idSoal JOIN mapel ON mapel.idMapel = headersoal.idMapel JOIN siswa ON ujian.idSiswa = siswa.idSiswa where ujian.idSiswa = '" + txtIdSiswa.Text+"' OR ujian.idSoal = '"+txtKodeSoal.Text+"'";
                    getGuru.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getGuru);
                    da.Fill(dt);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dt;


                    dataGridView1.DataSource = bSource;
                    mysqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getGuru = mysqlCon.CreateCommand();
                    getGuru.CommandText = "select ujian.idUjian as 'ID Ujian',ujian.idSoal as 'ID Soal', siswa.fullName as 'Nama', ujian.idSiswa as 'ID Siswa', ujian.tglPengerjaan as 'Tanggal Pengerjaan', ujian.nilai as 'Nilai', IF(mapel.kkm < ujian.nilai, 'LULUS', 'REMEDIAL') as 'Status' FROM ujian JOIN headersoal ON ujian.idSoal = headersoal.idSoal JOIN mapel ON mapel.idMapel = headersoal.idMapel JOIN siswa ON ujian.idSiswa = siswa.idSiswa WHERE siswa.fullName LIKE '%" + txtSearchnama.Text + "%'";
                    getGuru.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getGuru);
                    da.Fill(dt);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dt;


                    dataGridView1.DataSource = bSource;
                    mysqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    string date = null;
                    date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    mysqlCon.Open();
                    MySqlCommand getGuru = mysqlCon.CreateCommand();
                    getGuru.CommandText = "select ujian.idUjian as 'ID Ujian',ujian.idSoal as 'ID Soal', siswa.fullName as 'Nama', ujian.idSiswa as 'ID Siswa', ujian.tglPengerjaan as 'Tanggal Pengerjaan', ujian.nilai as 'Nilai', IF(mapel.kkm < ujian.nilai, 'LULUS', 'REMEDIAL') as 'Status' FROM ujian JOIN headersoal ON ujian.idSoal = headersoal.idSoal JOIN mapel ON mapel.idMapel = headersoal.idMapel JOIN siswa ON ujian.idSiswa = siswa.idSiswa WHERE ujian.tglpengerjaan = '" + date +"'";
                    getGuru.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getGuru);
                    da.Fill(dt);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dt;


                    dataGridView1.DataSource = bSource;
                    mysqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void lblJudul_Click(object sender, EventArgs e)
        {

        }
    }
}
