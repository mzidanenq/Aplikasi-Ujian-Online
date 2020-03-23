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
    public partial class LihatSoal : UserControl
    {
        public int idsoal = 0;
        string connectionString = @"Server=localhost;Database=unbk;Uid=root;Pwd=;";
        public LihatSoal()
        {
            InitializeComponent();
        }

        private void LihatSoal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int.TryParse(txtIdSoal.Text, out idsoal);
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getGuru = mysqlCon.CreateCommand();
                    getGuru.CommandText = "select headersoal.idSoal as 'ID Soal',mapel.namaMapel as 'Mapel',detailsoal.idNoSoal as 'No',detailsoal.pertanyaan as 'Pertanyaan',detailsoal.jawabanA as 'Jawaban A',detailsoal.jawabanB as 'Jawaban B',detailsoal.jawabanC as 'Jawaban C',detailsoal.jawabanD as 'Jawaban D',detailsoal.jawabanE as 'Jawaban E',detailsoal.jawabanBenar as 'Jawaban Benar',headersoal.waktu as 'Waktu' from headersoal JOIN mapel ON headersoal.idMapel = mapel.idMapel JOIN detailsoal ON headersoal.idSoal = detailsoal.idSoal WHERE headersoal.idSoal = '"+ idsoal + "'";
                    getGuru.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getGuru);
                    da.Fill(dt);

                    MySqlCommand checkheader = mysqlCon.CreateCommand();
                    checkheader.CommandText = "SELECT * FROM headersoal WHERE idSoal = '" + idsoal + "'";
                    checkheader.ExecuteNonQuery();
                    DataTable dthead = new DataTable();
                    MySqlDataAdapter dahead = new MySqlDataAdapter(checkheader);
                    da.Fill(dthead);

                    if(dthead.Rows.Count == 0 )
                    {
                        MessageBox.Show("ID Soal tidak Valid !");
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MySqlCommand deleteheader = mysqlCon.CreateCommand();
                        deleteheader.CommandText = "DELETE FROM headersoal WHERE idSoal = '" + idsoal + "'";
                        deleteheader.ExecuteNonQuery();
                        MessageBox.Show("Berkas soal terhapus tidak ada butir soal pada berkas soal ini");
                    } else
                    {
                        BindingSource bSource = new BindingSource();
                        bSource.DataSource = dt;
                        dataGridView1.DataSource = bSource;
                    }
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
            DialogResult dr = MessageBox.Show("Anda ingin menghapus soal ini ?", "Warning !", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
              if (dr == DialogResult.Yes)  {
                button1.PerformClick();

                DialogResult drs = MessageBox.Show("Soal yang terhapus tidak bisa di kembalikan lagi ! Yakin ?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Stop); 
                if (drs == DialogResult.Yes)
                {
                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            mysqlCon.Open();
                            MySqlCommand delete = mysqlCon.CreateCommand();
                            delete.CommandText = "DELETE FROM headersoal WHERE idSoal = '" + idsoal + "'";
                            delete.ExecuteNonQuery();

                            MySqlCommand deletes = mysqlCon.CreateCommand();
                            deletes.CommandText = "DELETE FROM detailsoal where idSoal = '" + idsoal + "'";
                            deletes.ExecuteNonQuery();
                            MessageBox.Show("Soal Berhasil terhapus","Selamat !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.Rows.Clear();
                            txtIdSoal.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                        }
                else
                {
                    txtIdSoal.Text = "";
                }

            } else
            {
                button1.PerformClick();
            }
        }
    }
}
