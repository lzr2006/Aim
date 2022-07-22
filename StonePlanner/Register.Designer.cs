namespace StonePlanner
{
    partial class Register
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
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Top_2 = new System.Windows.Forms.Label();
            this.label_Top_1 = new System.Windows.Forms.Label();
            this.label_M_Name = new System.Windows.Forms.Label();
            this.textBox_M_Name = new System.Windows.Forms.TextBox();
            this.textBox_M_Pwd = new System.Windows.Forms.TextBox();
            this.label_M_Pwd = new System.Windows.Forms.Label();
            this.label_M_Type = new System.Windows.Forms.Label();
            this.comboBox_M_Type = new System.Windows.Forms.ComboBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Top.Controls.Add(this.label_Top_2);
            this.panel_Top.Controls.Add(this.label_Top_1);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(293, 79);
            this.panel_Top.TabIndex = 0;
            // 
            // label_Top_2
            // 
            this.label_Top_2.AutoSize = true;
            this.label_Top_2.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Top_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Top_2.Location = new System.Drawing.Point(3, 47);
            this.label_Top_2.Name = "label_Top_2";
            this.label_Top_2.Size = new System.Drawing.Size(129, 19);
            this.label_Top_2.TabIndex = 2;
            this.label_Top_2.Text = "注册本地帐户";
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
            // label_M_Name
            // 
            this.label_M_Name.AutoSize = true;
            this.label_M_Name.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_M_Name.Location = new System.Drawing.Point(4, 92);
            this.label_M_Name.Name = "label_M_Name";
            this.label_M_Name.Size = new System.Drawing.Size(91, 15);
            this.label_M_Name.TabIndex = 1;
            this.label_M_Name.Text = "用户名(&M)：";
            // 
            // textBox_M_Name
            // 
            this.textBox_M_Name.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Name.Location = new System.Drawing.Point(91, 86);
            this.textBox_M_Name.Name = "textBox_M_Name";
            this.textBox_M_Name.Size = new System.Drawing.Size(177, 25);
            this.textBox_M_Name.TabIndex = 2;
            // 
            // textBox_M_Pwd
            // 
            this.textBox_M_Pwd.Font = new System.Drawing.Font("Cascadia Code Light", 11F);
            this.textBox_M_Pwd.Location = new System.Drawing.Point(91, 121);
            this.textBox_M_Pwd.Name = "textBox_M_Pwd";
            this.textBox_M_Pwd.Size = new System.Drawing.Size(177, 25);
            this.textBox_M_Pwd.TabIndex = 4;
            // 
            // label_M_Pwd
            // 
            this.label_M_Pwd.AutoSize = true;
            this.label_M_Pwd.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_M_Pwd.Location = new System.Drawing.Point(4, 127);
            this.label_M_Pwd.Name = "label_M_Pwd";
            this.label_M_Pwd.Size = new System.Drawing.Size(92, 15);
            this.label_M_Pwd.TabIndex = 3;
            this.label_M_Pwd.Text = "密  码(&P)：";
            // 
            // label_M_Type
            // 
            this.label_M_Type.AutoSize = true;
            this.label_M_Type.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_M_Type.Location = new System.Drawing.Point(4, 162);
            this.label_M_Type.Name = "label_M_Type";
            this.label_M_Type.Size = new System.Drawing.Size(92, 15);
            this.label_M_Type.TabIndex = 5;
            this.label_M_Type.Text = "类  型(&T)：";
            // 
            // comboBox_M_Type
            // 
            this.comboBox_M_Type.Font = new System.Drawing.Font("Cascadia Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_M_Type.FormattingEnabled = true;
            this.comboBox_M_Type.Items.AddRange(new object[] {
            "Standard",
            "Administrator"});
            this.comboBox_M_Type.Location = new System.Drawing.Point(91, 156);
            this.comboBox_M_Type.Name = "comboBox_M_Type";
            this.comboBox_M_Type.Size = new System.Drawing.Size(177, 28);
            this.comboBox_M_Type.TabIndex = 6;
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("SimSun", 11F);
            this.button_Submit.Location = new System.Drawing.Point(-7, 193);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(311, 33);
            this.button_Submit.TabIndex = 7;
            this.button_Submit.Text = "注册";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 223);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.comboBox_M_Type);
            this.Controls.Add(this.label_M_Type);
            this.Controls.Add(this.textBox_M_Pwd);
            this.Controls.Add(this.label_M_Pwd);
            this.Controls.Add(this.textBox_M_Name);
            this.Controls.Add(this.label_M_Name);
            this.Controls.Add(this.panel_Top);
            this.Name = "Register";
            this.Text = "注册账户（OOBE）";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Top_2;
        private System.Windows.Forms.Label label_Top_1;
        private System.Windows.Forms.Label label_M_Name;
        private System.Windows.Forms.TextBox textBox_M_Name;
        private System.Windows.Forms.TextBox textBox_M_Pwd;
        private System.Windows.Forms.Label label_M_Pwd;
        private System.Windows.Forms.Label label_M_Type;
        private System.Windows.Forms.ComboBox comboBox_M_Type;
        private System.Windows.Forms.Button button_Submit;
    }
}