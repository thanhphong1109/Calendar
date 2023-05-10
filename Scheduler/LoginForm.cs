using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class LoginForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=NTPLAPTOP;Initial Catalog=SCHEDULE;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = username_txt.Text;
            password = password_txt.Text;

            try
            {
                string query = "SELECT *FROM USERINFO WHERE USERNAME =  '" + username_txt.Text + "' AND PASSWORD = '" + password_txt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = username_txt.Text;
                    password = password_txt.Text;
                    Main form1 = new Main();
                    form1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    username_txt.Clear();
                    password_txt.Clear();
                }

            }
            catch
            {
                MessageBox.Show("error!");

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
