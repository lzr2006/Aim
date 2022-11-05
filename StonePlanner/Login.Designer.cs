namespace StonePlanner
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox_M_Pwd = new System.Windows.Forms.TextBox();
            this.textBox_M_Name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox_Bg = new System.Windows.Forms.PictureBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.linkLabel_Nll = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bg)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_M_Pwd
            // 
            this.textBox_M_Pwd.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Pwd.Location = new System.Drawing.Point(120, 150);
            this.textBox_M_Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_M_Pwd.Name = "textBox_M_Pwd";
            this.textBox_M_Pwd.Size = new System.Drawing.Size(235, 29);
            this.textBox_M_Pwd.TabIndex = 12;
            // 
            // textBox_M_Name
            // 
            this.textBox_M_Name.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Name.Location = new System.Drawing.Point(17, 99);
            this.textBox_M_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_M_Name.Name = "textBox_M_Name";
            this.textBox_M_Name.Size = new System.Drawing.Size(247, 29);
            this.textBox_M_Name.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 331);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(13, 12);
            this.dataGridView1.TabIndex = 3;
            // 
            // pictureBox_Bg
            // 
            this.pictureBox_Bg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Bg.BackgroundImage")));
            this.pictureBox_Bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Bg.Location = new System.Drawing.Point(-10, -30);
            this.pictureBox_Bg.Name = "pictureBox_Bg";
            this.pictureBox_Bg.Size = new System.Drawing.Size(345, 322);
            this.pictureBox_Bg.TabIndex = 18;
            this.pictureBox_Bg.TabStop = false;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.Transparent;
            this.label_Login.Font = new System.Drawing.Font("Cascadia Code SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label_Login.ForeColor = System.Drawing.Color.White;
            this.label_Login.Location = new System.Drawing.Point(89, 20);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(143, 35);
            this.label_Login.TabIndex = 19;
            this.label_Login.Text = "Login In";
            // 
            // linkLabel_Nll
            // 
            this.linkLabel_Nll.AutoSize = true;
            this.linkLabel_Nll.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_Nll.Location = new System.Drawing.Point(85, 257);
            this.linkLabel_Nll.Name = "linkLabel_Nll";
            this.linkLabel_Nll.Size = new System.Drawing.Size(143, 18);
            this.linkLabel_Nll.TabIndex = 20;
            this.linkLabel_Nll.TabStop = true;
            this.linkLabel_Nll.Text = "无需用户开始(&C)";
            this.linkLabel_Nll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Nll_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 278);
            this.Controls.Add(this.linkLabel_Nll);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_M_Pwd);
            this.Controls.Add(this.textBox_M_Name);
            this.Controls.Add(this.pictureBox_Bg);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_M_Pwd;
        private System.Windows.Forms.TextBox textBox_M_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox_Bg;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.LinkLabel linkLabel_Nll;
    }
}