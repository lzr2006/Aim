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
            this.label_Top_1 = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Top_2 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_M_Pwd = new System.Windows.Forms.TextBox();
            this.label_M_Pwd = new System.Windows.Forms.Label();
            this.textBox_M_Name = new System.Windows.Forms.TextBox();
            this.label_M_Name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel_Register = new System.Windows.Forms.LinkLabel();
            this.linkLabel_GetPassword = new System.Windows.Forms.LinkLabel();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Top_1
            // 
            this.label_Top_1.AutoSize = true;
            this.label_Top_1.Font = new System.Drawing.Font("Cascadia Mono Light", 14F);
            this.label_Top_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Top_1.Location = new System.Drawing.Point(2, 6);
            this.label_Top_1.Name = "label_Top_1";
            this.label_Top_1.Size = new System.Drawing.Size(155, 25);
            this.label_Top_1.TabIndex = 1;
            this.label_Top_1.Text = "MethodBox·Aim";
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Top.Controls.Add(this.label_Top_2);
            this.panel_Top.Controls.Add(this.label_Top_1);
            this.panel_Top.Location = new System.Drawing.Point(-1, -1);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(293, 79);
            this.panel_Top.TabIndex = 8;
            // 
            // label_Top_2
            // 
            this.label_Top_2.AutoSize = true;
            this.label_Top_2.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Top_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Top_2.Location = new System.Drawing.Point(3, 47);
            this.label_Top_2.Name = "label_Top_2";
            this.label_Top_2.Size = new System.Drawing.Size(149, 19);
            this.label_Top_2.TabIndex = 2;
            this.label_Top_2.Text = "登录到本地账户";
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("宋体", 11F);
            this.button_Submit.Location = new System.Drawing.Point(-8, 172);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(311, 33);
            this.button_Submit.TabIndex = 15;
            this.button_Submit.Text = "登录";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textBox_M_Pwd
            // 
            this.textBox_M_Pwd.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Pwd.Location = new System.Drawing.Point(90, 120);
            this.textBox_M_Pwd.Name = "textBox_M_Pwd";
            this.textBox_M_Pwd.Size = new System.Drawing.Size(177, 25);
            this.textBox_M_Pwd.TabIndex = 12;
            // 
            // label_M_Pwd
            // 
            this.label_M_Pwd.AutoSize = true;
            this.label_M_Pwd.Font = new System.Drawing.Font("宋体", 11F);
            this.label_M_Pwd.Location = new System.Drawing.Point(3, 126);
            this.label_M_Pwd.Name = "label_M_Pwd";
            this.label_M_Pwd.Size = new System.Drawing.Size(92, 15);
            this.label_M_Pwd.TabIndex = 11;
            this.label_M_Pwd.Text = "密  码(&P)：";
            // 
            // textBox_M_Name
            // 
            this.textBox_M_Name.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Name.Location = new System.Drawing.Point(90, 85);
            this.textBox_M_Name.Name = "textBox_M_Name";
            this.textBox_M_Name.Size = new System.Drawing.Size(177, 25);
            this.textBox_M_Name.TabIndex = 10;
            // 
            // label_M_Name
            // 
            this.label_M_Name.AutoSize = true;
            this.label_M_Name.Font = new System.Drawing.Font("宋体", 11F);
            this.label_M_Name.Location = new System.Drawing.Point(3, 91);
            this.label_M_Name.Name = "label_M_Name";
            this.label_M_Name.Size = new System.Drawing.Size(91, 15);
            this.label_M_Name.TabIndex = 9;
            this.label_M_Name.Text = "用户名(&M)：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 3;
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.Font = new System.Drawing.Font("宋体", 10F);
            this.linkLabel_Register.Location = new System.Drawing.Point(4, 154);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(77, 14);
            this.linkLabel_Register.TabIndex = 16;
            this.linkLabel_Register.TabStop = true;
            this.linkLabel_Register.Text = "注册新用户";
            this.linkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // linkLabel_GetPassword
            // 
            this.linkLabel_GetPassword.AutoSize = true;
            this.linkLabel_GetPassword.Font = new System.Drawing.Font("宋体", 10F);
            this.linkLabel_GetPassword.Location = new System.Drawing.Point(205, 155);
            this.linkLabel_GetPassword.Name = "linkLabel_GetPassword";
            this.linkLabel_GetPassword.Size = new System.Drawing.Size(63, 14);
            this.linkLabel_GetPassword.TabIndex = 17;
            this.linkLabel_GetPassword.TabStop = true;
            this.linkLabel_GetPassword.Text = "找回密码";
            this.linkLabel_GetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GetPassword_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 201);
            this.Controls.Add(this.linkLabel_GetPassword);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_M_Pwd);
            this.Controls.Add(this.label_M_Pwd);
            this.Controls.Add(this.textBox_M_Name);
            this.Controls.Add(this.label_M_Name);
            this.Name = "Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Top_1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Top_2;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TextBox textBox_M_Pwd;
        private System.Windows.Forms.Label label_M_Pwd;
        private System.Windows.Forms.TextBox textBox_M_Name;
        private System.Windows.Forms.Label label_M_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel_Register;
        private System.Windows.Forms.LinkLabel linkLabel_GetPassword;
    }
}