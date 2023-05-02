namespace StonePlanner
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_switchSwttings = new System.Windows.Forms.GroupBox();
            this.label_SentenceSwitchTime_F = new System.Windows.Forms.Label();
            this.textBox_SentenceSwitchTime_R = new System.Windows.Forms.TextBox();
            this.label_SentenceSwitchTime_C = new System.Windows.Forms.Label();
            this.checkBox_SentenceSwitch = new System.Windows.Forms.CheckBox();
            this.label_PictureSwitchTime_F = new System.Windows.Forms.Label();
            this.textBox_PictureSwitchTime_R = new System.Windows.Forms.TextBox();
            this.label_PictureSwitchTime_C = new System.Windows.Forms.Label();
            this.checkBox_PictureSwitch = new System.Windows.Forms.CheckBox();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.checkBox_LoginSwitch = new System.Windows.Forms.CheckBox();
            this.checkBox_StartSwitch = new System.Windows.Forms.CheckBox();
            this.vScrollBar_Control = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel_Main.SuspendLayout();
            this.groupBox_switchSwttings.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.button_Save);
            this.panel_Main.Controls.Add(this.groupBox_switchSwttings);
            this.panel_Main.Controls.Add(this.groupBox_Info);
            this.panel_Main.Location = new System.Drawing.Point(9, 84);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(448, 702);
            this.panel_Main.TabIndex = 0;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("宋体", 10.5F);
            this.button_Save.Location = new System.Drawing.Point(-7, 672);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(448, 34);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "保存";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // groupBox_switchSwttings
            // 
            this.groupBox_switchSwttings.Controls.Add(this.label_SentenceSwitchTime_F);
            this.groupBox_switchSwttings.Controls.Add(this.textBox_SentenceSwitchTime_R);
            this.groupBox_switchSwttings.Controls.Add(this.label_SentenceSwitchTime_C);
            this.groupBox_switchSwttings.Controls.Add(this.checkBox_SentenceSwitch);
            this.groupBox_switchSwttings.Controls.Add(this.label_PictureSwitchTime_F);
            this.groupBox_switchSwttings.Controls.Add(this.textBox_PictureSwitchTime_R);
            this.groupBox_switchSwttings.Controls.Add(this.label_PictureSwitchTime_C);
            this.groupBox_switchSwttings.Controls.Add(this.checkBox_PictureSwitch);
            this.groupBox_switchSwttings.Font = new System.Drawing.Font("宋体", 10.5F);
            this.groupBox_switchSwttings.Location = new System.Drawing.Point(-3, 9);
            this.groupBox_switchSwttings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_switchSwttings.Name = "groupBox_switchSwttings";
            this.groupBox_switchSwttings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_switchSwttings.Size = new System.Drawing.Size(440, 154);
            this.groupBox_switchSwttings.TabIndex = 0;
            this.groupBox_switchSwttings.TabStop = false;
            this.groupBox_switchSwttings.Text = "切换设置";
            // 
            // label_SentenceSwitchTime_F
            // 
            this.label_SentenceSwitchTime_F.AutoSize = true;
            this.label_SentenceSwitchTime_F.Location = new System.Drawing.Point(355, 122);
            this.label_SentenceSwitchTime_F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SentenceSwitchTime_F.Name = "label_SentenceSwitchTime_F";
            this.label_SentenceSwitchTime_F.Size = new System.Drawing.Size(44, 18);
            this.label_SentenceSwitchTime_F.TabIndex = 7;
            this.label_SentenceSwitchTime_F.Text = "毫秒";
            // 
            // textBox_SentenceSwitchTime_R
            // 
            this.textBox_SentenceSwitchTime_R.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SentenceSwitchTime_R.Location = new System.Drawing.Point(195, 116);
            this.textBox_SentenceSwitchTime_R.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_SentenceSwitchTime_R.Name = "textBox_SentenceSwitchTime_R";
            this.textBox_SentenceSwitchTime_R.Size = new System.Drawing.Size(156, 27);
            this.textBox_SentenceSwitchTime_R.TabIndex = 6;
            this.textBox_SentenceSwitchTime_R.Text = "3000";
            // 
            // label_SentenceSwitchTime_C
            // 
            this.label_SentenceSwitchTime_C.AutoSize = true;
            this.label_SentenceSwitchTime_C.Location = new System.Drawing.Point(4, 120);
            this.label_SentenceSwitchTime_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SentenceSwitchTime_C.Name = "label_SentenceSwitchTime_C";
            this.label_SentenceSwitchTime_C.Size = new System.Drawing.Size(170, 18);
            this.label_SentenceSwitchTime_C.TabIndex = 5;
            this.label_SentenceSwitchTime_C.Text = "首页句子切换时间：";
            // 
            // checkBox_SentenceSwitch
            // 
            this.checkBox_SentenceSwitch.AutoSize = true;
            this.checkBox_SentenceSwitch.Location = new System.Drawing.Point(8, 91);
            this.checkBox_SentenceSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_SentenceSwitch.Name = "checkBox_SentenceSwitch";
            this.checkBox_SentenceSwitch.Size = new System.Drawing.Size(138, 22);
            this.checkBox_SentenceSwitch.TabIndex = 4;
            this.checkBox_SentenceSwitch.Text = "首页句子切换";
            this.checkBox_SentenceSwitch.UseVisualStyleBackColor = true;
            // 
            // label_PictureSwitchTime_F
            // 
            this.label_PictureSwitchTime_F.AutoSize = true;
            this.label_PictureSwitchTime_F.Location = new System.Drawing.Point(355, 65);
            this.label_PictureSwitchTime_F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PictureSwitchTime_F.Name = "label_PictureSwitchTime_F";
            this.label_PictureSwitchTime_F.Size = new System.Drawing.Size(44, 18);
            this.label_PictureSwitchTime_F.TabIndex = 3;
            this.label_PictureSwitchTime_F.Text = "毫秒";
            // 
            // textBox_PictureSwitchTime_R
            // 
            this.textBox_PictureSwitchTime_R.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PictureSwitchTime_R.Location = new System.Drawing.Point(195, 59);
            this.textBox_PictureSwitchTime_R.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_PictureSwitchTime_R.Name = "textBox_PictureSwitchTime_R";
            this.textBox_PictureSwitchTime_R.Size = new System.Drawing.Size(156, 27);
            this.textBox_PictureSwitchTime_R.TabIndex = 2;
            this.textBox_PictureSwitchTime_R.Text = "3000";
            // 
            // label_PictureSwitchTime_C
            // 
            this.label_PictureSwitchTime_C.AutoSize = true;
            this.label_PictureSwitchTime_C.Location = new System.Drawing.Point(4, 62);
            this.label_PictureSwitchTime_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PictureSwitchTime_C.Name = "label_PictureSwitchTime_C";
            this.label_PictureSwitchTime_C.Size = new System.Drawing.Size(188, 18);
            this.label_PictureSwitchTime_C.TabIndex = 1;
            this.label_PictureSwitchTime_C.Text = "首页风景图切换时间：";
            // 
            // checkBox_PictureSwitch
            // 
            this.checkBox_PictureSwitch.AutoSize = true;
            this.checkBox_PictureSwitch.Location = new System.Drawing.Point(8, 34);
            this.checkBox_PictureSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_PictureSwitch.Name = "checkBox_PictureSwitch";
            this.checkBox_PictureSwitch.Size = new System.Drawing.Size(156, 22);
            this.checkBox_PictureSwitch.TabIndex = 0;
            this.checkBox_PictureSwitch.Text = "首页风景图切换";
            this.checkBox_PictureSwitch.UseVisualStyleBackColor = true;
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.checkBox_LoginSwitch);
            this.groupBox_Info.Controls.Add(this.checkBox_StartSwitch);
            this.groupBox_Info.Font = new System.Drawing.Font("宋体", 10.5F);
            this.groupBox_Info.Location = new System.Drawing.Point(-3, 168);
            this.groupBox_Info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Info.Size = new System.Drawing.Size(440, 92);
            this.groupBox_Info.TabIndex = 2;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "自提示相关";
            // 
            // checkBox_LoginSwitch
            // 
            this.checkBox_LoginSwitch.AutoSize = true;
            this.checkBox_LoginSwitch.Location = new System.Drawing.Point(8, 62);
            this.checkBox_LoginSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_LoginSwitch.Name = "checkBox_LoginSwitch";
            this.checkBox_LoginSwitch.Size = new System.Drawing.Size(210, 22);
            this.checkBox_LoginSwitch.TabIndex = 4;
            this.checkBox_LoginSwitch.Text = "自动登录最后一个账户";
            this.checkBox_LoginSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBox_StartSwitch
            // 
            this.checkBox_StartSwitch.AutoSize = true;
            this.checkBox_StartSwitch.Location = new System.Drawing.Point(8, 34);
            this.checkBox_StartSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_StartSwitch.Name = "checkBox_StartSwitch";
            this.checkBox_StartSwitch.Size = new System.Drawing.Size(174, 22);
            this.checkBox_StartSwitch.TabIndex = 0;
            this.checkBox_StartSwitch.Text = "设置为开机启动项";
            this.checkBox_StartSwitch.UseVisualStyleBackColor = true;
            // 
            // vScrollBar_Control
            // 
            this.vScrollBar_Control.Location = new System.Drawing.Point(459, 85);
            this.vScrollBar_Control.Maximum = 200;
            this.vScrollBar_Control.Name = "vScrollBar_Control";
            this.vScrollBar_Control.Size = new System.Drawing.Size(23, 489);
            this.vScrollBar_Control.TabIndex = 1;
            this.vScrollBar_Control.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-37, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 92);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文细黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "软件设置";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Location = new System.Drawing.Point(5, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 10);
            this.panel2.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Location = new System.Drawing.Point(495, 20);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(15, 15);
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar_Control);
            this.Controls.Add(this.panel_Main);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 20);
            this.Text = "设置项";
            this.panel_Main.ResumeLayout(false);
            this.groupBox_switchSwttings.ResumeLayout(false);
            this.groupBox_switchSwttings.PerformLayout();
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.VScrollBar vScrollBar_Control;
        private System.Windows.Forms.GroupBox groupBox_switchSwttings;
        private System.Windows.Forms.CheckBox checkBox_PictureSwitch;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_SentenceSwitchTime_F;
        private System.Windows.Forms.TextBox textBox_SentenceSwitchTime_R;
        private System.Windows.Forms.Label label_SentenceSwitchTime_C;
        private System.Windows.Forms.CheckBox checkBox_SentenceSwitch;
        private System.Windows.Forms.Label label_PictureSwitchTime_F;
        private System.Windows.Forms.TextBox textBox_PictureSwitchTime_R;
        private System.Windows.Forms.Label label_PictureSwitchTime_C;
        private System.Windows.Forms.GroupBox groupBox_Info;
        private System.Windows.Forms.CheckBox checkBox_LoginSwitch;
        private System.Windows.Forms.CheckBox checkBox_StartSwitch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Exit;
    }
}