namespace StonePlanner
{
    partial class WeatherForecast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForecast));
            this.pictureBox_T_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_Split = new System.Windows.Forms.PictureBox();
            this.label_Capital = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.pictureBox_Wea = new System.Windows.Forms.PictureBox();
            this.label_WeStatus = new System.Windows.Forms.Label();
            this.panel_Split = new System.Windows.Forms.Panel();
            this.label_WeaDetails = new System.Windows.Forms.Label();
            this.label_Tem = new System.Windows.Forms.Label();
            this.label_Humidity = new System.Windows.Forms.Label();
            this.label_Visibility = new System.Windows.Forms.Label();
            this.label_Pressure = new System.Windows.Forms.Label();
            this.label_Winspeed = new System.Windows.Forms.Label();
            this.label_Air = new System.Windows.Forms.Label();
            this.label_AirLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Split)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_T_Exit
            // 
            this.pictureBox_T_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T_Exit.BackgroundImage")));
            this.pictureBox_T_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_T_Exit.Location = new System.Drawing.Point(358, 6);
            this.pictureBox_T_Exit.Name = "pictureBox_T_Exit";
            this.pictureBox_T_Exit.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_T_Exit.TabIndex = 10;
            this.pictureBox_T_Exit.TabStop = false;
            this.pictureBox_T_Exit.Click += new System.EventHandler(this.pictureBox_T_Exit_Click);
            // 
            // pictureBox_Split
            // 
            this.pictureBox_Split.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Split.BackgroundImage")));
            this.pictureBox_Split.Location = new System.Drawing.Point(-44, 36);
            this.pictureBox_Split.Name = "pictureBox_Split";
            this.pictureBox_Split.Size = new System.Drawing.Size(498, 5);
            this.pictureBox_Split.TabIndex = 9;
            this.pictureBox_Split.TabStop = false;
            // 
            // label_Capital
            // 
            this.label_Capital.AutoSize = true;
            this.label_Capital.Font = new System.Drawing.Font("SimHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Capital.Location = new System.Drawing.Point(10, 11);
            this.label_Capital.Name = "label_Capital";
            this.label_Capital.Size = new System.Drawing.Size(177, 20);
            this.label_Capital.TabIndex = 8;
            this.label_Capital.Text = "北京市·天气预报";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Courier New", 10F);
            this.label_Date.Location = new System.Drawing.Point(149, 49);
            this.label_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(144, 17);
            this.label_Date.TabIndex = 11;
            this.label_Date.Text = "1145年1月4日 周一";
            // 
            // pictureBox_Wea
            // 
            this.pictureBox_Wea.Location = new System.Drawing.Point(10, 44);
            this.pictureBox_Wea.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Wea.Name = "pictureBox_Wea";
            this.pictureBox_Wea.Size = new System.Drawing.Size(51, 53);
            this.pictureBox_Wea.TabIndex = 12;
            this.pictureBox_Wea.TabStop = false;
            // 
            // label_WeStatus
            // 
            this.label_WeStatus.AutoSize = true;
            this.label_WeStatus.Font = new System.Drawing.Font("SimHei", 25F, System.Drawing.FontStyle.Bold);
            this.label_WeStatus.Location = new System.Drawing.Point(15, 56);
            this.label_WeStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WeStatus.Name = "label_WeStatus";
            this.label_WeStatus.Size = new System.Drawing.Size(50, 34);
            this.label_WeStatus.TabIndex = 13;
            this.label_WeStatus.Text = "雪";
            // 
            // panel_Split
            // 
            this.panel_Split.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Split.BackgroundImage")));
            this.panel_Split.Location = new System.Drawing.Point(74, 39);
            this.panel_Split.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Split.Name = "panel_Split";
            this.panel_Split.Size = new System.Drawing.Size(4, 148);
            this.panel_Split.TabIndex = 14;
            // 
            // label_WeaDetails
            // 
            this.label_WeaDetails.AutoSize = true;
            this.label_WeaDetails.Font = new System.Drawing.Font("Courier New", 10F);
            this.label_WeaDetails.Location = new System.Drawing.Point(0, 107);
            this.label_WeaDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WeaDetails.Name = "label_WeaDetails";
            this.label_WeaDetails.Size = new System.Drawing.Size(72, 17);
            this.label_WeaDetails.TabIndex = 15;
            this.label_WeaDetails.Text = "多云转晴";
            // 
            // label_Tem
            // 
            this.label_Tem.AutoSize = true;
            this.label_Tem.Font = new System.Drawing.Font("Courier New", 10F);
            this.label_Tem.Location = new System.Drawing.Point(4, 128);
            this.label_Tem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Tem.Name = "label_Tem";
            this.label_Tem.Size = new System.Drawing.Size(68, 17);
            this.label_Tem.TabIndex = 16;
            this.label_Tem.Text = "22℃/27℃";
            // 
            // label_Humidity
            // 
            this.label_Humidity.AutoSize = true;
            this.label_Humidity.Font = new System.Drawing.Font("Courier New", 10F);
            this.label_Humidity.Location = new System.Drawing.Point(112, 79);
            this.label_Humidity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Humidity.Name = "label_Humidity";
            this.label_Humidity.Size = new System.Drawing.Size(80, 17);
            this.label_Humidity.TabIndex = 17;
            this.label_Humidity.Text = "湿度：11%";
            // 
            // label_Visibility
            // 
            this.label_Visibility.AutoSize = true;
            this.label_Visibility.Font = new System.Drawing.Font("Courier New", 10F);
            this.label_Visibility.Location = new System.Drawing.Point(247, 78);
            this.label_Visibility.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Visibility.Name = "label_Visibility";
            this.label_Visibility.Size = new System.Drawing.Size(104, 17);
            this.label_Visibility.TabIndex = 18;
            this.label_Visibility.Text = "能见度：45KM";
            // 
            // label_Pressure
            // 
            this.label_Pressure.AutoSize = true;
            this.label_Pressure.Font = new System.Drawing.Font("Courier New", 10F);
            this.label_Pressure.Location = new System.Drawing.Point(112, 100);
            this.label_Pressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Pressure.Name = "label_Pressure";
            this.label_Pressure.Size = new System.Drawing.Size(112, 17);
            this.label_Pressure.TabIndex = 19;
            this.label_Pressure.Text = "气压：1145Kpa";
            // 
            // label_Winspeed
            // 
            this.label_Winspeed.AutoSize = true;
            this.label_Winspeed.Font = new System.Drawing.Font("Courier New", 10F);
            this.label_Winspeed.Location = new System.Drawing.Point(247, 100);
            this.label_Winspeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Winspeed.Name = "label_Winspeed";
            this.label_Winspeed.Size = new System.Drawing.Size(112, 17);
            this.label_Winspeed.TabIndex = 20;
            this.label_Winspeed.Text = "风速：<14km/h";
            // 
            // label_Air
            // 
            this.label_Air.AutoSize = true;
            this.label_Air.Font = new System.Drawing.Font("Courier New", 10F);
            this.label_Air.Location = new System.Drawing.Point(112, 121);
            this.label_Air.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Air.Name = "label_Air";
            this.label_Air.Size = new System.Drawing.Size(88, 17);
            this.label_Air.TabIndex = 21;
            this.label_Air.Text = "空气质量：";
            // 
            // label_AirLevel
            // 
            this.label_AirLevel.AutoSize = true;
            this.label_AirLevel.Font = new System.Drawing.Font("Courier New", 10F);
            this.label_AirLevel.Location = new System.Drawing.Point(247, 121);
            this.label_AirLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AirLevel.Name = "label_AirLevel";
            this.label_AirLevel.Size = new System.Drawing.Size(56, 17);
            this.label_AirLevel.TabIndex = 22;
            this.label_AirLevel.Text = "级别：";
            // 
            // WeatherForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_AirLevel);
            this.Controls.Add(this.label_Air);
            this.Controls.Add(this.label_Winspeed);
            this.Controls.Add(this.label_Pressure);
            this.Controls.Add(this.label_Visibility);
            this.Controls.Add(this.label_Humidity);
            this.Controls.Add(this.label_Tem);
            this.Controls.Add(this.label_WeaDetails);
            this.Controls.Add(this.panel_Split);
            this.Controls.Add(this.label_WeStatus);
            this.Controls.Add(this.pictureBox_Wea);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.pictureBox_T_Exit);
            this.Controls.Add(this.pictureBox_Split);
            this.Controls.Add(this.label_Capital);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WeatherForecast";
            this.Size = new System.Drawing.Size(392, 155);
            this.Load += new System.EventHandler(this.WeatherForecast_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WeatherForecast_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Split)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_T_Exit;
        private System.Windows.Forms.PictureBox pictureBox_Split;
        private System.Windows.Forms.Label label_Capital;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.PictureBox pictureBox_Wea;
        private System.Windows.Forms.Label label_WeStatus;
        private System.Windows.Forms.Panel panel_Split;
        private System.Windows.Forms.Label label_WeaDetails;
        private System.Windows.Forms.Label label_Tem;
        private System.Windows.Forms.Label label_Humidity;
        private System.Windows.Forms.Label label_Visibility;
        private System.Windows.Forms.Label label_Pressure;
        private System.Windows.Forms.Label label_Winspeed;
        private System.Windows.Forms.Label label_Air;
        private System.Windows.Forms.Label label_AirLevel;
    }
}
