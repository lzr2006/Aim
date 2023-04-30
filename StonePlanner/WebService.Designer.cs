namespace StonePlanner
{
    partial class WebService
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
            this.linkLabel_GetPassword = new MetroFramework.Controls.MetroLink();
            this.linkLabel_Register = new MetroFramework.Controls.MetroLink();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Submit = new MetroFramework.Controls.MetroButton();
            this.textBox_M_Pwd = new MetroFramework.Controls.MetroTextBox();
            this.label_M_Pwd = new System.Windows.Forms.Label();
            this.textBox_M_Name = new MetroFramework.Controls.MetroTextBox();
            this.label_M_Name = new System.Windows.Forms.Label();
            this.label_M_Address = new System.Windows.Forms.Label();
            this.textBox_M_Address = new MetroFramework.Controls.MetroTextBox();
            this.label_M_Port = new System.Windows.Forms.Label();
            this.textBox_M_Port = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_GetPassword
            // 
            this.linkLabel_GetPassword.AutoSize = true;
            this.linkLabel_GetPassword.Location = new System.Drawing.Point(206, 203);
            this.linkLabel_GetPassword.Name = "linkLabel_GetPassword";
            this.linkLabel_GetPassword.Size = new System.Drawing.Size(63, 22);
            this.linkLabel_GetPassword.TabIndex = 26;
            this.linkLabel_GetPassword.Text = "找回密码";
            this.linkLabel_GetPassword.UseSelectable = true;
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.Location = new System.Drawing.Point(4, 203);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(77, 22);
            this.linkLabel_Register.TabIndex = 25;
            this.linkLabel_Register.Text = "注册新用户";
            this.linkLabel_Register.UseSelectable = true;
            this.linkLabel_Register.Click += new System.EventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 18;
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(-19, 225);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(311, 33);
            this.button_Submit.TabIndex = 24;
            this.button_Submit.Text = "登录";
            this.button_Submit.UseSelectable = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textBox_M_Pwd
            // 
            // 
            // 
            // 
            this.textBox_M_Pwd.CustomButton.Image = null;
            this.textBox_M_Pwd.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.textBox_M_Pwd.CustomButton.Name = "";
            this.textBox_M_Pwd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBox_M_Pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_M_Pwd.CustomButton.TabIndex = 1;
            this.textBox_M_Pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_M_Pwd.CustomButton.UseSelectable = true;
            this.textBox_M_Pwd.CustomButton.Visible = false;
            this.textBox_M_Pwd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox_M_Pwd.Lines = new string[0];
            this.textBox_M_Pwd.Location = new System.Drawing.Point(67, 103);
            this.textBox_M_Pwd.MaxLength = 32767;
            this.textBox_M_Pwd.Name = "textBox_M_Pwd";
            this.textBox_M_Pwd.PasswordChar = '\0';
            this.textBox_M_Pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_M_Pwd.SelectedText = "";
            this.textBox_M_Pwd.SelectionLength = 0;
            this.textBox_M_Pwd.SelectionStart = 0;
            this.textBox_M_Pwd.ShortcutsEnabled = true;
            this.textBox_M_Pwd.Size = new System.Drawing.Size(201, 25);
            this.textBox_M_Pwd.TabIndex = 23;
            this.textBox_M_Pwd.UseSelectable = true;
            this.textBox_M_Pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_M_Pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label_M_Pwd
            // 
            this.label_M_Pwd.AutoSize = true;
            this.label_M_Pwd.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_M_Pwd.Location = new System.Drawing.Point(4, 109);
            this.label_M_Pwd.Name = "label_M_Pwd";
            this.label_M_Pwd.Size = new System.Drawing.Size(68, 15);
            this.label_M_Pwd.TabIndex = 22;
            this.label_M_Pwd.Text = "密  码：";
            // 
            // textBox_M_Name
            // 
            // 
            // 
            // 
            this.textBox_M_Name.CustomButton.Image = null;
            this.textBox_M_Name.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.textBox_M_Name.CustomButton.Name = "";
            this.textBox_M_Name.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBox_M_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_M_Name.CustomButton.TabIndex = 1;
            this.textBox_M_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_M_Name.CustomButton.UseSelectable = true;
            this.textBox_M_Name.CustomButton.Visible = false;
            this.textBox_M_Name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox_M_Name.Lines = new string[0];
            this.textBox_M_Name.Location = new System.Drawing.Point(66, 69);
            this.textBox_M_Name.MaxLength = 32767;
            this.textBox_M_Name.Name = "textBox_M_Name";
            this.textBox_M_Name.PasswordChar = '\0';
            this.textBox_M_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_M_Name.SelectedText = "";
            this.textBox_M_Name.SelectionLength = 0;
            this.textBox_M_Name.SelectionStart = 0;
            this.textBox_M_Name.ShortcutsEnabled = true;
            this.textBox_M_Name.Size = new System.Drawing.Size(201, 25);
            this.textBox_M_Name.TabIndex = 21;
            this.textBox_M_Name.UseSelectable = true;
            this.textBox_M_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_M_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label_M_Name
            // 
            this.label_M_Name.AutoSize = true;
            this.label_M_Name.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_M_Name.Location = new System.Drawing.Point(4, 74);
            this.label_M_Name.Name = "label_M_Name";
            this.label_M_Name.Size = new System.Drawing.Size(67, 15);
            this.label_M_Name.TabIndex = 20;
            this.label_M_Name.Text = "用户名：";
            // 
            // label_M_Address
            // 
            this.label_M_Address.AutoSize = true;
            this.label_M_Address.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_M_Address.Location = new System.Drawing.Point(4, 142);
            this.label_M_Address.Name = "label_M_Address";
            this.label_M_Address.Size = new System.Drawing.Size(68, 15);
            this.label_M_Address.TabIndex = 27;
            this.label_M_Address.Text = "地  址：";
            // 
            // textBox_M_Address
            // 
            // 
            // 
            // 
            this.textBox_M_Address.CustomButton.Image = null;
            this.textBox_M_Address.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.textBox_M_Address.CustomButton.Name = "";
            this.textBox_M_Address.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBox_M_Address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_M_Address.CustomButton.TabIndex = 1;
            this.textBox_M_Address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_M_Address.CustomButton.UseSelectable = true;
            this.textBox_M_Address.CustomButton.Visible = false;
            this.textBox_M_Address.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox_M_Address.Lines = new string[0];
            this.textBox_M_Address.Location = new System.Drawing.Point(67, 138);
            this.textBox_M_Address.MaxLength = 32767;
            this.textBox_M_Address.Name = "textBox_M_Address";
            this.textBox_M_Address.PasswordChar = '\0';
            this.textBox_M_Address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_M_Address.SelectedText = "";
            this.textBox_M_Address.SelectionLength = 0;
            this.textBox_M_Address.SelectionStart = 0;
            this.textBox_M_Address.ShortcutsEnabled = true;
            this.textBox_M_Address.Size = new System.Drawing.Size(201, 25);
            this.textBox_M_Address.TabIndex = 28;
            this.textBox_M_Address.UseSelectable = true;
            this.textBox_M_Address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_M_Address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label_M_Port
            // 
            this.label_M_Port.AutoSize = true;
            this.label_M_Port.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_M_Port.Location = new System.Drawing.Point(4, 175);
            this.label_M_Port.Name = "label_M_Port";
            this.label_M_Port.Size = new System.Drawing.Size(68, 15);
            this.label_M_Port.TabIndex = 29;
            this.label_M_Port.Text = "端  口：";
            // 
            // textBox_M_Port
            // 
            // 
            // 
            // 
            this.textBox_M_Port.CustomButton.Image = null;
            this.textBox_M_Port.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.textBox_M_Port.CustomButton.Name = "";
            this.textBox_M_Port.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBox_M_Port.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_M_Port.CustomButton.TabIndex = 1;
            this.textBox_M_Port.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_M_Port.CustomButton.UseSelectable = true;
            this.textBox_M_Port.CustomButton.Visible = false;
            this.textBox_M_Port.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox_M_Port.Lines = new string[0];
            this.textBox_M_Port.Location = new System.Drawing.Point(67, 172);
            this.textBox_M_Port.MaxLength = 32767;
            this.textBox_M_Port.Name = "textBox_M_Port";
            this.textBox_M_Port.PasswordChar = '\0';
            this.textBox_M_Port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_M_Port.SelectedText = "";
            this.textBox_M_Port.SelectionLength = 0;
            this.textBox_M_Port.SelectionStart = 0;
            this.textBox_M_Port.ShortcutsEnabled = true;
            this.textBox_M_Port.Size = new System.Drawing.Size(201, 25);
            this.textBox_M_Port.TabIndex = 30;
            this.textBox_M_Port.UseSelectable = true;
            this.textBox_M_Port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_M_Port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // WebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 258);
            this.Controls.Add(this.textBox_M_Port);
            this.Controls.Add(this.label_M_Port);
            this.Controls.Add(this.textBox_M_Address);
            this.Controls.Add(this.label_M_Address);
            this.Controls.Add(this.linkLabel_GetPassword);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_M_Pwd);
            this.Controls.Add(this.label_M_Pwd);
            this.Controls.Add(this.textBox_M_Name);
            this.Controls.Add(this.label_M_Name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WebService";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "登录到网络服务器";
            this.Load += new System.EventHandler(this.WebService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLink linkLabel_GetPassword;
        private MetroFramework.Controls.MetroLink linkLabel_Register;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton button_Submit;
        MetroFramework.Controls.MetroTextBox textBox_M_Pwd;
        private System.Windows.Forms.Label label_M_Pwd;
        MetroFramework.Controls.MetroTextBox textBox_M_Name;
        private System.Windows.Forms.Label label_M_Name;
        private System.Windows.Forms.Label label_M_Address;
        MetroFramework.Controls.MetroTextBox textBox_M_Address;
        private System.Windows.Forms.Label label_M_Port;
        MetroFramework.Controls.MetroTextBox textBox_M_Port;
    }
}