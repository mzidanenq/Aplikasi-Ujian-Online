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
    public partial class BrankasSoal : UserControl
    {
        private static int[] idmapel = new int[10];
        private static int[] idkelas = new int[10];
        string connectionString = @"Server=localhost;Database=unbk;Uid=root;Pwd=;";
        public BrankasSoal()
        {
            InitializeComponent();
        }

        private void BrankasSoal_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                try
                {
                    mysqlCon.Open();
                    MySqlCommand getdata = mysqlCon.CreateCommand();
                    getdata.CommandText = "select headersoal.idSoal as 'ID Soal',mapel.namaMapel as 'Mata Pelajaran',guru.fullName as 'Guru Pembuat',headersoal.tglDibuat as 'Tanggal Pembuatan',headersoal.jumlahSoal as 'Jumlah Soal',kelas.namaKelas as 'Kelas' FROM headersoal JOIN mapel ON headersoal.idMapel = mapel.idMapel JOIN guru ON headersoal.idGuru = guru.idGuru JOIN kelas ON headersoal.idKelas = kelas.idKelas ";
                    getdata.ExecuteNonQuery();
                    DataTable dtdata = new DataTable();
                    MySqlDataAdapter dadata = new MySqlDataAdapter(getdata);
                    dadata.Fill(dtdata);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dtdata;
                    dataGridView1.DataSource = bSource;

                    MySqlCommand getMapel = mysqlCon.CreateCommand();
                    getMapel.CommandText = "SELECT guru.idGuru,aksesmapel.idMapel,mapel.namaMapel FROM guru JOIN aksesmapel ON guru.idGuru = aksesmapel.idGuru JOIN mapel ON aksesmapel.idMapel = mapel.idMapel where guru.idGuru = '" + Login.idguru + "' ";
                    getMapel.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getMapel);
                    da.Fill(dt);

                    MySqlCommand getKelas = mysqlCon.CreateCommand();
                    getKelas.CommandText = "SELECT guru.idGuru,akseskelas.idKelas,kelas.namakelas FROM guru JOIN akseskelas ON guru.idGuru = akseskelas.idGuru JOIN kelas ON akseskelas.idKelas = kelas.idKelas where guru.idGuru = '" + Login.idguru + "' ";
                    getKelas.ExecuteNonQuery();
                    DataTable dtkls = new DataTable();
                    MySqlDataAdapter dakls = new MySqlDataAdapter(getKelas);
                    dakls.Fill(dtkls);




                    if (dt.Rows.Count == 0)
                    {
                        //MessageBox.Show("Anda tidak bisa membuat soal, silahkan menghubungi administrator");
                    }
                    else
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cbMapel.Items.Add(dt.Rows[i].Field<string>(2));
                            idmapel[i] = dt.Rows[i].Field<int>(1);
                        }
                        for (int j = 0; j < dtkls.Rows.Count; j++)
                        {
                            cbKelas.Items.Add(dtkls.Rows[j].Field<string>(2));
                            idkelas[j] = dtkls.Rows[j].Field<int>(1);

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (cbKelas.Text == "" || cbMapel.Text == "")
                {
                    MessageBox.Show("Silahkan pilih Mapel dan Kelas terlebih dahulu");
                }
                int idmapels = idmapel[cbMapel.SelectedIndex];
                int idkelass = idkelas[cbKelas.SelectedIndex];
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getdata = mysqlCon.CreateCommand();
                    getdata.CommandText = "select headersoal.idSoal as 'ID Soal',mapel.namaMapel as 'Mata Pelajaran',guru.fullName as 'Guru Pembuat',headersoal.tglDibuat as 'Tanggal Pembuatan',headersoal.jumlahSoal as 'Jumlah Soal',kelas.namaKelas as 'Kelas' FROM headersoal JOIN mapel ON headersoal.idMapel = mapel.idMapel JOIN guru ON headersoal.idGuru = guru.idGuru JOIN kelas ON headersoal.idKelas = kelas.idKelas WHERE headersoal.idMapel = '" + idmapels + "' and headersoal.idKelas = '" + idkelass + "'";
                    getdata.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getdata);
                    da.Fill(dt);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dt;


                    dataGridView1.DataSource = bSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                try
                {
                    mysqlCon.Open();
                    MySqlCommand getdata = mysqlCon.CreateCommand();
                    getdata.CommandText = "select headersoal.idSoal as 'ID Soal',mapel.namaMapel as 'Mata Pelajaran',guru.fullName as 'Guru Pembuat',headersoal.tglDibuat as 'Tanggal Pembuatan',headersoal.jumlahSoal as 'Jumlah Soal',kelas.namaKelas as 'Kelas' FROM headersoal JOIN mapel ON headersoal.idMapel = mapel.idMapel JOIN guru ON headersoal.idGuru = guru.idGuru JOIN kelas ON headersoal.idKelas = kelas.idKelas";
                    getdata.ExecuteNonQuery();
                    DataTable dtdata = new DataTable();
                    MySqlDataAdapter dadata = new MySqlDataAdapter(getdata);
                    dadata.Fill(dtdata);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dtdata;
                    dataGridView1.DataSource = bSource;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
