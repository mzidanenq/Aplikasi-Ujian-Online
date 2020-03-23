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

namespace ProjectPemdas
{
    public partial class siswaLihatNilaiSiswa : Form
    {
        string connectionString = @"Server=localhost;Database=unbk;Uid=root;Pwd=;";
        public siswaLihatNilaiSiswa()
        {
            InitializeComponent();
        }

        private void siswaLihatNilaiSiswa_Load(object sender, EventArgs e)
        {
            lblNama.Text = PanelSiswa.namaasiswaa;
            dgt();
        }

        void dgt()
        {
            try
            {

                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand getnilai = mysqlCon.CreateCommand();
                    getnilai.CommandText = "select ujian.idUjian as 'ID Ujian',ujian.idSoal as 'ID Soal',mapel.namaMapel as 'Mapel', ujian.tglPengerjaan as 'Tanggal Pengerjaan', ujian.nilai as 'Nilai' FROM ujian JOIN headersoal ON ujian.idSoal = headersoal.idSoal JOIN mapel ON headersoal.idMapel = mapel.idMapel  WHERE ujian.idSiswa = '" + PanelSiswa.idsiswaa + "'";
                    getnilai.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getnilai);
                    da.Fill(dt);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dt;


                    dataGridView1.DataSource = bSource;
                    mysqlCon.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgt();
        }
    }
}
