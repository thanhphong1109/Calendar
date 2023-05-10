using System;
using System.CodeDom.Compiler;
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
using System.Windows.Forms.DataVisualization.Charting;


namespace Scheduler
{
    public partial class Main : Form
    {
        public int day, month, year;
        public string timer;
       
        SqlConnection conn = new SqlConnection(@"Data Source=NTPLAPTOP;Initial Catalog=SCHEDULE;Integrated Security=True");
        
        public Main()
        {
            InitializeComponent();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            
            displayDays();            
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthyear_lab.Text = monthname + " " + year;

            Change_Calendar(month, year);
        }

        private void Next_lab_Click(object sender, EventArgs e)
        {
            Calendar_pan.Controls.Clear();
            month++;

            if(month > 12)
            {
                month = 1;
                year += 1;
            }

            Change_Calendar(month, year);
        }
        private void Pre_lab_Click(object sender, EventArgs e)
        {
            Calendar_pan.Controls.Clear();
            month--;

            if (month < 1)
            {
                month = 12;
                year -= 1;
            }

            Change_Calendar(month, year);
        }

        private void Change_Calendar(int m, int y)
        {
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(m);
            monthyear_lab.Text = monthname + " " + y;

            DateTime startofthemonth = new DateTime(y, m, 1);

            int days = DateTime.DaysInMonth(y, m);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucb = new UserControlblank();
                Calendar_pan.Controls.Add(ucb);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.days(i);
                Calendar_pan.Controls.Add(ucd);
            }

            m_comb.Text = monthname;
            y_comb.Text = Convert.ToString(year);

        }

        private void Today_but_Click(object sender, EventArgs e)
        {
            Calendar_pan.Controls.Clear();

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            day = now.Day;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthyear_lab.Text = monthname + " " + year;
            daydetail_lab.Text = day.ToString();
            monthdetail_lab.Text = month.ToString();
            yeardetail_lab.Text = year.ToString();

            Change_Calendar(month, year);
            Detail_pan.Visible = true;
            LoadTask();
        }

        private void m_comb_SelectedValueChanged(object sender, EventArgs e)
        {
            Calendar_pan.Controls.Clear();

            int monthNumber = DateTime.ParseExact(m_comb.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            month = monthNumber;

            Change_Calendar(month, year);
        }

        private void y_comb_SelectedValueChanged(object sender, EventArgs e)
        {
            Calendar_pan.Controls.Clear();
            year = Convert.ToInt32(y_comb.Text);

            Change_Calendar(month, year);
        }

        private void Detail_pan_Paint(object sender, PaintEventArgs e)
        {
            monthdetail_lab.Text = month.ToString();
            yeardetail_lab.Text = year.ToString();
        }
        
        private void Back_pic_Click(object sender, EventArgs e)
        {
            Detail_pan.Visible = false;
            Taskshow_pan.Controls.Clear();
            taskdetail_txt.Clear();
            taskname_txt.Clear();
            hstart_num.Value = 0;
            mstart_num.Value = 0;
            period_num.Value = 0;
            priority_com.Controls.Clear();
            Calendar_pan.Controls.Clear();
            Change_Calendar(month, year);
        }

        private void Exit_picb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            day = Convert.ToInt32(daydetail_lab.Text);

            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO TASK(TASKNAME,TASKDETAIL,HSTART,MSTART,PERIOD,DAY,MONTH,YEAR,PRIORITY)VALUES(@TASKNAME,@TASKDETAIL,@HSTASRT,@MSTART,@PERIOD,@DAY,@MONTH,@YEAR,@PRIORITY)";
            cmd.Parameters.AddWithValue("@TASKNAME", taskname_txt.Text);
            cmd.Parameters.AddWithValue("@TASKDETAIL", taskdetail_txt.Text);
            cmd.Parameters.AddWithValue("@HSTASRT", hstart_num.Value);
            cmd.Parameters.AddWithValue("@MSTART", mstart_num.Value);
            cmd.Parameters.AddWithValue("@PERIOD", period_num.Value);
            cmd.Parameters.AddWithValue("@DAY", day);
            cmd.Parameters.AddWithValue("@MONTH", month);
            cmd.Parameters.AddWithValue("@YEAR", year);
            cmd.Parameters.AddWithValue("@PRIORITY", priority_com.Text);

            cmd.ExecuteNonQuery();


            conn.Close();

            TaskShowUC TSUC = new TaskShowUC();
            TSUC.taskUC_lab.Text = taskname_txt.Text;

            if(hstart_num.Value.ToString().Length == 1)
                TSUC.HoursUC_lab.Text = "0"+hstart_num.Value.ToString();
            else
                TSUC.HoursUC_lab.Text = hstart_num.Value.ToString();
            if(mstart_num.Value.ToString().Length == 1)
                TSUC.MinuteUC_lab.Text = "0"+mstart_num.Value.ToString();
            else
                TSUC.MinuteUC_lab.Text = mstart_num.Value.ToString();
            
            Taskshow_pan.Controls.Add(TSUC);
            Taskshow_pan.Controls.Clear();
            LoadTask();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE TASK " +
                "SET TASKNAME=@TASKNAME , TASKDETAIL=@TASKDETAIL , HSTART=@HSTART , MSTART=@MSTART , " +
                "PERIOD=@PERIOD , PRIORITY=@PRIORITY " +
                "WHERE TASKNAME = @TASKNAMETEMP";
            cmd.Parameters.AddWithValue("@TASKNAMETEMP", labeltemp_lab.Text );
            cmd.Parameters.AddWithValue("@TASKNAME", taskname_txt.Text);
            cmd.Parameters.AddWithValue("@TASKDETAIL", taskdetail_txt.Text);
            cmd.Parameters.AddWithValue("@HSTART", hstart_num.Value);
            cmd.Parameters.AddWithValue("@MSTART", mstart_num.Value);
            cmd.Parameters.AddWithValue("@PERIOD", period_num.Value);
            cmd.Parameters.AddWithValue("@PRIORITY", priority_com.Text);
            cmd.ExecuteNonQuery();
            Taskshow_pan.Controls.Clear();
            conn.Close();
            LoadTask();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to clear this task?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM TASK WHERE TASKNAME = @TASKNAMETEMP AND DAY=@DAY AND MONTH=@MONTH AND YEAR=@YEAR";
                cmd.Parameters.AddWithValue("@TASKNAMETEMP", labeltemp_lab.Text);
                cmd.Parameters.AddWithValue("@DAY", daydetail_lab.Text);
                cmd.Parameters.AddWithValue("@MONTH", monthdetail_lab.Text);
                cmd.Parameters.AddWithValue("@YEAR", yeardetail_lab.Text);
                cmd.ExecuteNonQuery();
                Taskshow_pan.Controls.Clear();
                conn.Close();
                LoadTask();
            }
        }

        private void ClearAll_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to clear all tasks?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM TASK WHERE DAY=@DAY AND MONTH=@MONTH AND YEAR=@YEAR ";
                cmd.Parameters.AddWithValue("@DAY", daydetail_lab.Text);
                cmd.Parameters.AddWithValue("@MONTH", monthdetail_lab.Text);
                cmd.Parameters.AddWithValue("@YEAR", yeardetail_lab.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                Taskshow_pan.Controls.Clear();
                LoadTask();
            }            
        }

        private void Stack_chart_pan_Paint(object sender, PaintEventArgs e)
        {
            StackedChart.Series["Work"].Points.Clear();
            StackedChart.Series["Study"].Points.Clear();
            StackedChart.Series["Other"].Points.Clear();

            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM TASK WHERE PRIORITY='Work' AND DAY=@DAY AND MONTH=@MONTH AND YEAR = @YEAR";
            cmd.Parameters.AddWithValue("@DAY", daydetail_lab.Text);
            cmd.Parameters.AddWithValue("@MONTH", monthdetail_lab.Text);
            cmd.Parameters.AddWithValue("@YEAR", yeardetail_lab.Text);
            Int32 countW = (Int32)cmd.ExecuteScalar();
            cmd.CommandText = "SELECT COUNT(*) FROM TASK WHERE PRIORITY='Study'AND DAY=@DAY AND MONTH=@MONTH AND YEAR = @YEAR";
            
            Int32 countS = (Int32)cmd.ExecuteScalar();
            cmd.CommandText = "SELECT COUNT(*) FROM TASK WHERE PRIORITY='Other'AND DAY=@DAY AND MONTH=@MONTH AND YEAR = @YEAR";
            
            Int32 countO = (Int32)cmd.ExecuteScalar();

            StackedChart.Series["Study"].Points.AddY(countS);
            StackedChart.Series["Other"].Points.AddY(countO);
            StackedChart.Series["Work"].Points.AddY(countW);
            

            conn.Close();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void StackedChart_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Stack_chart_pan.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Stack_chart_pan.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            if (textBox1.Text == "")
            {
                flowLayoutPanel1.Controls.Clear();
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                

                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT TASKNAME, PRIORITY, DAY, MONTH, YEAR FROM TASK WHERE TASKNAME LIKE '%" + textBox1.Text + "%'";

                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    SearchUC S = new SearchUC();

                    S.SearchName_lab.Text = da.GetValue(0).ToString();
                    S.Searchtype_lab.Text = da.GetValue(1).ToString();
                    S.SearchDay_lab.Text = da.GetValue(2).ToString();
                    S.SearchMonth_lab.Text = da.GetValue(3).ToString();
                    S.Searchyear_lab.Text = (da.GetValue(4).ToString());
                    flowLayoutPanel1.Controls.Add(S);
                }

                
            }
            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Arlam_pic_Click(object sender, EventArgs e)
        {
            Arlam_pic.Image = Properties.Resources.icons8_checked_checkbox_50;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           timer= DateTime.Now.ToString("H:m");
            string timenow;
            timenow = hstart_num.Value.ToString() + ":" + mstart_num.Value.ToString();

            if (timer == timenow)
            {
                timer1.Enabled = false;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\iPhone Alarm Radar Sound Effect.wav");
                player.Play();
                MessageBox.Show("It's time to  " + taskname_txt.Text);

            }


        }

        private void Search_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        public void LoadTask()
        {
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TASKNAME,HSTART,MSTART,PRIORITY FROM TASK WHERE DAY=@day AND MONTH=@month AND YEAR=@year ORDER BY HSTART ASC, MSTART ASC";
            cmd.Parameters.AddWithValue("@day", int.Parse(daydetail_lab.Text));
            cmd.Parameters.AddWithValue("@month", int.Parse(monthdetail_lab.Text));
            cmd.Parameters.AddWithValue("@year", int.Parse(yeardetail_lab.Text));
                        
            SqlDataReader da = cmd.ExecuteReader();
            
            while (da.Read())
            {
                TaskShowUC a = new TaskShowUC();
                a.taskUC_lab.Text = da.GetValue(0).ToString();
                a.HoursUC_lab.Text = da.GetValue(1).ToString();
                a.MinuteUC_lab.Text = da.GetValue(2).ToString();
                if(da.GetValue(1).ToString().Length == 1   )
                    a.HoursUC_lab.Text = "0"+da.GetValue(1).ToString(); 
                else
                    a.HoursUC_lab.Text = da.GetValue(1).ToString();
                if (da.GetValue(2).ToString().Length == 1)
                   a.MinuteUC_lab.Text = "0" + da.GetValue(2).ToString();
                else
                    a.MinuteUC_lab.Text = da.GetValue(2).ToString();
                if (da.GetValue(3).ToString() == "Work")
                {
                    
                    a.BackColor = Color.CornflowerBlue;
                }
                else if (da.GetValue(3).ToString() == "Study")
                {
                    
                    a.BackColor = Color.Coral;
                }
                else
                {
                    
                    a.BackColor = Color.SpringGreen;
                }
                Taskshow_pan.Controls.Add(a);
            }

            conn.Close();
        }
        public void ShowTask(string a)
        {
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM TASK WHERE TASKNAME=@taskname";
            cmd.Parameters.AddWithValue("@taskname", a);

            SqlDataReader da = cmd.ExecuteReader();
            da.Read();

                taskname_txt.Text = da.GetValue(0).ToString();
                taskdetail_txt.Text = da.GetValue(1).ToString();
                hstart_num.Value = Convert.ToInt32(da.GetValue(2));
                mstart_num.Value = Convert.ToInt32(da.GetValue(3));
                period_num.Value = Convert.ToInt32(da.GetValue(4));
                priority_com.Text = da.GetValue(8).ToString();

            conn.Close();
        }
        



    }
}
