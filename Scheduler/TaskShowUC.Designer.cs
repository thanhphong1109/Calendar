namespace Scheduler
{
    partial class TaskShowUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskUC_lab = new System.Windows.Forms.Label();
            this.HoursUC_lab = new System.Windows.Forms.Label();
            this.MinuteUC_lab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskUC_lab
            // 
            this.taskUC_lab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskUC_lab.ForeColor = System.Drawing.Color.Black;
            this.taskUC_lab.Location = new System.Drawing.Point(20, 23);
            this.taskUC_lab.Name = "taskUC_lab";
            this.taskUC_lab.Size = new System.Drawing.Size(192, 77);
            this.taskUC_lab.TabIndex = 0;
            this.taskUC_lab.Text = "Taskdetail";
            // 
            // HoursUC_lab
            // 
            this.HoursUC_lab.AutoSize = true;
            this.HoursUC_lab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursUC_lab.ForeColor = System.Drawing.Color.Black;
            this.HoursUC_lab.Location = new System.Drawing.Point(309, 32);
            this.HoursUC_lab.Name = "HoursUC_lab";
            this.HoursUC_lab.Size = new System.Drawing.Size(30, 32);
            this.HoursUC_lab.TabIndex = 0;
            this.HoursUC_lab.Text = "h";
            this.HoursUC_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HoursUC_lab.Click += new System.EventHandler(this.TimeShowUC_lab_Click);
            // 
            // MinuteUC_lab
            // 
            this.MinuteUC_lab.AutoSize = true;
            this.MinuteUC_lab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteUC_lab.ForeColor = System.Drawing.Color.Black;
            this.MinuteUC_lab.Location = new System.Drawing.Point(410, 30);
            this.MinuteUC_lab.Name = "MinuteUC_lab";
            this.MinuteUC_lab.Size = new System.Drawing.Size(39, 32);
            this.MinuteUC_lab.TabIndex = 0;
            this.MinuteUC_lab.Text = "m";
            this.MinuteUC_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinuteUC_lab.Click += new System.EventHandler(this.TimeShowUC_lab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(364, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.TimeShowUC_lab_Click);
            // 
            // TaskShowUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinuteUC_lab);
            this.Controls.Add(this.HoursUC_lab);
            this.Controls.Add(this.taskUC_lab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaskShowUC";
            this.Size = new System.Drawing.Size(510, 100);
            this.Load += new System.EventHandler(this.TaskShowUC_Load);
            this.Click += new System.EventHandler(this.TaskShowUC_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TaskShowUC_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label taskUC_lab;
        public System.Windows.Forms.Label HoursUC_lab;
        public System.Windows.Forms.Label MinuteUC_lab;
        public System.Windows.Forms.Label label3;
    }
}
