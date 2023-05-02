namespace StonePlanner
{
    partial class Alert
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
            this.listBox_Task = new System.Windows.Forms.ListBox();
            this.metroButton_Close = new MetroFramework.Controls.MetroButton();
            this.panel_Sp = new System.Windows.Forms.Panel();
            this.metroLabel_WorkAlert = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // listBox_Task
            // 
            this.listBox_Task.Font = new System.Drawing.Font("SimSun", 11F);
            this.listBox_Task.FormattingEnabled = true;
            this.listBox_Task.ItemHeight = 15;
            this.listBox_Task.Location = new System.Drawing.Point(20, 55);
            this.listBox_Task.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_Task.Name = "listBox_Task";
            this.listBox_Task.Size = new System.Drawing.Size(365, 64);
            this.listBox_Task.TabIndex = 1;
            // 
            // metroButton_Close
            // 
            this.metroButton_Close.Location = new System.Drawing.Point(17, 173);
            this.metroButton_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton_Close.Name = "metroButton_Close";
            this.metroButton_Close.Size = new System.Drawing.Size(364, 26);
            this.metroButton_Close.TabIndex = 2;
            this.metroButton_Close.Text = "关闭窗口";
            this.metroButton_Close.UseSelectable = true;
            this.metroButton_Close.Click += new System.EventHandler(this.button_S_Click);
            // 
            // panel_Sp
            // 
            this.panel_Sp.BackColor = System.Drawing.Color.Silver;
            this.panel_Sp.Location = new System.Drawing.Point(21, 124);
            this.panel_Sp.Name = "panel_Sp";
            this.panel_Sp.Size = new System.Drawing.Size(362, 5);
            this.panel_Sp.TabIndex = 3;
            // 
            // metroLabel_WorkAlert
            // 
            this.metroLabel_WorkAlert.AutoSize = true;
            this.metroLabel_WorkAlert.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel_WorkAlert.Location = new System.Drawing.Point(17, 140);
            this.metroLabel_WorkAlert.Name = "metroLabel_WorkAlert";
            this.metroLabel_WorkAlert.Size = new System.Drawing.Size(102, 25);
            this.metroLabel_WorkAlert.TabIndex = 4;
            this.metroLabel_WorkAlert.Text = "排班日历：";
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 209);
            this.Controls.Add(this.metroLabel_WorkAlert);
            this.Controls.Add(this.panel_Sp);
            this.Controls.Add(this.metroButton_Close);
            this.Controls.Add(this.listBox_Task);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Alert";
            this.Padding = new System.Windows.Forms.Padding(15, 48, 15, 16);
            this.Text = "逾期任务";
            this.Load += new System.EventHandler(this.Alert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Task;
        private MetroFramework.Controls.MetroButton metroButton_Close;
        private System.Windows.Forms.Panel panel_Sp;
        private MetroFramework.Controls.MetroLabel metroLabel_WorkAlert;
    }
}