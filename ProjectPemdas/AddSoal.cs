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
    public partial class AddSoal : UserControl
    {
        string connectionString = @"Server=localhost;Database=unbk;Uid=root;Pwd=;";
        public static string jawabanBenars;
        public static int idsoall;
        public static int maxsoal;
        public int nosoall;
        int waktu = 0;
        private static int[] idmapel = new int[10];
        private static int[] idkelas = new int[10];
        public AddSoal()
        {
            InitializeComponent();
        }
        
        private void AddSoal_Load(object sender, EventArgs e)
        {
            nosoall = maxsoal + 1;
            txtNo.Text = nosoall.ToString();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
               
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getMapel = mysqlCon.CreateCommand();
                    getMapel.CommandText = "SELECT guru.idGuru,aksesmapel.idMapel,mapel.namaMapel FROM guru JOIN aksesmapel ON guru.idGuru = aksesmapel.idGuru JOIN mapel ON aksesmapel.idMapel = mapel.idMapel where guru.idGuru = '"+ Login.idguru + "' ";
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

                    
                    if(dt.Rows.Count == 0)
                    {
                        //MessageBox.Show("Anda tidak bisa membuat soal, silahkan menghubungi administrator");
                    } else
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
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void clear()
        {
            txtNo.Text = txtPertanyaan.Text = txtJawabanA.Text = txtJawabanB.Text = txtJawabanC.Text = txtJawabanD.Text = txtJawabanE.Text = "";
            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;
            rdD.Checked = false;
            rdE.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (rdA.Checked)
            {jawabanBenars = "A";} else if (rdB.Checked)
            {jawabanBenars = "B";} else if (rdC.Checked)
            {jawabanBenars = "C";} else if (rdD.Checked)
            {jawabanBenars = "D";} else if (rdE.Checked)
            {jawabanBenars = "E";}

            if (txtPertanyaan.Text == "" || txtJawabanA.Text == "" || txtJawabanB.Text == "" || txtJawabanC.Text == "" || txtJawabanD.Text == "" || txtJawabanE.Text == "")
            {
                MessageBox.Show("Silahkan Isi Pertanyaan dan Jawaban terlebih dahulu", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if(rdA.Checked == false && rdB.Checked == false && rdC.Checked == false && rdD.Checked == false && rdE.Checked == false) {
                MessageBox.Show("Silahkan Pilih jawaban benar terlebih dahulu", "Warning !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {
                    maxsoal++;
                    dataGridView1.Rows.Add(txtNo.Text, txtPertanyaan.Text, txtJawabanA.Text, txtJawabanB.Text, txtJawabanC.Text, txtJawabanD.Text, txtJawabanE.Text, jawabanBenars);
                    clear();
                    int nosoall = maxsoal + 1;
                    txtNo.Text = nosoall.ToString();
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            dataGridView1.Rows.Clear();
            maxsoal = 0;
            int nosoall = maxsoal + 1;
            txtNo.Text = nosoall.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView btnDelete = (DataGridView)sender;
            //int rowindex = dataGridView1.CurrentCell.RowIndex;
            if (btnDelete.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DialogResult dr = MessageBox.Show("Apakah anda ingin menghapus soal ini ?", "Hapus Soal", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    //nosoall = (rowindex + 1) - nosoall;
                    maxsoal -= 1;
                    //txtNo.Text = nosoall.ToString();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (cbKelas.SelectedItem == null && cbMapel.SelectedItem == null)
                {
                    MessageBox.Show("Anda Belum memilih Mapel atau Kelas !");
                } else if(txtWaktu.Text == "")
                {
                    MessageBox.Show("Anda belum memasukkan waktu pengerjaan !");
                }
                else
                {
                    int idmapels = idmapel[cbMapel.SelectedIndex];
                    int idkelass = idkelas[cbKelas.SelectedIndex];
                    waktu = Convert.ToInt32(txtWaktu.Text) * 60;
                    mysqlCon.Open();
                    MySqlCommand getMapel = mysqlCon.CreateCommand();
                    getMapel.CommandText = "INSERT INTO headersoal(idMapel,idGuru,tglDibuat,jumlahSoal,idKelas,waktu) values('" + idmapels + "', '" + Login.idguru + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + dataGridView1.Rows.Count + "', '" + idkelass + "', '"+waktu+"' )";
                    getMapel.ExecuteNonQuery();

                    MySqlCommand getidsoal = mysqlCon.CreateCommand();
                    getidsoal.CommandText = "SELECT idSoal from headersoal order by idSoal desc LIMIT 1";
                    getidsoal.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getidsoal);
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        System.Threading.Thread.Sleep(5000);
                    }
                    else
                    {
                        idsoall = dt.Rows[0].Field<int>(0);
                    }


                    foreach (DataGridViewRow row in dataGridView1.Rows)// picks data from dataGridview                
                    {

                        try   // MySql connection
                        {
                            MySqlConnection connection = new MySqlConnection(connectionString);
                            MySqlCommand cmd = new MySqlCommand();
                            cmd = connection.CreateCommand();
                            if (row.IsNewRow) continue;
                            cmd.Parameters.AddWithValue("@no", row.Cells["no"].Value);
                            cmd.Parameters.AddWithValue("@pertanyaan", row.Cells["pertanyaan"].Value);
                            cmd.Parameters.AddWithValue("@jawabanA", row.Cells["JawabanA"].Value);
                            cmd.Parameters.AddWithValue("@jawabanB", row.Cells["JawabanB"].Value);
                            cmd.Parameters.AddWithValue("@jawabanC", row.Cells["JawabanC"].Value);
                            cmd.Parameters.AddWithValue("@jawabanD", row.Cells["JawabanD"].Value);
                            cmd.Parameters.AddWithValue("@jawabanE", row.Cells["JawabanE"].Value);
                            cmd.Parameters.AddWithValue("@jawabanBenar", row.Cells["JawabanBenar"].Value);
                            cmd.Parameters.AddWithValue("@idSoal", idsoall);

                            cmd.CommandText = "INSERT INTO detailsoal(IdNoSoal,pertanyaan, jawabanA, jawabanB, jawabanC,jawabanD,jawabanE, jawabanBenar, idSoal)VALUES(@no, @pertanyaan, @JawabanA, @JawabanB, @JawabanC, @JawabanD, @JawabanE, @jawabanBenar, @idSoal)";
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

                    MessageBox.Show("Soal Berhasil di Buat");
                    dataGridView1.Rows.Clear();
                    maxsoal = 0;
                    int nosoall = maxsoal + 1;
                    txtNo.Text = nosoall.ToString();
                }
                
            }

        }
    }
}
