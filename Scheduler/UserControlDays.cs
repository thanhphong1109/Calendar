using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class UserControlDays : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=NTPLAPTOP;Initial Catalog=SCHEDULE;Integrated Security=True");
        public UserControlDays()
        {
            InitializeComponent();
        }

        

        public void days(int numday)
        {
            labeldays.Text = numday + "";

            
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            var panelContainer = this.Parent as Panel;
            var form1 = panelContainer.TopLevelControl as Main;
            form1.Detail_pan.Visible= true;
            form1.daydetail_lab.Text = labeldays.Text;
            form1.LoadTask();
               
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

            var panelContainer = this.Parent as Panel;
            var form1 = panelContainer.TopLevelControl as Main;
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TASKNAME , PRIORITY FROM TASK WHERE DAY=@DAY AND MONTH=@MONTH AND YEAR=@YEAR ORDER BY HSTART ASC, MSTART ASC  ";
            cmd.Parameters.AddWithValue("@DAY", Convert.ToInt32(labeldays.Text));
            cmd.Parameters.AddWithValue("@MONTH", Convert.ToInt32(form1.month));
            cmd.Parameters.AddWithValue("@YEAR", Convert.ToInt32(form1.year));

            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                Label tb = new Label();
                tb.AutoSize = false;
                tb.Size = new Size(140, 20);
                tb.Font = new Font("Century Gothic", tb.Font.Size);
                tb.TextAlign = ContentAlignment.MiddleCenter;
                if (da.GetValue(1).ToString() == "Work")
                {
                    tb.BackColor = Color.CornflowerBlue;
                }
                else if (da.GetValue(1).ToString() == "Study")
                {
                    tb.BackColor = Color.Coral;
                }
                else
                {
                    tb.BackColor = Color.SpringGreen;
                }
                tb.Text = da.GetValue(0).ToString();
                Daytask_pan.Controls.Add(tb);
            }

            conn.Close();
        }

        private void UserControlDays_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }
    }
}
