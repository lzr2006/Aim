﻿namespace StonePlanner
{
    partial class Function
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
            this.pictureBox_M = new System.Windows.Forms.PictureBox();
            this.label_M = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_M)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_M
            // 
            this.pictureBox_M.Location = new System.Drawing.Point(4, 9);
            this.pictureBox_M.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_M.Name = "pictureBox_M";
            this.pictureBox_M.Size = new System.Drawing.Size(33, 26);
            this.pictureBox_M.TabIndex = 0;
            this.pictureBox_M.TabStop = false;
            this.pictureBox_M.Click += new System.EventHandler(this.Function_Click);
            // 
            // label_M
            // 
            this.label_M.AutoSize = true;
            this.label_M.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_M.Location = new System.Drawing.Point(45, 12);
            this.label_M.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_M.Name = "label_M";
            this.label_M.Size = new System.Drawing.Size(49, 20);
            this.label_M.TabIndex = 1;
            this.label_M.Text = "新建";
            this.label_M.Click += new System.EventHandler(this.Function_Click);
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_M);
            this.Controls.Add(this.pictureBox_M);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Function";
            this.Size = new System.Drawing.Size(160, 42);
            this.Load += new System.EventHandler(this.Function_Load);
            this.Click += new System.EventHandler(this.Function_Click);
            this.MouseEnter += new System.EventHandler(this.Function_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Function_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_M)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_M;
        private System.Windows.Forms.Label label_M;
    }
}
