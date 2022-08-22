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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Code
            // 
            this.textBox_Code.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Code.Location = new System.Drawing.Point(284, 175);
            this.textBox_Code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(512, 36);
            this.textBox_Code.TabIndex = 1;
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("宋体", 13F);
            this.label_C.Location = new System.Drawing.Point(95, 184);
            this.label_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(175, 22);
            this.label_C.TabIndex = 2;
            this.label_C.Text = "产品密钥（&S）：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 20F);
            this.label1.Location = new System.Drawing.Point(425, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "激活软件";
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("宋体", 11F);
            this.button_Submit.Location = new System.Drawing.Point(805, 176);
            this.button_Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(100, 39);
            this.button_Submit.TabIndex = 4;
            this.button_Submit.Text = "激活";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // linkLabel_D1
            // 
            this.linkLabel_D1.AutoSize = true;
            this.linkLabel_D1.Font = new System.Drawing.Font("宋体", 11F);
            this.linkLabel_D1.Location = new System.Drawing.Point(447, 272);
            this.linkLabel_D1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_D1.Name = "linkLabel_D1";
            this.linkLabel_D1.Size = new System.Drawing.Size(123, 19);
            this.linkLabel_D1.TabIndex = 5;
            this.linkLabel_D1.TabStop = true;
            this.linkLabel_D1.Text = "获取产品密钥";
            this.linkLabel_D1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_D1_LinkClicked);
            // 
            // linkLabel_D2
            // 
            this.linkLabel_D2.AutoSize = true;
            this.linkLabel_D2.Font = new System.Drawing.Font("宋体", 11F);
            this.linkLabel_D2.Location = new System.Drawing.Point(484, 308);
            this.linkLabel_D2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_D2.Name = "linkLabel_D2";
            this.linkLabel_D2.Size = new System.Drawing.Size(47, 19);
            this.linkLabel_D2.TabIndex = 6;
            this.linkLabel_D2.TabStop = true;
            this.linkLabel_D2.Text = "退出";
            this.linkLabel_D2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_D2_LinkClicked);
            // 
            // Activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 346);
            this.Controls.Add(this.linkLabel_D2);
            this.Controls.Add(this.linkLabel_D1);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}