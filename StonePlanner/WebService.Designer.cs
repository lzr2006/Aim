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
            this.label_Top_1 = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Top_2 = new System.Windows.Forms.Label();
            this.linkLabel_GetPassword = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Register = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_M_Pwd = new System.Windows.Forms.TextBox();
            this.label_M_Pwd = new System.Windows.Forms.Label();
            this.textBox_M_Name = new System.Windows.Forms.TextBox();
            this.label_M_Name = new System.Windows.Forms.Label();
            this.label_M_Address = new System.Windows.Forms.Label();
            this.textBox_M_Address = new System.Windows.Forms.TextBox();
            this.label_M_Port = new System.Windows.Forms.Label();
            this.textBox_M_Port = new System.Windows.Forms.TextBox();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Top_1
            // 
            this.label_Top_1.AutoSize = true;
            this.label_Top_1.Font = new System.Drawing.Font("Cascadia Mono Light", 14F);
            this.label_Top_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Top_1.Location = new System.Drawing.Point(3, 8);
            this.label_Top_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Top_1.Name = "label_Top_1";
            this.label_Top_1.Size = new System.Drawing.Size(294, 32);
            this.label_Top_1.TabIndex = 1;
            this.label_Top_1.Text = "MethodBox·AimPlanner";
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Top.Controls.Add(this.label_Top_2);
            this.panel_Top.Controls.Add(this.label_Top_1);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(391, 99);
            this.panel_Top.TabIndex = 19;
            // 
            // label_Top_2
            // 
            this.label_Top_2.AutoSize = true;
            this.label_Top_2.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Top_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Top_2.Location = new System.Drawing.Point(4, 59);
            this.label_Top_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Top_2.Name = "label_Top_2";
            this.label_Top_2.Size = new System.Drawing.Size(202, 24);
            this.label_Top_2.TabIndex = 2;
            this.label_Top_2.Text = "登录到网络服务器";
            // 
            // linkLabel_GetPassword
            // 
            this.linkLabel_GetPassword.AutoSize = true;
            this.linkLabel_GetPassword.Font = new System.Drawing.Font("宋体", 10F);
            this.linkLabel_GetPassword.Location = new System.Drawing.Point(274, 278);
            this.linkLabel_GetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_GetPassword.Name = "linkLabel_GetPassword";
            this.linkLabel_GetPassword.Size = new System.Drawing.Size(76, 17);
            this.linkLabel_GetPassword.TabIndex = 26;
            this.linkLabel_GetPassword.TabStop = true;
            this.linkLabel_GetPassword.Text = "找回密码";
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.Font = new System.Drawing.Font("宋体", 10F);
            this.linkLabel_Register.Location = new System.Drawing.Point(6, 276);
            this.linkLabel_Register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(93, 17);
            this.linkLabel_Register.TabIndex = 25;
            this.linkLabel_Register.TabStop = true;
            this.linkLabel_Register.Text = "注册新用户";
            this.linkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 332);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(13, 12);
            this.dataGridView1.TabIndex = 18;
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("宋体", 11F);
            this.button_Submit.Location = new System.Drawing.Point(-25, 299);
            this.button_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(415, 41);
            this.button_Submit.TabIndex = 24;
            this.button_Submit.Text = "登录";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textBox_M_Pwd
            // 
            this.textBox_M_Pwd.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Pwd.Location = new System.Drawing.Point(121, 151);
            this.textBox_M_Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_M_Pwd.Name = "textBox_M_Pwd";
            this.textBox_M_Pwd.Size = new System.Drawing.Size(235, 29);
            this.textBox_M_Pwd.TabIndex = 23;
            // 
            // label_M_Pwd
            // 
            this.label_M_Pwd.AutoSize = true;
            this.label_M_Pwd.Font = new System.Drawing.Font("宋体", 11F);
            this.label_M_Pwd.Location = new System.Drawing.Point(5, 159);
            this.label_M_Pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_M_Pwd.Name = "label_M_Pwd";
            this.label_M_Pwd.Size = new System.Drawing.Size(116, 19);
            this.label_M_Pwd.TabIndex = 22;
            this.label_M_Pwd.Text = "密  码(&P)：";
            // 
            // textBox_M_Name
            // 
            this.textBox_M_Name.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Name.Location = new System.Drawing.Point(120, 109);
            this.textBox_M_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_M_Name.Name = "textBox_M_Name";
            this.textBox_M_Name.Size = new System.Drawing.Size(235, 29);
            this.textBox_M_Name.TabIndex = 21;
            // 
            // label_M_Name
            // 
            this.label_M_Name.AutoSize = true;
            this.label_M_Name.Font = new System.Drawing.Font("宋体", 11F);
            this.label_M_Name.Location = new System.Drawing.Point(5, 115);
            this.label_M_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_M_Name.Name = "label_M_Name";
            this.label_M_Name.Size = new System.Drawing.Size(115, 19);
            this.label_M_Name.TabIndex = 20;
            this.label_M_Name.Text = "用户名(&M)：";
            // 
            // label_M_Address
            // 
            this.label_M_Address.AutoSize = true;
            this.label_M_Address.Font = new System.Drawing.Font("宋体", 11F);
            this.label_M_Address.Location = new System.Drawing.Point(5, 200);
            this.label_M_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_M_Address.Name = "label_M_Address";
            this.label_M_Address.Size = new System.Drawing.Size(116, 19);
            this.label_M_Address.TabIndex = 27;
            this.label_M_Address.Text = "地  址(&A)：";
            // 
            // textBox_M_Address
            // 
            this.textBox_M_Address.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Address.Location = new System.Drawing.Point(121, 195);
            this.textBox_M_Address.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_M_Address.Name = "textBox_M_Address";
            this.textBox_M_Address.Size = new System.Drawing.Size(235, 29);
            this.textBox_M_Address.TabIndex = 28;
            // 
            // label_M_Port
            // 
            this.label_M_Port.AutoSize = true;
            this.label_M_Port.Font = new System.Drawing.Font("宋体", 11F);
            this.label_M_Port.Location = new System.Drawing.Point(5, 241);
            this.label_M_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_M_Port.Name = "label_M_Port";
            this.label_M_Port.Size = new System.Drawing.Size(116, 19);
            this.label_M_Port.TabIndex = 29;
            this.label_M_Port.Text = "端  口(&T)：";
            // 
            // textBox_M_Port
            // 
            this.textBox_M_Port.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Port.Location = new System.Drawing.Point(121, 238);
            this.textBox_M_Port.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_M_Port.Name = "textBox_M_Port";
            this.textBox_M_Port.Size = new System.Drawing.Size(235, 29);
            this.textBox_M_Port.TabIndex = 30;
            // 
            // WebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 333);
            this.Controls.Add(this.textBox_M_Port);
            this.Controls.Add(this.label_M_Port);
            this.Controls.Add(this.textBox_M_Address);
            this.Controls.Add(this.label_M_Address);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.linkLabel_GetPassword);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_M_Pwd);
            this.Controls.Add(this.label_M_Pwd);
            this.Controls.Add(this.textBox_M_Name);
            this.Controls.Add(this.label_M_Name);
            this.Name = "WebService";
            this.Text = "登录到网络服务器";
            this.Load += new System.EventHandler(this.WebService_Load);
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
        private System.Windows.Forms.LinkLabel linkLabel_GetPassword;
        private System.Windows.Forms.LinkLabel linkLabel_Register;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TextBox textBox_M_Pwd;
        private System.Windows.Forms.Label label_M_Pwd;
        private System.Windows.Forms.TextBox textBox_M_Name;
        private System.Windows.Forms.Label label_M_Name;
        private System.Windows.Forms.Label label_M_Address;
        private System.Windows.Forms.TextBox textBox_M_Address;
        private System.Windows.Forms.Label label_M_Port;
        private System.Windows.Forms.TextBox textBox_M_Port;
    }
}