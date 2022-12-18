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
            this.components = new System.ComponentModel.Container();
            this.panel_CM = new System.Windows.Forms.Panel();
            this.label_Now = new System.Windows.Forms.Label();
            this.button_Left = new MetroFramework.Controls.MetroButton();
            this.button_Right = new MetroFramework.Controls.MetroButton();
            this.notifyIconinfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // panel_CM
            // 
            this.panel_CM.Location = new System.Drawing.Point(18, 97);
            this.panel_CM.Margin = new System.Windows.Forms.Padding(2);
            this.panel_CM.Name = "panel_CM";
            this.panel_CM.Size = new System.Drawing.Size(492, 392);
            this.panel_CM.TabIndex = 3;
            // 
            // label_Now
            // 
            this.label_Now.AutoSize = true;
            this.label_Now.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Now.Location = new System.Drawing.Point(215, 73);
            this.label_Now.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Now.Name = "label_Now";
            this.label_Now.Size = new System.Drawing.Size(89, 17);
            this.label_Now.TabIndex = 4;
            this.label_Now.Text = "label_Now";
            // 
            // button_Left
            // 
            this.button_Left.Location = new System.Drawing.Point(181, 70);
            this.button_Left.Margin = new System.Windows.Forms.Padding(2);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(27, 22);
            this.button_Left.TabIndex = 5;
            this.button_Left.Text = "<";
            this.button_Left.UseSelectable = true;
            this.button_Left.Click += new System.EventHandler(this.button_Left_Click);
            // 
            // button_Right
            // 
            this.button_Right.Location = new System.Drawing.Point(305, 70);
            this.button_Right.Margin = new System.Windows.Forms.Padding(2);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(27, 22);
            this.button_Right.TabIndex = 6;
            this.button_Right.Text = ">";
            this.button_Right.UseSelectable = true;
            this.button_Right.Click += new System.EventHandler(this.button_Right_Click);
            // 
            // notifyIconinfo
            // 
            this.notifyIconinfo.Text = "notifyIcon_Info";
            this.notifyIconinfo.Visible = true;
            this.notifyIconinfo.Click += new System.EventHandler(this.notifyIconinfo_Click);
            // 
            // SchedulingCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 500);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.label_Now);
            this.Controls.Add(this.panel_CM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SchedulingCalendar";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "排班日历（标准版）";
            this.Load += new System.EventHandler(this.SchedulingCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_CM;
        private System.Windows.Forms.Label label_Now;
        private MetroFramework.Controls.MetroButton button_Left;
        private MetroFramework.Controls.MetroButton button_Right;
        private System.Windows.Forms.NotifyIcon notifyIconinfo;
    }
}