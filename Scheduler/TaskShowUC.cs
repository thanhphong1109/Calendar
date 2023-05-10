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


    public partial class TaskShowUC : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=NTPLAPTOP;Initial Catalog=SCHEDULE;Integrated Security=True");

        public TaskShowUC()
        {
            InitializeComponent();
        }



        private void TaskShowUC_Paint(object sender, PaintEventArgs e)
        {
            /*var panelContainer = this.Parent as Panel;
            var form1 = panelContainer.TopLevelControl as Main;
            taskUC_lab.Text = form1.taskname_txt.Text;*/

        }

        private void TaskShowUC_Click(object sender, EventArgs e)
        {
            var panelContainer = this.Parent as Panel;
            var form1 = panelContainer.TopLevelControl as Main;
            form1.ShowTask(taskUC_lab.Text);
            form1.labeltemp_lab.Text = taskUC_lab.Text;
            


        }

        private void TimeShowUC_lab_Click(object sender, EventArgs e)
        {
            
        }

        private void TaskShowUC_Load(object sender, EventArgs e)
        {
            

        }
    }
}
