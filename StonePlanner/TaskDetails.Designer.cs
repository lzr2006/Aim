namespace StonePlanner
{
    partial class TaskDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetails));
            this.label_Capital = new System.Windows.Forms.Label();
            this.pictureBox_Split = new System.Windows.Forms.PictureBox();
            this.label_Intro = new System.Windows.Forms.Label();
            this.label_StatusC = new System.Windows.Forms.Label();
            this.label_StatusR = new System.Windows.Forms.Label();
            this.label_TimeC = new System.Windows.Forms.Label();
            this.label_TimeR = new System.Windows.Forms.Label();
            this.pictureBox_T_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Split)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Capital
            // 
            this.label_Capital.AutoSize = true;
            this.label_Capital.Font = new System.Drawing.Font("SimHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Capital.Location = new System.Drawing.Point(10, 11);
            this.label_Capital.Name = "label_Capital";
            this.label_Capital.Size = new System.Drawing.Size(93, 20);
            this.label_Capital.TabIndex = 0;
            this.label_Capital.Text = "任务标题";
            // 
            // pictureBox_Split
            // 
            this.pictureBox_Split.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Split.BackgroundImage")));
            this.pictureBox_Split.Location = new System.Drawing.Point(-45, 36);
            this.pictureBox_Split.Name = "pictureBox_Split";
            this.pictureBox_Split.Size = new System.Drawing.Size(498, 5);
            this.pictureBox_Split.TabIndex = 1;
            this.pictureBox_Split.TabStop = false;
            // 
            // label_Intro
            // 
            this.label_Intro.AutoSize = true;
            this.label_Intro.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Intro.Location = new System.Drawing.Point(11, 49);
            this.label_Intro.Name = "label_Intro";
            this.label_Intro.Size = new System.Drawing.Size(367, 60);
            this.label_Intro.TabIndex = 2;
            this.label_Intro.Text = "任务简介任务简介任务简介任务简介任务简介任务简介\r\n任务简介任务简介任务简介任务简介任务简介任务简介\r\n任务简介任务简介任务简介任务简介任务简介任务简介\r\n任务简" +
    "介任务简介任务简介任务简介任务简介任务简介";
            // 
            // label_StatusC
            // 
            this.label_StatusC.AutoSize = true;
            this.label_StatusC.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_StatusC.Location = new System.Drawing.Point(11, 120);
            this.label_StatusC.Name = "label_StatusC";
            this.label_StatusC.Size = new System.Drawing.Size(82, 15);
            this.label_StatusC.TabIndex = 3;
            this.label_StatusC.Text = "任务状态：";
            // 
            // label_StatusR
            // 
            this.label_StatusR.AutoSize = true;
            this.label_StatusR.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_StatusR.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_StatusR.Location = new System.Drawing.Point(99, 120);
            this.label_StatusR.Name = "label_StatusR";
            this.label_StatusR.Size = new System.Drawing.Size(52, 15);
            this.label_StatusR.TabIndex = 4;
            this.label_StatusR.Text = "正在做";
            // 
            // label_TimeC
            // 
            this.label_TimeC.AutoSize = true;
            this.label_TimeC.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_TimeC.Location = new System.Drawing.Point(11, 138);
            this.label_TimeC.Name = "label_TimeC";
            this.label_TimeC.Size = new System.Drawing.Size(82, 15);
            this.label_TimeC.TabIndex = 5;
            this.label_TimeC.Text = "剩余时间：";
            // 
            // label_TimeR
            // 
            this.label_TimeR.AutoSize = true;
            this.label_TimeR.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_TimeR.ForeColor = System.Drawing.Color.Black;
            this.label_TimeR.Location = new System.Drawing.Point(100, 138);
            this.label_TimeR.Name = "label_TimeR";
            this.label_TimeR.Size = new System.Drawing.Size(23, 15);
            this.label_TimeR.TabIndex = 6;
            this.label_TimeR.Text = "0s";
            // 
            // pictureBox_T_Exit
            // 
            this.pictureBox_T_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T_Exit.BackgroundImage")));
            this.pictureBox_T_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_T_Exit.Location = new System.Drawing.Point(359, 8);
            this.pictureBox_T_Exit.Name = "pictureBox_T_Exit";
            this.pictureBox_T_Exit.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_T_Exit.TabIndex = 7;
            this.pictureBox_T_Exit.TabStop = false;
            this.pictureBox_T_Exit.Click += new System.EventHandler(this.pictureBox_T_Exit_Click);
            // 
            // TaskDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBox_T_Exit);
            this.Controls.Add(this.label_TimeR);
            this.Controls.Add(this.label_TimeC);
            this.Controls.Add(this.label_StatusR);
            this.Controls.Add(this.label_StatusC);
            this.Controls.Add(this.label_Intro);
            this.Controls.Add(this.pictureBox_Split);
            this.Controls.Add(this.label_Capital);
            this.Name = "TaskDetails";
            this.Size = new System.Drawing.Size(392, 161);
            this.Load += new System.EventHandler(this.TaskDetails_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TaskDetails_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Split)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Capital;
        private System.Windows.Forms.PictureBox pictureBox_Split;
        private System.Windows.Forms.Label label_Intro;
        private System.Windows.Forms.Label label_StatusC;
        private System.Windows.Forms.Label label_StatusR;
        private System.Windows.Forms.Label label_TimeC;
        private System.Windows.Forms.Label label_TimeR;
        private System.Windows.Forms.PictureBox pictureBox_T_Exit;
    }
}
