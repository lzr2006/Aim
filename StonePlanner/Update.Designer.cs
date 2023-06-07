namespace StonePlanner
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.metroRadioButton_Release = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton_Beta = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton_Dev = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel_Route = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_NowVersion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_NewVersion = new MetroFramework.Controls.MetroLabel();
            this.Button_Submit = new MetroFramework.Controls.MetroButton();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel_Info = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // metroRadioButton_Release
            // 
            this.metroRadioButton_Release.AutoSize = true;
            this.metroRadioButton_Release.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton_Release.Location = new System.Drawing.Point(17, 65);
            this.metroRadioButton_Release.Name = "metroRadioButton_Release";
            this.metroRadioButton_Release.Size = new System.Drawing.Size(81, 19);
            this.metroRadioButton_Release.TabIndex = 0;
            this.metroRadioButton_Release.Text = "发行通道";
            this.metroRadioButton_Release.UseSelectable = true;
            this.metroRadioButton_Release.CheckedChanged += new System.EventHandler(this.metroRadioButton_Release_CheckedChanged);
            // 
            // metroRadioButton_Beta
            // 
            this.metroRadioButton_Beta.AutoSize = true;
            this.metroRadioButton_Beta.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton_Beta.Location = new System.Drawing.Point(17, 114);
            this.metroRadioButton_Beta.Name = "metroRadioButton_Beta";
            this.metroRadioButton_Beta.Size = new System.Drawing.Size(80, 19);
            this.metroRadioButton_Beta.TabIndex = 1;
            this.metroRadioButton_Beta.Text = "Beta通道";
            this.metroRadioButton_Beta.UseSelectable = true;
            this.metroRadioButton_Beta.CheckedChanged += new System.EventHandler(this.metroRadioButton_Beta_CheckedChanged);
            // 
            // metroRadioButton_Dev
            // 
            this.metroRadioButton_Dev.AutoSize = true;
            this.metroRadioButton_Dev.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton_Dev.Location = new System.Drawing.Point(17, 159);
            this.metroRadioButton_Dev.Name = "metroRadioButton_Dev";
            this.metroRadioButton_Dev.Size = new System.Drawing.Size(77, 19);
            this.metroRadioButton_Dev.TabIndex = 2;
            this.metroRadioButton_Dev.Text = "Dev通道";
            this.metroRadioButton_Dev.UseSelectable = true;
            this.metroRadioButton_Dev.CheckedChanged += new System.EventHandler(this.metroRadioButton_Dev_CheckedChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel_Route);
            this.metroPanel1.Controls.Add(this.metroRadioButton_Dev);
            this.metroPanel1.Controls.Add(this.metroRadioButton_Beta);
            this.metroPanel1.Controls.Add(this.metroRadioButton_Release);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(7, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(124, 200);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel_Route
            // 
            this.metroLabel_Route.AutoSize = true;
            this.metroLabel_Route.Location = new System.Drawing.Point(27, 23);
            this.metroLabel_Route.Name = "metroLabel_Route";
            this.metroLabel_Route.Size = new System.Drawing.Size(65, 19);
            this.metroLabel_Route.TabIndex = 3;
            this.metroLabel_Route.Text = "升级通道";
            // 
            // metroLabel_NowVersion
            // 
            this.metroLabel_NowVersion.AutoSize = true;
            this.metroLabel_NowVersion.Location = new System.Drawing.Point(164, 158);
            this.metroLabel_NowVersion.Name = "metroLabel_NowVersion";
            this.metroLabel_NowVersion.Size = new System.Drawing.Size(211, 19);
            this.metroLabel_NowVersion.TabIndex = 4;
            this.metroLabel_NowVersion.Text = "当前版本：Dev.23060702_1102(33)";
            // 
            // metroLabel_NewVersion
            // 
            this.metroLabel_NewVersion.AutoSize = true;
            this.metroLabel_NewVersion.Location = new System.Drawing.Point(164, 195);
            this.metroLabel_NewVersion.Name = "metroLabel_NewVersion";
            this.metroLabel_NewVersion.Size = new System.Drawing.Size(211, 19);
            this.metroLabel_NewVersion.TabIndex = 5;
            this.metroLabel_NewVersion.Text = "最新版本：Dev.23060702_1102(33)";
            // 
            // Button_Submit
            // 
            this.Button_Submit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Button_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Button_Submit.Location = new System.Drawing.Point(164, 222);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(211, 34);
            this.Button_Submit.Style = MetroFramework.MetroColorStyle.White;
            this.Button_Submit.TabIndex = 1145;
            this.Button_Submit.Text = "一键升级";
            this.Button_Submit.UseSelectable = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.BackgroundImage")));
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Logo.Location = new System.Drawing.Point(230, 54);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(70, 66);
            this.pictureBox_Logo.TabIndex = 7;
            this.pictureBox_Logo.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(365, 315);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(10, 13);
            this.metroButton1.TabIndex = 155;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // metroLabel_Info
            // 
            this.metroLabel_Info.AutoSize = true;
            this.metroLabel_Info.Location = new System.Drawing.Point(219, 126);
            this.metroLabel_Info.Name = "metroLabel_Info";
            this.metroLabel_Info.Size = new System.Drawing.Size(88, 19);
            this.metroLabel_Info.TabIndex = 1146;
            this.metroLabel_Info.Text = "获取信息中...";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 283);
            this.Controls.Add(this.metroLabel_Info);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.metroLabel_NewVersion);
            this.Controls.Add(this.metroLabel_NowVersion);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Update";
            this.Text = "软件升级";
            this.Load += new System.EventHandler(this.Update_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton metroRadioButton_Release;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton_Beta;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton_Dev;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel_Route;
        private MetroFramework.Controls.MetroLabel metroLabel_NowVersion;
        private MetroFramework.Controls.MetroLabel metroLabel_NewVersion;
        private MetroFramework.Controls.MetroButton Button_Submit;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel_Info;
    }
}