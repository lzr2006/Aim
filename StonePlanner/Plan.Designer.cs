namespace StonePlanner
{
    partial class Plan
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
            this.panel_Status = new System.Windows.Forms.Panel();
            this.label_TaskDes = new System.Windows.Forms.Label();
            this.button_Finish = new System.Windows.Forms.Button();
            this.label_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel_Status
            // 
            this.panel_Status.BackColor = System.Drawing.Color.LightGray;
            this.panel_Status.Location = new System.Drawing.Point(10, 7);
            this.panel_Status.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(20, 21);
            this.panel_Status.TabIndex = 0;
            this.panel_Status.Click += new System.EventHandler(this.panel_Status_Click);
            // 
            // label_TaskDes
            // 
            this.label_TaskDes.AutoSize = true;
            this.label_TaskDes.Font = new System.Drawing.Font("宋体", 11F);
            this.label_TaskDes.Location = new System.Drawing.Point(38, 10);
            this.label_TaskDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TaskDes.Name = "label_TaskDes";
            this.label_TaskDes.Size = new System.Drawing.Size(97, 15);
            this.label_TaskDes.TabIndex = 1;
            this.label_TaskDes.Text = "这是一个任务";
            this.label_TaskDes.Click += new System.EventHandler(this.label_TaskDes_Click_1);
            // 
            // button_Finish
            // 
            this.button_Finish.Location = new System.Drawing.Point(183, 3);
            this.button_Finish.Name = "button_Finish";
            this.button_Finish.Size = new System.Drawing.Size(52, 30);
            this.button_Finish.TabIndex = 2;
            this.button_Finish.Text = "完成";
            this.button_Finish.UseVisualStyleBackColor = true;
            this.button_Finish.Click += new System.EventHandler(this.button_Finish_Click);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(141, 10);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(15, 15);
            this.label_Time.TabIndex = 3;
            this.label_Time.Text = "0";
            this.label_Time.Click += new System.EventHandler(this.label_TaskDes_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.button_Finish);
            this.Controls.Add(this.label_TaskDes);
            this.Controls.Add(this.panel_Status);
            this.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Plan";
            this.Size = new System.Drawing.Size(238, 36);
            this.Load += new System.EventHandler(this.Plan_Load);
            this.Click += new System.EventHandler(this.label_TaskDes_Click_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Status;
        private System.Windows.Forms.Label label_TaskDes;
        private System.Windows.Forms.Button button_Finish;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Timer timer1;
    }
}
