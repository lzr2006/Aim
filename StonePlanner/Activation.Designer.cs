namespace StonePlanner
{
    partial class Activation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.label_C = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.linkLabel_D1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_D2 = new System.Windows.Forms.LinkLabel();
            this.label_Tip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Code
            // 
            this.textBox_Code.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Code.Location = new System.Drawing.Point(213, 140);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(385, 30);
            this.textBox_Code.TabIndex = 1;
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("SimSun", 13F);
            this.label_C.Location = new System.Drawing.Point(71, 147);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(143, 18);
            this.label_C.TabIndex = 2;
            this.label_C.Text = "产品密钥（&S）：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimHei", 20F);
            this.label1.Location = new System.Drawing.Point(319, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "激活软件";
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("SimSun", 11F);
            this.button_Submit.Location = new System.Drawing.Point(604, 141);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 31);
            this.button_Submit.TabIndex = 4;
            this.button_Submit.Text = "激活";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // linkLabel_D1
            // 
            this.linkLabel_D1.AutoSize = true;
            this.linkLabel_D1.Font = new System.Drawing.Font("SimSun", 11F);
            this.linkLabel_D1.Location = new System.Drawing.Point(335, 225);
            this.linkLabel_D1.Name = "linkLabel_D1";
            this.linkLabel_D1.Size = new System.Drawing.Size(97, 15);
            this.linkLabel_D1.TabIndex = 5;
            this.linkLabel_D1.TabStop = true;
            this.linkLabel_D1.Text = "获取产品密钥";
            this.linkLabel_D1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_D1_LinkClicked);
            // 
            // linkLabel_D2
            // 
            this.linkLabel_D2.AutoSize = true;
            this.linkLabel_D2.Font = new System.Drawing.Font("SimSun", 11F);
            this.linkLabel_D2.Location = new System.Drawing.Point(363, 253);
            this.linkLabel_D2.Name = "linkLabel_D2";
            this.linkLabel_D2.Size = new System.Drawing.Size(37, 15);
            this.linkLabel_D2.TabIndex = 6;
            this.linkLabel_D2.TabStop = true;
            this.linkLabel_D2.Text = "退出";
            this.linkLabel_D2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_D2_LinkClicked);
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label_Tip.ForeColor = System.Drawing.Color.Red;
            this.label_Tip.Location = new System.Drawing.Point(291, 192);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(0, 14);
            this.label_Tip.TabIndex = 7;
            // 
            // Activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 282);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.linkLabel_D2);
            this.Controls.Add(this.linkLabel_D1);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Activation";
            this.Text = "Activation";
            this.Load += new System.EventHandler(this.Activation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.LinkLabel linkLabel_D1;
        private System.Windows.Forms.LinkLabel linkLabel_D2;
        private System.Windows.Forms.Label label_Tip;
    }
}