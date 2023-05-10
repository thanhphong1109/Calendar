namespace Scheduler
{
    partial class UserControlDays
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
            this.labeldays = new System.Windows.Forms.Label();
            this.Daytask_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labeldays
            // 
            this.labeldays.AutoSize = true;
            this.labeldays.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldays.Location = new System.Drawing.Point(64, 0);
            this.labeldays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldays.Name = "labeldays";
            this.labeldays.Size = new System.Drawing.Size(38, 27);
            this.labeldays.TabIndex = 0;
            this.labeldays.Text = "00";
            // 
            // Daytask_pan
            // 
            this.Daytask_pan.AutoScroll = true;
            this.Daytask_pan.Location = new System.Drawing.Point(2, 28);
            this.Daytask_pan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Daytask_pan.Name = "Daytask_pan";
            this.Daytask_pan.Size = new System.Drawing.Size(163, 83);
            this.Daytask_pan.TabIndex = 1;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Daytask_pan);
            this.Controls.Add(this.labeldays);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(158, 113);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.MouseLeave += new System.EventHandler(this.UserControlDays_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserControlDays_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        public System.Windows.Forms.Label labeldays;
        private System.Windows.Forms.FlowLayoutPanel Daytask_pan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
