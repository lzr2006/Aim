namespace StonePlanner
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Month = new System.Windows.Forms.Label();
            this.label_Anther1 = new System.Windows.Forms.Label();
            this.label_NeedTime = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.pictureBox_T_Exit = new System.Windows.Forms.PictureBox();
            this.label_Sentence = new System.Windows.Forms.Label();
            this.pictureBox_T_More = new System.Windows.Forms.PictureBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.panel_M = new System.Windows.Forms.Panel();
            this.panel_L = new System.Windows.Forms.Panel();
            this.label_YoursTasks = new System.Windows.Forms.Label();
            this.timer_EventHandler = new System.Windows.Forms.Timer(this.components);
            this.timer_PenalLengthController = new System.Windows.Forms.Timer(this.components);
            this.timer_Conv = new System.Windows.Forms.Timer(this.components);
            this.panel_TaskDetail = new System.Windows.Forms.Panel();
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_Ponv = new System.Windows.Forms.Timer(this.components);
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_More)).BeginInit();
            this.panel_M.SuspendLayout();
            this.panel_TaskDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Controls.Add(this.label_Month);
            this.panel_Top.Controls.Add(this.label_Anther1);
            this.panel_Top.Controls.Add(this.label_NeedTime);
            this.panel_Top.Controls.Add(this.label_Date);
            this.panel_Top.Controls.Add(this.pictureBox_T_Exit);
            this.panel_Top.Controls.Add(this.label_Sentence);
            this.panel_Top.Controls.Add(this.pictureBox_T_More);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(662, 30);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(361, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "日";
            // 
            // label_Month
            // 
            this.label_Month.AutoSize = true;
            this.label_Month.Font = new System.Drawing.Font("Cambria", 10F);
            this.label_Month.Location = new System.Drawing.Point(297, 8);
            this.label_Month.Name = "label_Month";
            this.label_Month.Size = new System.Drawing.Size(23, 16);
            this.label_Month.TabIndex = 6;
            this.label_Month.Text = "03";
            // 
            // label_Anther1
            // 
            this.label_Anther1.AutoSize = true;
            this.label_Anther1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label_Anther1.Location = new System.Drawing.Point(318, 8);
            this.label_Anther1.Name = "label_Anther1";
            this.label_Anther1.Size = new System.Drawing.Size(21, 16);
            this.label_Anther1.TabIndex = 7;
            this.label_Anther1.Text = "月";
            // 
            // label_NeedTime
            // 
            this.label_NeedTime.AutoSize = true;
            this.label_NeedTime.Font = new System.Drawing.Font("Cambria", 10F);
            this.label_NeedTime.Location = new System.Drawing.Point(493, 8);
            this.label_NeedTime.Name = "label_NeedTime";
            this.label_NeedTime.Size = new System.Drawing.Size(119, 16);
            this.label_NeedTime.TabIndex = 7;
            this.label_NeedTime.Text = "剩余xx时xx分xx秒";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Cambria", 10F);
            this.label_Date.Location = new System.Drawing.Point(339, 8);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(23, 16);
            this.label_Date.TabIndex = 5;
            this.label_Date.Text = "26";
            // 
            // pictureBox_T_Exit
            // 
            this.pictureBox_T_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T_Exit.BackgroundImage")));
            this.pictureBox_T_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_T_Exit.Location = new System.Drawing.Point(634, 2);
            this.pictureBox_T_Exit.Name = "pictureBox_T_Exit";
            this.pictureBox_T_Exit.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_T_Exit.TabIndex = 2;
            this.pictureBox_T_Exit.TabStop = false;
            this.pictureBox_T_Exit.Click += new System.EventHandler(this.pictureBox_T_Exit_Click);
            // 
            // label_Sentence
            // 
            this.label_Sentence.AutoSize = true;
            this.label_Sentence.Font = new System.Drawing.Font("宋体", 10F);
            this.label_Sentence.Location = new System.Drawing.Point(39, 8);
            this.label_Sentence.Name = "label_Sentence";
            this.label_Sentence.Size = new System.Drawing.Size(175, 14);
            this.label_Sentence.TabIndex = 3;
            this.label_Sentence.Text = "人生如逆旅，我亦是行人。";
            // 
            // pictureBox_T_More
            // 
            this.pictureBox_T_More.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T_More.BackgroundImage")));
            this.pictureBox_T_More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_T_More.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox_T_More.Name = "pictureBox_T_More";
            this.pictureBox_T_More.Size = new System.Drawing.Size(36, 29);
            this.pictureBox_T_More.TabIndex = 1;
            this.pictureBox_T_More.TabStop = false;
            this.pictureBox_T_More.Click += new System.EventHandler(this.pictureBox_T_More_Click);
            // 
            // label_Status
            // 
            this.label_Status.BackColor = System.Drawing.Color.Lime;
            this.label_Status.Font = new System.Drawing.Font("宋体", 15F);
            this.label_Status.Location = new System.Drawing.Point(400, 137);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(89, 29);
            this.label_Status.TabIndex = 3;
            this.label_Status.Text = "烫烫烫烫";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_M
            // 
            this.panel_M.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_M.Controls.Add(this.panel_L);
            this.panel_M.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_M.Location = new System.Drawing.Point(0, 30);
            this.panel_M.Name = "panel_M";
            this.panel_M.Size = new System.Drawing.Size(238, 397);
            this.panel_M.TabIndex = 1;
            // 
            // panel_L
            // 
            this.panel_L.BackColor = System.Drawing.SystemColors.Control;
            this.panel_L.Location = new System.Drawing.Point(0, 0);
            this.panel_L.Name = "panel_L";
            this.panel_L.Size = new System.Drawing.Size(0, 397);
            this.panel_L.TabIndex = 0;
            // 
            // label_YoursTasks
            // 
            this.label_YoursTasks.AutoSize = true;
            this.label_YoursTasks.Font = new System.Drawing.Font("宋体", 14F);
            this.label_YoursTasks.Location = new System.Drawing.Point(515, 183);
            this.label_YoursTasks.Name = "label_YoursTasks";
            this.label_YoursTasks.Size = new System.Drawing.Size(104, 19);
            this.label_YoursTasks.TabIndex = 2;
            this.label_YoursTasks.Text = "烫烫烫烫：";
            // 
            // timer_EventHandler
            // 
            this.timer_EventHandler.Enabled = true;
            this.timer_EventHandler.Tick += new System.EventHandler(this.timer_EventHandler_Tick);
            // 
            // timer_PenalLengthController
            // 
            this.timer_PenalLengthController.Enabled = true;
            this.timer_PenalLengthController.Interval = 5;
            this.timer_PenalLengthController.Tick += new System.EventHandler(this.timer_PenalLengthController_Tick);
            // 
            // timer_Conv
            // 
            this.timer_Conv.Enabled = true;
            this.timer_Conv.Interval = 30000;
            this.timer_Conv.Tick += new System.EventHandler(this.timer_Conv_Tick);
            // 
            // panel_TaskDetail
            // 
            this.panel_TaskDetail.Controls.Add(this.pictureBox_Main);
            this.panel_TaskDetail.Controls.Add(this.label2);
            this.panel_TaskDetail.Location = new System.Drawing.Point(236, 30);
            this.panel_TaskDetail.Name = "panel_TaskDetail";
            this.panel_TaskDetail.Size = new System.Drawing.Size(426, 397);
            this.panel_TaskDetail.TabIndex = 5;
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Main.BackgroundImage")));
            this.pictureBox_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Main.Location = new System.Drawing.Point(0, -3);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(426, 400);
            this.pictureBox_Main.TabIndex = 5;
            this.pictureBox_Main.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // timer_Ponv
            // 
            this.timer_Ponv.Enabled = true;
            this.timer_Ponv.Interval = 30000;
            this.timer_Ponv.Tick += new System.EventHandler(this.timer_Ponv_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 427);
            this.Controls.Add(this.panel_TaskDetail);
            this.Controls.Add(this.panel_M);
            this.Controls.Add(this.label_YoursTasks);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.label_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "盒子待办";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_More)).EndInit();
            this.panel_M.ResumeLayout(false);
            this.panel_TaskDetail.ResumeLayout(false);
            this.panel_TaskDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.PictureBox pictureBox_T_More;
        private System.Windows.Forms.PictureBox pictureBox_T_Exit;
        private System.Windows.Forms.Panel panel_M;
        private System.Windows.Forms.Label label_YoursTasks;
        private System.Windows.Forms.Timer timer_EventHandler;
        private System.Windows.Forms.Panel panel_L;
        private System.Windows.Forms.Timer timer_PenalLengthController;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Sentence;
        private System.Windows.Forms.Timer timer_Conv;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Month;
        private System.Windows.Forms.Label label_NeedTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Anther1;
        private System.Windows.Forms.Panel panel_TaskDetail;
        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_Ponv;
    }
}

