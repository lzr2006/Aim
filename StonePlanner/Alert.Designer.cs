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
            this.listBox_Task.Font = new System.Drawing.Font("宋体", 11F);
            this.listBox_Task.FormattingEnabled = true;
            this.listBox_Task.ItemHeight = 18;
            this.listBox_Task.Location = new System.Drawing.Point(27, 71);
            this.listBox_Task.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_Task.Name = "listBox_Task";
            this.listBox_Task.Size = new System.Drawing.Size(485, 76);
            this.listBox_Task.TabIndex = 1;
            // 
            // metroButton_Close
            // 
            this.metroButton_Close.Location = new System.Drawing.Point(23, 216);
            this.metroButton_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton_Close.Name = "metroButton_Close";
            this.metroButton_Close.Size = new System.Drawing.Size(485, 32);
            this.metroButton_Close.TabIndex = 2;
            this.metroButton_Close.Text = "关闭窗口";
            this.metroButton_Close.UseSelectable = true;
            this.metroButton_Close.Click += new System.EventHandler(this.button_S_Click);
            // 
            // panel_Sp
            // 
            this.panel_Sp.BackColor = System.Drawing.Color.Silver;
            this.panel_Sp.Location = new System.Drawing.Point(28, 155);
            this.panel_Sp.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Sp.Name = "panel_Sp";
            this.panel_Sp.Size = new System.Drawing.Size(483, 6);
            this.panel_Sp.TabIndex = 3;
            // 
            // metroLabel_WorkAlert
            // 
            this.metroLabel_WorkAlert.AutoSize = true;
            this.metroLabel_WorkAlert.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel_WorkAlert.Location = new System.Drawing.Point(23, 173);
            this.metroLabel_WorkAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel_WorkAlert.Name = "metroLabel_WorkAlert";
            this.metroLabel_WorkAlert.Size = new System.Drawing.Size(102, 25);
            this.metroLabel_WorkAlert.TabIndex = 4;
            this.metroLabel_WorkAlert.Text = "排班日历：";
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 261);
            this.Controls.Add(this.metroLabel_WorkAlert);
            this.Controls.Add(this.panel_Sp);
            this.Controls.Add(this.metroButton_Close);
            this.Controls.Add(this.listBox_Task);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Alert";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 20);
            this.Text = "逾期任务";
            this.TopMost = true;
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