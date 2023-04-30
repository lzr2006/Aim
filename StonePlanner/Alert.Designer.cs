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
            this.SuspendLayout();
            // 
            // listBox_Task
            // 
            this.listBox_Task.Font = new System.Drawing.Font("宋体", 11F);
            this.listBox_Task.FormattingEnabled = true;
            this.listBox_Task.ItemHeight = 18;
            this.listBox_Task.Location = new System.Drawing.Point(27, 69);
            this.listBox_Task.Name = "listBox_Task";
            this.listBox_Task.Size = new System.Drawing.Size(485, 94);
            this.listBox_Task.TabIndex = 1;
            // 
            // metroButton_Close
            // 
            this.metroButton_Close.Location = new System.Drawing.Point(27, 178);
            this.metroButton_Close.Name = "metroButton_Close";
            this.metroButton_Close.Size = new System.Drawing.Size(485, 33);
            this.metroButton_Close.TabIndex = 2;
            this.metroButton_Close.Text = "关闭窗口";
            this.metroButton_Close.UseSelectable = true;
            this.metroButton_Close.Click += new System.EventHandler(this.button_S_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 222);
            this.Controls.Add(this.metroButton_Close);
            this.Controls.Add(this.listBox_Task);
            this.Name = "Alert";
            this.Text = "逾期任务";
            this.Load += new System.EventHandler(this.Alert_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Task;
        private MetroFramework.Controls.MetroButton metroButton_Close;
    }
}