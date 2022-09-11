namespace StonePlanner.StartUp
{
    partial class Splitter
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
            this.panel_L = new System.Windows.Forms.Panel();
            this.label_Version = new System.Windows.Forms.Label();
            this.panel_R = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_L
            // 
            this.panel_L.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_L.Location = new System.Drawing.Point(3, 6);
            this.panel_L.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_L.Name = "panel_L";
            this.panel_L.Size = new System.Drawing.Size(128, 9);
            this.panel_L.TabIndex = 0;
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Version.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_Version.Location = new System.Drawing.Point(135, 3);
            this.label_Version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(87, 15);
            this.label_Version.TabIndex = 1;
            this.label_Version.Text = "Origin版本";
            // 
            // panel_R
            // 
            this.panel_R.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_R.Location = new System.Drawing.Point(224, 6);
            this.panel_R.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_R.Name = "panel_R";
            this.panel_R.Size = new System.Drawing.Size(269, 9);
            this.panel_R.TabIndex = 2;
            this.panel_R.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_R_Paint);
            // 
            // Splitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_R);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.panel_L);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Splitter";
            this.Size = new System.Drawing.Size(499, 21);
            this.Load += new System.EventHandler(this.Splitter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_L;
        private Label label_Version;
        private Panel panel_R;
    }
}
