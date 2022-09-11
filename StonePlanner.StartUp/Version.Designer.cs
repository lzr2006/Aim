namespace StonePlanner.StartUp
{
    partial class Version
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
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.label_Main = new System.Windows.Forms.Label();
            this.button_Download = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Location = new System.Drawing.Point(4, 3);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Icon.TabIndex = 0;
            this.pictureBox_Icon.TabStop = false;
            // 
            // label_Main
            // 
            this.label_Main.AutoSize = true;
            this.label_Main.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Main.Location = new System.Drawing.Point(54, 12);
            this.label_Main.Name = "label_Main";
            this.label_Main.Size = new System.Drawing.Size(205, 24);
            this.label_Main.TabIndex = 1;
            this.label_Main.Text = "Aim Epsilon 1.0";
            // 
            // button_Download
            // 
            this.button_Download.Font = new System.Drawing.Font("黑体", 11.4514F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Download.Location = new System.Drawing.Point(559, 5);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(75, 36);
            this.button_Download.TabIndex = 2;
            this.button_Download.Text = "下载";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // Version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.label_Main);
            this.Controls.Add(this.pictureBox_Icon);
            this.Name = "Version";
            this.Size = new System.Drawing.Size(642, 45);
            this.Load += new System.EventHandler(this.Version_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_Icon;
        private Label label_Main;
        private Button button_Download;
    }
}
