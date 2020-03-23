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
    public partial class LihatDaftarSiswa : UserControl
    {
        string connectionString = @"Server=localhost;Database=unbk;Uid=root;Pwd=;";
        public LihatDaftarSiswa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getGuru = mysqlCon.CreateCommand();
                    getGuru.CommandType = CommandType.Text;
                    getGuru.CommandText = "SELECT idSiswa as 'ID Siswa', fullName as 'Nama Siswa', kelas as 'Kelas' FROM siswa WHERE fullName LIKE '%" + txtName.Text + "%'";
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

        private void LihatDaftarSiswa_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getGuru = mysqlCon.CreateCommand();
                    getGuru.CommandType = CommandType.Text;
                    getGuru.CommandText = "SELECT idSiswa as 'ID Siswa', fullName as 'Nama Siswa', kelas as 'Kelas' FROM siswa";
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
    }
}
