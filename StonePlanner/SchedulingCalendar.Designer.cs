namespace StonePlanner
{
    partial class SchedulingCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulingCalendar));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.pictureBox_T_Exit = new System.Windows.Forms.PictureBox();
            this.label_T = new System.Windows.Forms.Label();
            this.panel_CM = new System.Windows.Forms.Panel();
            this.label_Now = new System.Windows.Forms.Label();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.pictureBox_Settings = new System.Windows.Forms.PictureBox();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Top.Controls.Add(this.pictureBox_T_Exit);
            this.panel_Top.Controls.Add(this.label_T);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(493, 30);
            this.panel_Top.TabIndex = 2;
            // 
            // pictureBox_T_Exit
            // 
            this.pictureBox_T_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T_Exit.BackgroundImage")));
            this.pictureBox_T_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_T_Exit.Location = new System.Drawing.Point(468, 2);
            this.pictureBox_T_Exit.Name = "pictureBox_T_Exit";
            this.pictureBox_T_Exit.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_T_Exit.TabIndex = 18;
            this.pictureBox_T_Exit.TabStop = false;
            this.pictureBox_T_Exit.Click += new System.EventHandler(this.pictureBox_T_Exit_Click);
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_T.Location = new System.Drawing.Point(110, 7);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(240, 19);
            this.label_T.TabIndex = 2;
            this.label_T.Text = "      排班日历（标准版）";
            // 
            // panel_CM
            // 
            this.panel_CM.Location = new System.Drawing.Point(1, 70);
            this.panel_CM.Margin = new System.Windows.Forms.Padding(2);
            this.panel_CM.Name = "panel_CM";
            this.panel_CM.Size = new System.Drawing.Size(492, 392);
            this.panel_CM.TabIndex = 3;
            // 
            // label_Now
            // 
            this.label_Now.AutoSize = true;
            this.label_Now.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Now.Location = new System.Drawing.Point(198, 46);
            this.label_Now.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Now.Name = "label_Now";
            this.label_Now.Size = new System.Drawing.Size(89, 17);
            this.label_Now.TabIndex = 4;
            this.label_Now.Text = "label_Now";
            // 
            // button_Left
            // 
            this.button_Left.Location = new System.Drawing.Point(164, 43);
            this.button_Left.Margin = new System.Windows.Forms.Padding(2);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(27, 22);
            this.button_Left.TabIndex = 5;
            this.button_Left.Text = "<";
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Left_Click);
            // 
            // button_Right
            // 
            this.button_Right.Location = new System.Drawing.Point(288, 43);
            this.button_Right.Margin = new System.Windows.Forms.Padding(2);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(27, 22);
            this.button_Right.TabIndex = 6;
            this.button_Right.Text = ">";
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Right_Click);
            // 
            // pictureBox_Settings
            // 
            this.pictureBox_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Settings.BackgroundImage")));
            this.pictureBox_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Settings.Location = new System.Drawing.Point(3, 34);
            this.pictureBox_Settings.Name = "pictureBox_Settings";
            this.pictureBox_Settings.Size = new System.Drawing.Size(35, 33);
            this.pictureBox_Settings.TabIndex = 7;
            this.pictureBox_Settings.TabStop = false;
            // 
            // SchedulingCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 464);
            this.Controls.Add(this.pictureBox_Settings);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.label_Now);
            this.Controls.Add(this.panel_CM);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SchedulingCalendar";
            this.Text = "SchedulingCalendar";
            this.Load += new System.EventHandler(this.SchedulingCalendar_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.PictureBox pictureBox_T_Exit;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.Panel panel_CM;
        private System.Windows.Forms.Label label_Now;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.PictureBox pictureBox_Settings;
    }
}