namespace StonePlanner
{
    partial class SchedulingCalendarDay
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Day = new System.Windows.Forms.Label();
            this.panel_Down = new System.Windows.Forms.Panel();
            this.label_D = new System.Windows.Forms.Label();
            this.panel_Down.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Day
            // 
            this.label_Day.AutoSize = true;
            this.label_Day.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Day.Location = new System.Drawing.Point(15, 9);
            this.label_Day.Name = "label_Day";
            this.label_Day.Size = new System.Drawing.Size(43, 29);
            this.label_Day.TabIndex = 0;
            this.label_Day.Text = "01";
            // 
            // panel_Down
            // 
            this.panel_Down.Controls.Add(this.label_D);
            this.panel_Down.Location = new System.Drawing.Point(3, 42);
            this.panel_Down.Name = "panel_Down";
            this.panel_Down.Size = new System.Drawing.Size(67, 18);
            this.panel_Down.TabIndex = 1;
            // 
            // label_D
            // 
            this.label_D.AutoSize = true;
            this.label_D.Location = new System.Drawing.Point(6, 2);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(45, 15);
            this.label_D.TabIndex = 0;
            this.label_D.Text = " 班次";
            // 
            // SchedulingCalendarDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Down);
            this.Controls.Add(this.label_Day);
            this.Name = "SchedulingCalendarDay";
            this.Size = new System.Drawing.Size(73, 66);
            this.Load += new System.EventHandler(this.SchedulingCalendarDay_Load);
            this.panel_Down.ResumeLayout(false);
            this.panel_Down.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Down;
        internal System.Windows.Forms.Label label_Day;
        internal System.Windows.Forms.Label label_D;
    }
}
