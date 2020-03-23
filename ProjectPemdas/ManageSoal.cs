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
    public partial class ManageSoal : UserControl
    {
        string connectionString = @"Server=localhost;Database=unbk;Uid=root;Pwd=;";
        int idsoal = 0;
        public ManageSoal()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)// picks data from dataGridview                
                {

                    try   // MySql connection
                    {
                        MySqlConnection connection = new MySqlConnection(connectionString);
                        MySqlCommand cmd = new MySqlCommand();
                        cmd = connection.CreateCommand();
                        if (row.IsNewRow) continue;
                        cmd.Parameters.AddWithValue("@idDetailSoal", row.Cells["idDetailSoal"].Value);
                        cmd.Parameters.AddWithValue("@pertanyaan", row.Cells["Pertanyaan"].Value);
                        cmd.Parameters.AddWithValue("@jawabanA", row.Cells["JawabanA"].Value);
                        cmd.Parameters.AddWithValue("@jawabanB", row.Cells["JawabanB"].Value);
                        cmd.Parameters.AddWithValue("@jawabanC", row.Cells["JawabanC"].Value);
                        cmd.Parameters.AddWithValue("@jawabanD", row.Cells["JawabanD"].Value);
                        cmd.Parameters.AddWithValue("@jawabanE", row.Cells["JawabanE"].Value);
                        cmd.Parameters.AddWithValue("@jawabanBenar", row.Cells["JawabanBenar"].Value);

                        cmd.CommandText = "UPDATE detailsoal SET pertanyaan = @pertanyaan, jawabanA = @jawabanA, jawabanB = @jawabanB, jawabanC = @jawabanC,jawabanD = @jawabanD,jawabanE = @jawabanE, jawabanBenar = @jawabanBenar WHERE idDetailSoal = @idDetailSoal";
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        
                        button1.Text = "Refresh";
                        btnUpdate.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }
                MessageBox.Show("Soal Berhasil di edit");

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
        }
        void filldata()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    idsoal = Convert.ToInt32(textBox1.Text);
                    mysqlCon.Open();
                    MySqlCommand getGuru = mysqlCon.CreateCommand();
                    getGuru.CommandText = "SELECT * FROM detailsoal where idsoal = '" + idsoal + "'";
                    getGuru.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getGuru);
                    da.Fill(dt);
                    int zz = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView1.Rows.Add(dt.Rows[zz].Field<int>(1),dt.Rows[zz].Field<string>(2), dt.Rows[zz].Field<int>(0), dt.Rows[zz].Field<string>(3), dt.Rows[zz].Field<string>(4), dt.Rows[zz].Field<string>(5), dt.Rows[zz].Field<string>(6), dt.Rows[zz].Field<string>(7), dt.Rows[zz].Field<string>(8));
                        zz++;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            filldata();

            button1.Text = "View";
        }

        private void ManageSoal_Load(object sender, EventArgs e)
        {

        }
    }
}
