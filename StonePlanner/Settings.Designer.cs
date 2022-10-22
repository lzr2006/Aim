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
            this.vScrollBar_Control = new System.Windows.Forms.VScrollBar();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.checkBox_LoginSwitch = new System.Windows.Forms.CheckBox();
            this.checkBox_StartSwitch = new System.Windows.Forms.CheckBox();
            this.panel_Main.SuspendLayout();
            this.groupBox_switchSwttings.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.groupBox_Info);
            this.panel_Main.Controls.Add(this.button_Save);
            this.panel_Main.Controls.Add(this.groupBox_switchSwttings);
            this.panel_Main.Location = new System.Drawing.Point(1, -1);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(448, 702);
            this.panel_Main.TabIndex = 0;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("宋体", 10.5F);
            this.button_Save.Location = new System.Drawing.Point(0, 669);
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
            this.groupBox_switchSwttings.Location = new System.Drawing.Point(4, 5);
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
            this.label_SentenceSwitchTime_F.Location = new System.Drawing.Point(361, 119);
            this.label_SentenceSwitchTime_F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SentenceSwitchTime_F.Name = "label_SentenceSwitchTime_F";
            this.label_SentenceSwitchTime_F.Size = new System.Drawing.Size(44, 18);
            this.label_SentenceSwitchTime_F.TabIndex = 7;
            this.label_SentenceSwitchTime_F.Text = "毫秒";
            // 
            // textBox_SentenceSwitchTime_R
            // 
            this.textBox_SentenceSwitchTime_R.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SentenceSwitchTime_R.Location = new System.Drawing.Point(201, 112);
            this.textBox_SentenceSwitchTime_R.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_SentenceSwitchTime_R.Name = "textBox_SentenceSwitchTime_R";
            this.textBox_SentenceSwitchTime_R.Size = new System.Drawing.Size(156, 27);
            this.textBox_SentenceSwitchTime_R.TabIndex = 6;
            this.textBox_SentenceSwitchTime_R.Text = "3000";
            // 
            // label_SentenceSwitchTime_C
            // 
            this.label_SentenceSwitchTime_C.AutoSize = true;
            this.label_SentenceSwitchTime_C.Location = new System.Drawing.Point(11, 116);
            this.label_SentenceSwitchTime_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SentenceSwitchTime_C.Name = "label_SentenceSwitchTime_C";
            this.label_SentenceSwitchTime_C.Size = new System.Drawing.Size(170, 18);
            this.label_SentenceSwitchTime_C.TabIndex = 5;
            this.label_SentenceSwitchTime_C.Text = "首页句子切换时间：";
            // 
            // checkBox_SentenceSwitch
            // 
            this.checkBox_SentenceSwitch.AutoSize = true;
            this.checkBox_SentenceSwitch.Location = new System.Drawing.Point(15, 88);
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
            this.label_PictureSwitchTime_F.Location = new System.Drawing.Point(361, 61);
            this.label_PictureSwitchTime_F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PictureSwitchTime_F.Name = "label_PictureSwitchTime_F";
            this.label_PictureSwitchTime_F.Size = new System.Drawing.Size(44, 18);
            this.label_PictureSwitchTime_F.TabIndex = 3;
            this.label_PictureSwitchTime_F.Text = "毫秒";
            // 
            // textBox_PictureSwitchTime_R
            // 
            this.textBox_PictureSwitchTime_R.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PictureSwitchTime_R.Location = new System.Drawing.Point(201, 55);
            this.textBox_PictureSwitchTime_R.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_PictureSwitchTime_R.Name = "textBox_PictureSwitchTime_R";
            this.textBox_PictureSwitchTime_R.Size = new System.Drawing.Size(156, 27);
            this.textBox_PictureSwitchTime_R.TabIndex = 2;
            this.textBox_PictureSwitchTime_R.Text = "3000";
            // 
            // label_PictureSwitchTime_C
            // 
            this.label_PictureSwitchTime_C.AutoSize = true;
            this.label_PictureSwitchTime_C.Location = new System.Drawing.Point(11, 59);
            this.label_PictureSwitchTime_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PictureSwitchTime_C.Name = "label_PictureSwitchTime_C";
            this.label_PictureSwitchTime_C.Size = new System.Drawing.Size(188, 18);
            this.label_PictureSwitchTime_C.TabIndex = 1;
            this.label_PictureSwitchTime_C.Text = "首页风景图切换时间：";
            // 
            // checkBox_PictureSwitch
            // 
            this.checkBox_PictureSwitch.AutoSize = true;
            this.checkBox_PictureSwitch.Location = new System.Drawing.Point(15, 30);
            this.checkBox_PictureSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_PictureSwitch.Name = "checkBox_PictureSwitch";
            this.checkBox_PictureSwitch.Size = new System.Drawing.Size(156, 22);
            this.checkBox_PictureSwitch.TabIndex = 0;
            this.checkBox_PictureSwitch.Text = "首页风景图切换";
            this.checkBox_PictureSwitch.UseVisualStyleBackColor = true;
            // 
            // vScrollBar_Control
            // 
            this.vScrollBar_Control.Location = new System.Drawing.Point(451, 0);
            this.vScrollBar_Control.Maximum = 200;
            this.vScrollBar_Control.Name = "vScrollBar_Control";
            this.vScrollBar_Control.Size = new System.Drawing.Size(23, 489);
            this.vScrollBar_Control.TabIndex = 1;
            this.vScrollBar_Control.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.checkBox_LoginSwitch);
            this.groupBox_Info.Controls.Add(this.checkBox_StartSwitch);
            this.groupBox_Info.Font = new System.Drawing.Font("宋体", 10.5F);
            this.groupBox_Info.Location = new System.Drawing.Point(4, 164);
            this.groupBox_Info.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Info.Size = new System.Drawing.Size(440, 92);
            this.groupBox_Info.TabIndex = 2;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "自提示相关";
            // 
            // checkBox_LoginSwitch
            // 
            this.checkBox_LoginSwitch.AutoSize = true;
            this.checkBox_LoginSwitch.Location = new System.Drawing.Point(15, 59);
            this.checkBox_LoginSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_LoginSwitch.Name = "checkBox_LoginSwitch";
            this.checkBox_LoginSwitch.Size = new System.Drawing.Size(210, 22);
            this.checkBox_LoginSwitch.TabIndex = 4;
            this.checkBox_LoginSwitch.Text = "自动登录最后一个账户";
            this.checkBox_LoginSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBox_StartSwitch
            // 
            this.checkBox_StartSwitch.AutoSize = true;
            this.checkBox_StartSwitch.Location = new System.Drawing.Point(15, 30);
            this.checkBox_StartSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_StartSwitch.Name = "checkBox_StartSwitch";
            this.checkBox_StartSwitch.Size = new System.Drawing.Size(174, 22);
            this.checkBox_StartSwitch.TabIndex = 0;
            this.checkBox_StartSwitch.Text = "设置为开机启动项";
            this.checkBox_StartSwitch.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 490);
            this.Controls.Add(this.vScrollBar_Control);
            this.Controls.Add(this.panel_Main);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Settings";
            this.Text = "设置项";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel_Main.ResumeLayout(false);
            this.groupBox_switchSwttings.ResumeLayout(false);
            this.groupBox_switchSwttings.PerformLayout();
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
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
    }
}