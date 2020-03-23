using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        public static string namaguru;
        public static string idguru;
        public static string idsiswa;
        public static string namasiswa;
        public static string role;
        string connectionString = @"Server=localhost;Database=unbk;Uid=root;Pwd=;";
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPass.Text = txtUser.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand getGuru = mysqlCon.CreateCommand();
                    getGuru.CommandText = "SELECT * FROM guru where idguru='" + txtUser.Text + "' && password='" + txtPass.Text + "'";
                    getGuru.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(getGuru);
                    da.Fill(dt);

                    MySqlCommand getSiswa = mysqlCon.CreateCommand();
                    getSiswa.CommandText = "SELECT * FROM siswa where idSiswa='" + txtUser.Text + "' && password='" + txtPass.Text + "'";
                    getSiswa.ExecuteNonQuery();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(getSiswa);
                    da1.Fill(dt);


                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Username atau Password anda Salah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPass.Focus();
                        txtPass.Text = "";
                    }
                    else
                    {
                        if (dt.Rows.Count > 0 && dt.Rows[0].Field<string>(3) == "guru")
                        {
                            idguru = dt.Rows[0].Field<string>(0);
                            namaguru = dt.Rows[0].Field<string>(1);

                            MessageBox.Show("Selamat Datang Bapak/Ibu " + namaguru);

                            PanelGuru pnlguru = new PanelGuru();
                            pnlguru.Show();
                            this.Hide();
                        }
                        else
                        {
                            idsiswa = txtUser.Text;
                            namasiswa = dt.Rows[0].Field<string>(1);
                            MessageBox.Show("Selamat Datang Siswa/Siswi " + namasiswa);

                            PanelSiswa pnlsiswa = new PanelSiswa();
                            pnlsiswa.Show();
                            this.Hide();

                        }
                    }
                    mysqlCon.Close();


                } catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menghubungkan ke database : " + ex.Message);
                }


            }
            
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
