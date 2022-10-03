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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Task = new System.Windows.Forms.ListBox();
            this.button_S = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "您好，系统监测到您目前有任务逾期未完成，是否需要完成？";
            // 
            // listBox_Task
            // 
            this.listBox_Task.Font = new System.Drawing.Font("宋体", 11F);
            this.listBox_Task.FormattingEnabled = true;
            this.listBox_Task.ItemHeight = 18;
            this.listBox_Task.Location = new System.Drawing.Point(12, 47);
            this.listBox_Task.Name = "listBox_Task";
            this.listBox_Task.Size = new System.Drawing.Size(516, 94);
            this.listBox_Task.TabIndex = 1;
            // 
            // button_S
            // 
            this.button_S.Font = new System.Drawing.Font("宋体", 10F);
            this.button_S.Location = new System.Drawing.Point(425, 160);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(103, 28);
            this.button_S.TabIndex = 2;
            this.button_S.Text = "Close";
            this.button_S.UseVisualStyleBackColor = true;
            this.button_S.Click += new System.EventHandler(this.button_S_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 200);
            this.Controls.Add(this.button_S);
            this.Controls.Add(this.listBox_Task);
            this.Controls.Add(this.label1);
            this.Name = "Alert";
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Alert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Task;
        private System.Windows.Forms.Button button_S;
    }
}