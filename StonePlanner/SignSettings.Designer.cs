namespace StonePlanner
{
    partial class SignSettings
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
            this.components = new System.ComponentModel.Container();
            this.label_C = new System.Windows.Forms.Label();
            this.listBox_M = new System.Windows.Forms.ListBox();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label_R_1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.timer_Get = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_C.Location = new System.Drawing.Point(9, 69);
            this.label_C.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(262, 15);
            this.label_C.TabIndex = 0;
            this.label_C.Text = "如遇到信号堵塞，可以使用该工具清除";
            // 
            // listBox_M
            // 
            this.listBox_M.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_M.FormattingEnabled = true;
            this.listBox_M.ItemHeight = 17;
            this.listBox_M.Location = new System.Drawing.Point(14, 89);
            this.listBox_M.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_M.Name = "listBox_M";
            this.listBox_M.Size = new System.Drawing.Size(429, 157);
            this.listBox_M.TabIndex = 1;
            // 
            // textBox_Input
            // 
            this.textBox_Input.Font = new System.Drawing.Font("Courier New", 10F);
            this.textBox_Input.Location = new System.Drawing.Point(449, 111);
            this.textBox_Input.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(103, 23);
            this.textBox_Input.TabIndex = 2;
            // 
            // label_R_1
            // 
            this.label_R_1.AutoSize = true;
            this.label_R_1.Font = new System.Drawing.Font("SimSun", 10F);
            this.label_R_1.Location = new System.Drawing.Point(447, 93);
            this.label_R_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_R_1.Name = "label_R_1";
            this.label_R_1.Size = new System.Drawing.Size(63, 14);
            this.label_R_1.TabIndex = 3;
            this.label_R_1.Text = "添加信号";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("SimSun", 10F);
            this.button_Add.Location = new System.Drawing.Point(449, 137);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(102, 26);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "添加信号";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Font = new System.Drawing.Font("SimSun", 10F);
            this.button_Remove.Location = new System.Drawing.Point(449, 180);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(102, 26);
            this.button_Remove.TabIndex = 5;
            this.button_Remove.Text = "移除首项";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("SimSun", 10F);
            this.button_Clear.Location = new System.Drawing.Point(449, 221);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(102, 26);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "清空信号";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // timer_Get
            // 
            this.timer_Get.Enabled = true;
            this.timer_Get.Interval = 1000;
            this.timer_Get.Tick += new System.EventHandler(this.timer_Get_Tick);
            // 
            // SignSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 260);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_R_1);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.listBox_M);
            this.Controls.Add(this.label_C);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignSettings";
            this.Text = "信号管理（标准版）";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.ListBox listBox_M;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label_R_1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Timer timer_Get;
    }
}