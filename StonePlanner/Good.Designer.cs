namespace StonePlanner
{
    partial class Good
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
            this.pbox_GoodPicture = new System.Windows.Forms.PictureBox();
            this.label_GoodName = new System.Windows.Forms.Label();
            this.label_GoodIntro = new System.Windows.Forms.Label();
            this.btn_GoodPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_GoodPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_GoodPicture
            // 
            this.pbox_GoodPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox_GoodPicture.Location = new System.Drawing.Point(11, 19);
            this.pbox_GoodPicture.Name = "pbox_GoodPicture";
            this.pbox_GoodPicture.Size = new System.Drawing.Size(100, 89);
            this.pbox_GoodPicture.TabIndex = 0;
            this.pbox_GoodPicture.TabStop = false;
            // 
            // label_GoodName
            // 
            this.label_GoodName.AutoSize = true;
            this.label_GoodName.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_GoodName.Location = new System.Drawing.Point(164, 19);
            this.label_GoodName.Name = "label_GoodName";
            this.label_GoodName.Size = new System.Drawing.Size(72, 19);
            this.label_GoodName.TabIndex = 1;
            this.label_GoodName.Text = "商品名";
            // 
            // label_GoodIntro
            // 
            this.label_GoodIntro.AutoSize = true;
            this.label_GoodIntro.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_GoodIntro.Location = new System.Drawing.Point(115, 43);
            this.label_GoodIntro.Name = "label_GoodIntro";
            this.label_GoodIntro.Size = new System.Drawing.Size(183, 64);
            this.label_GoodIntro.TabIndex = 2;
            this.label_GoodIntro.Text = "我是简介我是简介我是简\r\n介我是\r\n简介我是简介我是简介我\r\n是简介我是简介我";
            // 
            // btn_GoodPrice
            // 
            this.btn_GoodPrice.Location = new System.Drawing.Point(8, 116);
            this.btn_GoodPrice.Name = "btn_GoodPrice";
            this.btn_GoodPrice.Size = new System.Drawing.Size(285, 27);
            this.btn_GoodPrice.TabIndex = 3;
            this.btn_GoodPrice.Text = "购买（&P 50.0）";
            this.btn_GoodPrice.UseVisualStyleBackColor = true;
            this.btn_GoodPrice.Click += new System.EventHandler(this.btn_GoodPrice_Click);
            // 
            // Good
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_GoodPrice);
            this.Controls.Add(this.label_GoodIntro);
            this.Controls.Add(this.label_GoodName);
            this.Controls.Add(this.pbox_GoodPicture);
            this.Name = "Good";
            this.Size = new System.Drawing.Size(300, 150);
            this.Load += new System.EventHandler(this.Good_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_GoodPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_GoodPicture;
        private System.Windows.Forms.Label label_GoodName;
        private System.Windows.Forms.Label label_GoodIntro;
        private System.Windows.Forms.Button btn_GoodPrice;
    }
}
