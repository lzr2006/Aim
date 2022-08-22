namespace StonePlanner
{
    partial class ServerInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerInfo));
            this.panel_ConnectCount = new System.Windows.Forms.Panel();
            this.label_OnlineR = new System.Windows.Forms.Label();
            this.label_OnlineC = new System.Windows.Forms.Label();
            this.pictureBox_P_1 = new System.Windows.Forms.PictureBox();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.label_StatusR = new System.Windows.Forms.Label();
            this.label_StatusC = new System.Windows.Forms.Label();
            this.pictureBox_Status = new System.Windows.Forms.PictureBox();
            this.panel_Runtime = new System.Windows.Forms.Panel();
            this.label_TimeR = new System.Windows.Forms.Label();
            this.label_TimeC = new System.Windows.Forms.Label();
            this.pictureBox_Time = new System.Windows.Forms.PictureBox();
            this.timer_Update = new System.Windows.Forms.Timer(this.components);
            this.listBox_Users = new System.Windows.Forms.ListBox();
            this.label_User = new System.Windows.Forms.Label();
            this.panel_Runner = new System.Windows.Forms.Panel();
            this.button_Task = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.button_Kick = new System.Windows.Forms.Button();
            this.panel_ConnectCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P_1)).BeginInit();
            this.panel_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Status)).BeginInit();
            this.panel_Runtime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Time)).BeginInit();
            this.panel_Runner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ConnectCount
            // 
            this.panel_ConnectCount.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_ConnectCount.Controls.Add(this.label_OnlineR);
            this.panel_ConnectCount.Controls.Add(this.label_OnlineC);
            this.panel_ConnectCount.Controls.Add(this.pictureBox_P_1);
            this.panel_ConnectCount.Location = new System.Drawing.Point(56, 22);
            this.panel_ConnectCount.Name = "panel_ConnectCount";
            this.panel_ConnectCount.Size = new System.Drawing.Size(168, 100);
            this.panel_ConnectCount.TabIndex = 0;
            this.panel_ConnectCount.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ConnectCount_Paint);
            // 
            // label_OnlineR
            // 
            this.label_OnlineR.AutoSize = true;
            this.label_OnlineR.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_OnlineR.Location = new System.Drawing.Point(87, 57);
            this.label_OnlineR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OnlineR.Name = "label_OnlineR";
            this.label_OnlineR.Size = new System.Drawing.Size(39, 16);
            this.label_OnlineR.TabIndex = 2;
            this.label_OnlineR.Text = "12人";
            this.label_OnlineR.TextChanged += new System.EventHandler(this.label_OnlineR_TextChanged);
            // 
            // label_OnlineC
            // 
            this.label_OnlineC.AutoSize = true;
            this.label_OnlineC.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_OnlineC.Location = new System.Drawing.Point(75, 31);
            this.label_OnlineC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OnlineC.Name = "label_OnlineC";
            this.label_OnlineC.Size = new System.Drawing.Size(71, 16);
            this.label_OnlineC.TabIndex = 1;
            this.label_OnlineC.Text = "在线人数";
            // 
            // pictureBox_P_1
            // 
            this.pictureBox_P_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_P_1.BackgroundImage")));
            this.pictureBox_P_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_P_1.Location = new System.Drawing.Point(16, 28);
            this.pictureBox_P_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_P_1.Name = "pictureBox_P_1";
            this.pictureBox_P_1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox_P_1.TabIndex = 1;
            this.pictureBox_P_1.TabStop = false;
            // 
            // panel_Status
            // 
            this.panel_Status.BackColor = System.Drawing.Color.SpringGreen;
            this.panel_Status.Controls.Add(this.label_StatusR);
            this.panel_Status.Controls.Add(this.label_StatusC);
            this.panel_Status.Controls.Add(this.pictureBox_Status);
            this.panel_Status.Location = new System.Drawing.Point(309, 22);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(168, 100);
            this.panel_Status.TabIndex = 1;
            this.panel_Status.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_StatusR
            // 
            this.label_StatusR.AutoSize = true;
            this.label_StatusR.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_StatusR.Location = new System.Drawing.Point(87, 57);
            this.label_StatusR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StatusR.Name = "label_StatusR";
            this.label_StatusR.Size = new System.Drawing.Size(39, 16);
            this.label_StatusR.TabIndex = 2;
            this.label_StatusR.Text = "良好";
            // 
            // label_StatusC
            // 
            this.label_StatusC.AutoSize = true;
            this.label_StatusC.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_StatusC.Location = new System.Drawing.Point(75, 31);
            this.label_StatusC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StatusC.Name = "label_StatusC";
            this.label_StatusC.Size = new System.Drawing.Size(71, 16);
            this.label_StatusC.TabIndex = 1;
            this.label_StatusC.Text = "服务状况";
            // 
            // pictureBox_Status
            // 
            this.pictureBox_Status.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Status.BackgroundImage")));
            this.pictureBox_Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Status.Location = new System.Drawing.Point(16, 28);
            this.pictureBox_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_Status.Name = "pictureBox_Status";
            this.pictureBox_Status.Size = new System.Drawing.Size(45, 47);
            this.pictureBox_Status.TabIndex = 1;
            this.pictureBox_Status.TabStop = false;
            // 
            // panel_Runtime
            // 
            this.panel_Runtime.BackColor = System.Drawing.Color.Orange;
            this.panel_Runtime.Controls.Add(this.label_TimeR);
            this.panel_Runtime.Controls.Add(this.label_TimeC);
            this.panel_Runtime.Controls.Add(this.pictureBox_Time);
            this.panel_Runtime.Location = new System.Drawing.Point(561, 22);
            this.panel_Runtime.Name = "panel_Runtime";
            this.panel_Runtime.Size = new System.Drawing.Size(168, 100);
            this.panel_Runtime.TabIndex = 2;
            this.panel_Runtime.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label_TimeR
            // 
            this.label_TimeR.AutoSize = true;
            this.label_TimeR.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_TimeR.Location = new System.Drawing.Point(76, 57);
            this.label_TimeR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TimeR.Name = "label_TimeR";
            this.label_TimeR.Size = new System.Drawing.Size(71, 16);
            this.label_TimeR.TabIndex = 2;
            this.label_TimeR.Text = "00:00:00";
            // 
            // label_TimeC
            // 
            this.label_TimeC.AutoSize = true;
            this.label_TimeC.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_TimeC.Location = new System.Drawing.Point(75, 31);
            this.label_TimeC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TimeC.Name = "label_TimeC";
            this.label_TimeC.Size = new System.Drawing.Size(71, 16);
            this.label_TimeC.TabIndex = 1;
            this.label_TimeC.Text = "运行时间";
            // 
            // pictureBox_Time
            // 
            this.pictureBox_Time.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Time.BackgroundImage")));
            this.pictureBox_Time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Time.Location = new System.Drawing.Point(16, 28);
            this.pictureBox_Time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_Time.Name = "pictureBox_Time";
            this.pictureBox_Time.Size = new System.Drawing.Size(45, 47);
            this.pictureBox_Time.TabIndex = 1;
            this.pictureBox_Time.TabStop = false;
            // 
            // timer_Update
            // 
            this.timer_Update.Interval = 1000;
            this.timer_Update.Tick += new System.EventHandler(this.timer_Update_Tick);
            // 
            // listBox_Users
            // 
            this.listBox_Users.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_Users.FormattingEnabled = true;
            this.listBox_Users.ItemHeight = 16;
            this.listBox_Users.Location = new System.Drawing.Point(56, 176);
            this.listBox_Users.Name = "listBox_Users";
            this.listBox_Users.Size = new System.Drawing.Size(540, 228);
            this.listBox_Users.TabIndex = 3;
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_User.Location = new System.Drawing.Point(53, 150);
            this.label_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(111, 16);
            this.label_User.TabIndex = 4;
            this.label_User.Text = "用户列表(&L)：";
            // 
            // panel_Runner
            // 
            this.panel_Runner.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Runner.Controls.Add(this.button_Task);
            this.panel_Runner.Controls.Add(this.button_Info);
            this.panel_Runner.Controls.Add(this.button_Kick);
            this.panel_Runner.Location = new System.Drawing.Point(601, 176);
            this.panel_Runner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Runner.Name = "panel_Runner";
            this.panel_Runner.Size = new System.Drawing.Size(128, 227);
            this.panel_Runner.TabIndex = 5;
            // 
            // button_Task
            // 
            this.button_Task.Font = new System.Drawing.Font("SimSun", 11F);
            this.button_Task.Location = new System.Drawing.Point(21, 165);
            this.button_Task.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Task.Name = "button_Task";
            this.button_Task.Size = new System.Drawing.Size(86, 33);
            this.button_Task.TabIndex = 2;
            this.button_Task.Text = "任务设置";
            this.button_Task.UseVisualStyleBackColor = true;
            this.button_Task.Click += new System.EventHandler(this.button_Task_Click);
            // 
            // button_Info
            // 
            this.button_Info.Font = new System.Drawing.Font("SimSun", 11F);
            this.button_Info.Location = new System.Drawing.Point(21, 95);
            this.button_Info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(86, 33);
            this.button_Info.TabIndex = 1;
            this.button_Info.Text = "用户信息";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_Kick
            // 
            this.button_Kick.Font = new System.Drawing.Font("SimSun", 11F);
            this.button_Kick.Location = new System.Drawing.Point(20, 26);
            this.button_Kick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Kick.Name = "button_Kick";
            this.button_Kick.Size = new System.Drawing.Size(86, 33);
            this.button_Kick.TabIndex = 0;
            this.button_Kick.Text = "踢出用户";
            this.button_Kick.UseVisualStyleBackColor = true;
            this.button_Kick.Click += new System.EventHandler(this.button_Kick_Click);
            // 
            // ServerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Runner);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.listBox_Users);
            this.Controls.Add(this.panel_Runtime);
            this.Controls.Add(this.panel_Status);
            this.Controls.Add(this.panel_ConnectCount);
            this.Name = "ServerInfo";
            this.Size = new System.Drawing.Size(956, 445);
            this.Load += new System.EventHandler(this.ServerInfo_Load);
            this.panel_ConnectCount.ResumeLayout(false);
            this.panel_ConnectCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P_1)).EndInit();
            this.panel_Status.ResumeLayout(false);
            this.panel_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Status)).EndInit();
            this.panel_Runtime.ResumeLayout(false);
            this.panel_Runtime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Time)).EndInit();
            this.panel_Runner.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ConnectCount;
        private System.Windows.Forms.Label label_OnlineR;
        private System.Windows.Forms.Label label_OnlineC;
        private System.Windows.Forms.PictureBox pictureBox_P_1;
        private System.Windows.Forms.Panel panel_Status;
        private System.Windows.Forms.Label label_StatusR;
        private System.Windows.Forms.Label label_StatusC;
        private System.Windows.Forms.PictureBox pictureBox_Status;
        private System.Windows.Forms.Panel panel_Runtime;
        private System.Windows.Forms.Label label_TimeR;
        private System.Windows.Forms.Label label_TimeC;
        private System.Windows.Forms.PictureBox pictureBox_Time;
        private System.Windows.Forms.Timer timer_Update;
        private System.Windows.Forms.ListBox listBox_Users;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Panel panel_Runner;
        private System.Windows.Forms.Button button_Kick;
        private System.Windows.Forms.Button button_Task;
        private System.Windows.Forms.Button button_Info;
    }
}
