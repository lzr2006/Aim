namespace StonePlanner
{
    partial class Recycle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.TaskTime,
            this.TaskStatus});
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(343, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "任务名称";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // TaskTime
            // 
            this.TaskTime.HeaderText = "时间";
            this.TaskTime.Name = "TaskTime";
            this.TaskTime.ReadOnly = true;
            // 
            // TaskStatus
            // 
            this.TaskStatus.HeaderText = "状态";
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.ReadOnly = true;
            // 
            // Recycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 163);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Recycle";
            this.Text = "任务回收站";
            this.Load += new System.EventHandler(this.Recycle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStatus;
    }
}