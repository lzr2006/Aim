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
            this.label_GGS = new System.Windows.Forms.Label();
            this.User_Piicture = new System.Windows.Forms.PictureBox();
            this.label_NeedTime = new System.Windows.Forms.Label();
            this.pictureBox_T_Exit = new System.Windows.Forms.PictureBox();
            this.label_Sentence = new System.Windows.Forms.Label();
            this.pictureBox_T_More = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Month = new System.Windows.Forms.Label();
            this.label_Anther1 = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.panel_M = new System.Windows.Forms.Panel();
            this.panel_L = new System.Windows.Forms.Panel();
            this.label_YoursTasks = new System.Windows.Forms.Label();
            this.timer_EventHandler = new System.Windows.Forms.Timer(this.components);
            this.timer_PenalLengthController = new System.Windows.Forms.Timer(this.components);
            this.timer_Conv = new System.Windows.Forms.Timer(this.components);
            this.panel_TaskDetail = new System.Windows.Forms.Panel();
            this.label_XHDL = new System.Windows.Forms.Label();
            this.pictureBox_Tip = new System.Windows.Forms.PictureBox();
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vScrollBar_Main = new System.Windows.Forms.VScrollBar();
            this.timer_Ponv = new System.Windows.Forms.Timer(this.components);
            this.timer_Tip = new System.Windows.Forms.Timer(this.components);
            this.timer_Anti = new System.Windows.Forms.Timer(this.components);
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_Piicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_More)).BeginInit();
            this.panel_M.SuspendLayout();
            this.panel_TaskDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Top.Controls.Add(this.label_GGS);
            this.panel_Top.Controls.Add(this.User_Piicture);
            this.panel_Top.Controls.Add(this.label_NeedTime);
            this.panel_Top.Controls.Add(this.pictureBox_T_Exit);
            this.panel_Top.Controls.Add(this.label_Sentence);
            this.panel_Top.Controls.Add(this.pictureBox_T_More);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(900, 38);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Top_Paint);
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_GGS
            // 
            this.label_GGS.AutoSize = true;
            this.label_GGS.Font = new System.Drawing.Font("Cascadia Code", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GGS.Location = new System.Drawing.Point(481, 20);
            this.label_GGS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GGS.Name = "label_GGS";
            this.label_GGS.Size = new System.Drawing.Size(28, 16);
            this.label_GGS.TabIndex = 9;
            this.label_GGS.Text = "0.0";
            // 
            // User_Piicture
            // 
            this.User_Piicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User_Piicture.BackgroundImage")));
            this.User_Piicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_Piicture.Location = new System.Drawing.Point(439, 2);
            this.User_Piicture.Margin = new System.Windows.Forms.Padding(4);
            this.User_Piicture.Name = "User_Piicture";
            this.User_Piicture.Size = new System.Drawing.Size(43, 34);
            this.User_Piicture.TabIndex = 8;
            this.User_Piicture.TabStop = false;
            this.User_Piicture.Click += new System.EventHandler(this.User_Piicture_Click);
            this.User_Piicture.DoubleClick += new System.EventHandler(this.User_Piicture_DoubleClick);
            // 
            // label_NeedTime
            // 
            this.label_NeedTime.AutoSize = true;
            this.label_NeedTime.Font = new System.Drawing.Font("Cambria", 10F);
            this.label_NeedTime.Location = new System.Drawing.Point(657, 10);
            this.label_NeedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NeedTime.Name = "label_NeedTime";
            this.label_NeedTime.Size = new System.Drawing.Size(147, 20);
            this.label_NeedTime.TabIndex = 7;
            this.label_NeedTime.Text = "剩余xx时xx分xx秒";
            this.label_NeedTime.Click += new System.EventHandler(this.label_NeedTime_Click);
            // 
            // pictureBox_T_Exit
            // 
            this.pictureBox_T_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T_Exit.BackgroundImage")));
            this.pictureBox_T_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_T_Exit.Location = new System.Drawing.Point(859, 2);
            this.pictureBox_T_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_T_Exit.Name = "pictureBox_T_Exit";
            this.pictureBox_T_Exit.Size = new System.Drawing.Size(33, 31);
            this.pictureBox_T_Exit.TabIndex = 2;
            this.pictureBox_T_Exit.TabStop = false;
            this.pictureBox_T_Exit.Click += new System.EventHandler(this.pictureBox_T_Exit_Click);
            // 
            // label_Sentence
            // 
            this.label_Sentence.AutoSize = true;
            this.label_Sentence.Font = new System.Drawing.Font("宋体", 10F);
            this.label_Sentence.Location = new System.Drawing.Point(52, 10);
            this.label_Sentence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sentence.Name = "label_Sentence";
            this.label_Sentence.Size = new System.Drawing.Size(212, 17);
            this.label_Sentence.TabIndex = 3;
            this.label_Sentence.Text = "人生如逆旅，我亦是行人。";
            // 
            // pictureBox_T_More
            // 
            this.pictureBox_T_More.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T_More.BackgroundImage")));
            this.pictureBox_T_More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_T_More.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox_T_More.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_T_More.Name = "pictureBox_T_More";
            this.pictureBox_T_More.Size = new System.Drawing.Size(48, 36);
            this.pictureBox_T_More.TabIndex = 1;
            this.pictureBox_T_More.TabStop = false;
            this.pictureBox_T_More.Click += new System.EventHandler(this.pictureBox_T_More_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(249, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "日";
            // 
            // label_Month
            // 
            this.label_Month.AutoSize = true;
            this.label_Month.Font = new System.Drawing.Font("Cambria", 10F);
            this.label_Month.Location = new System.Drawing.Point(164, 191);
            this.label_Month.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Month.Name = "label_Month";
            this.label_Month.Size = new System.Drawing.Size(27, 20);
            this.label_Month.TabIndex = 6;
            this.label_Month.Text = "03";
            // 
            // label_Anther1
            // 
            this.label_Anther1.AutoSize = true;
            this.label_Anther1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label_Anther1.Location = new System.Drawing.Point(192, 191);
            this.label_Anther1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Anther1.Name = "label_Anther1";
            this.label_Anther1.Size = new System.Drawing.Size(27, 20);
            this.label_Anther1.TabIndex = 7;
            this.label_Anther1.Text = "月";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Cambria", 10F);
            this.label_Date.Location = new System.Drawing.Point(220, 191);
            this.label_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(27, 20);
            this.label_Date.TabIndex = 5;
            this.label_Date.Text = "26";
            // 
            // label_Status
            // 
            this.label_Status.BackColor = System.Drawing.Color.Lime;
            this.label_Status.Font = new System.Drawing.Font("宋体", 15F);
            this.label_Status.Location = new System.Drawing.Point(533, 171);
            this.label_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(119, 36);
            this.label_Status.TabIndex = 3;
            this.label_Status.Text = "烫烫烫烫";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_M
            // 
            this.panel_M.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_M.Controls.Add(this.panel_L);
            this.panel_M.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_M.Location = new System.Drawing.Point(0, 38);
            this.panel_M.Margin = new System.Windows.Forms.Padding(4);
            this.panel_M.Name = "panel_M";
            this.panel_M.Size = new System.Drawing.Size(315, 496);
            this.panel_M.TabIndex = 1;
            // 
            // panel_L
            // 
            this.panel_L.BackColor = System.Drawing.SystemColors.Control;
            this.panel_L.Location = new System.Drawing.Point(0, 0);
            this.panel_L.Margin = new System.Windows.Forms.Padding(4);
            this.panel_L.Name = "panel_L";
            this.panel_L.Size = new System.Drawing.Size(0, 496);
            this.panel_L.TabIndex = 0;
            // 
            // label_YoursTasks
            // 
            this.label_YoursTasks.AutoSize = true;
            this.label_YoursTasks.Font = new System.Drawing.Font("宋体", 14F);
            this.label_YoursTasks.Location = new System.Drawing.Point(687, 229);
            this.label_YoursTasks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_YoursTasks.Name = "label_YoursTasks";
            this.label_YoursTasks.Size = new System.Drawing.Size(130, 24);
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
            this.timer_PenalLengthController.Interval = 3;
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
            this.panel_TaskDetail.Controls.Add(this.label_XHDL);
            this.panel_TaskDetail.Controls.Add(this.pictureBox_Tip);
            this.panel_TaskDetail.Controls.Add(this.pictureBox_Main);
            this.panel_TaskDetail.Controls.Add(this.label2);
            this.panel_TaskDetail.Controls.Add(this.label1);
            this.panel_TaskDetail.Controls.Add(this.label_Date);
            this.panel_TaskDetail.Controls.Add(this.label_Anther1);
            this.panel_TaskDetail.Controls.Add(this.label_Month);
            this.panel_TaskDetail.Location = new System.Drawing.Point(339, 38);
            this.panel_TaskDetail.Margin = new System.Windows.Forms.Padding(4);
            this.panel_TaskDetail.Name = "panel_TaskDetail";
            this.panel_TaskDetail.Size = new System.Drawing.Size(563, 496);
            this.panel_TaskDetail.TabIndex = 5;
            // 
            // label_XHDL
            // 
            this.label_XHDL.AutoSize = true;
            this.label_XHDL.Location = new System.Drawing.Point(565, 481);
            this.label_XHDL.Name = "label_XHDL";
            this.label_XHDL.Size = new System.Drawing.Size(15, 15);
            this.label_XHDL.TabIndex = 10;
            this.label_XHDL.Text = "0";
            // 
            // pictureBox_Tip
            // 
            this.pictureBox_Tip.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Tip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Tip.BackgroundImage")));
            this.pictureBox_Tip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Tip.Location = new System.Drawing.Point(713, 312);
            this.pictureBox_Tip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Tip.Name = "pictureBox_Tip";
            this.pictureBox_Tip.Size = new System.Drawing.Size(113, 109);
            this.pictureBox_Tip.TabIndex = 9;
            this.pictureBox_Tip.TabStop = false;
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Main.BackgroundImage")));
            this.pictureBox_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Main.Location = new System.Drawing.Point(4, -4);
            this.pictureBox_Main.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(567, 500);
            this.pictureBox_Main.TabIndex = 5;
            this.pictureBox_Main.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // vScrollBar_Main
            // 
            this.vScrollBar_Main.LargeChange = 1;
            this.vScrollBar_Main.Location = new System.Drawing.Point(317, 38);
            this.vScrollBar_Main.Maximum = 0;
            this.vScrollBar_Main.Name = "vScrollBar_Main";
            this.vScrollBar_Main.Size = new System.Drawing.Size(19, 496);
            this.vScrollBar_Main.TabIndex = 0;
            this.vScrollBar_Main.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Main_Scroll);
            // 
            // timer_Ponv
            // 
            this.timer_Ponv.Enabled = true;
            this.timer_Ponv.Interval = 30000;
            this.timer_Ponv.Tick += new System.EventHandler(this.timer_Ponv_Tick);
            // 
            // timer_Tip
            // 
            this.timer_Tip.Enabled = true;
            this.timer_Tip.Interval = 6;
            this.timer_Tip.Tick += new System.EventHandler(this.timer_Tip_Tick);
            // 
            // timer_Anti
            // 
            this.timer_Anti.Enabled = true;
            this.timer_Anti.Interval = 10000;
            this.timer_Anti.Tick += new System.EventHandler(this.timer_Anti_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 534);
            this.Controls.Add(this.panel_TaskDetail);
            this.Controls.Add(this.panel_M);
            this.Controls.Add(this.label_YoursTasks);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.vScrollBar_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "盒子待办";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_Piicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_More)).EndInit();
            this.panel_M.ResumeLayout(false);
            this.panel_TaskDetail.ResumeLayout(false);
            this.panel_TaskDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tip)).EndInit();
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
        private System.Windows.Forms.PictureBox User_Piicture;
        private System.Windows.Forms.Label label_GGS;
        private System.Windows.Forms.VScrollBar vScrollBar_Main;
        private System.Windows.Forms.PictureBox pictureBox_Tip;
        private System.Windows.Forms.Timer timer_Tip;
        private System.Windows.Forms.Timer timer_Anti;
        private System.Windows.Forms.Label label_XHDL;
    }
}

