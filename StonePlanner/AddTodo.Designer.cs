namespace StonePlanner
{
    partial class AddTodo
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
            this.label_T = new System.Windows.Forms.Label();
            this.label_TodoName = new System.Windows.Forms.Label();
            this.textBox_Capital = new System.Windows.Forms.TextBox();
            this.label_Numbered = new System.Windows.Forms.Label();
            this.textBox_Numbered = new System.Windows.Forms.TextBox();
            this.button_New = new System.Windows.Forms.Button();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Top.Controls.Add(this.label_T);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(236, 30);
            this.panel_Top.TabIndex = 1;
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_T.Location = new System.Drawing.Point(50, 6);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(123, 19);
            this.label_T.TabIndex = 2;
            this.label_T.Text = "新建一个待办";
            // 
            // label_TodoName
            // 
            this.label_TodoName.AutoSize = true;
            this.label_TodoName.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_TodoName.Location = new System.Drawing.Point(10, 42);
            this.label_TodoName.Name = "label_TodoName";
            this.label_TodoName.Size = new System.Drawing.Size(84, 15);
            this.label_TodoName.TabIndex = 2;
            this.label_TodoName.Text = "标 题(&T)：";
            // 
            // textBox_Capital
            // 
            this.textBox_Capital.Location = new System.Drawing.Point(88, 39);
            this.textBox_Capital.Name = "textBox_Capital";
            this.textBox_Capital.Size = new System.Drawing.Size(135, 21);
            this.textBox_Capital.TabIndex = 1;
            // 
            // label_Numbered
            // 
            this.label_Numbered.AutoSize = true;
            this.label_Numbered.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_Numbered.Location = new System.Drawing.Point(10, 86);
            this.label_Numbered.Name = "label_Numbered";
            this.label_Numbered.Size = new System.Drawing.Size(84, 15);
            this.label_Numbered.TabIndex = 4;
            this.label_Numbered.Text = "编 号(&N)：";
            // 
            // textBox_Numbered
            // 
            this.textBox_Numbered.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Numbered.Location = new System.Drawing.Point(88, 84);
            this.textBox_Numbered.Name = "textBox_Numbered";
            this.textBox_Numbered.Size = new System.Drawing.Size(135, 21);
            this.textBox_Numbered.TabIndex = 3;
            this.textBox_Numbered.Text = "MANIS自动分配编号";
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(13, 108);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(210, 23);
            this.button_New.TabIndex = 4;
            this.button_New.Text = "新建待办(&D)";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // textBox_Time
            // 
            this.textBox_Time.Location = new System.Drawing.Point(88, 61);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(135, 21);
            this.textBox_Time.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 11F);
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "时 间(&S)：";
            // 
            // AddTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 137);
            this.Controls.Add(this.textBox_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.textBox_Numbered);
            this.Controls.Add(this.label_Numbered);
            this.Controls.Add(this.textBox_Capital);
            this.Controls.Add(this.label_TodoName);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTodo";
            this.Text = "AddTodo";
            this.Load += new System.EventHandler(this.AddTodo_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_TodoName;
        private System.Windows.Forms.TextBox textBox_Capital;
        private System.Windows.Forms.Label label_Numbered;
        private System.Windows.Forms.TextBox textBox_Numbered;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.Label label1;
    }
}