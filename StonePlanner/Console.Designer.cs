namespace StonePlanner
{
    partial class Console
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
            this.panel_Output = new System.Windows.Forms.Panel();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_Input = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_Pars = new System.Windows.Forms.TextBox();
            this.panel_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Output
            // 
            this.panel_Output.Controls.Add(this.richTextBox_Output);
            this.panel_Output.Location = new System.Drawing.Point(11, 30);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Size = new System.Drawing.Size(355, 191);
            this.panel_Output.TabIndex = 0;
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox_Output.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Output.ForeColor = System.Drawing.Color.Green;
            this.richTextBox_Output.Location = new System.Drawing.Point(4, 3);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.Size = new System.Drawing.Size(348, 185);
            this.richTextBox_Output.TabIndex = 1;
            this.richTextBox_Output.Text = "Console@Main>已启动";
            this.richTextBox_Output.TextChanged += new System.EventHandler(this.richTextBox_Output_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.4F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "输出（&Output）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.4F);
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "输入（&Input）：";
            // 
            // richTextBox_Input
            // 
            this.richTextBox_Input.Font = new System.Drawing.Font("Cascadia Mono", 10.5F);
            this.richTextBox_Input.Location = new System.Drawing.Point(15, 248);
            this.richTextBox_Input.Multiline = false;
            this.richTextBox_Input.Name = "richTextBox_Input";
            this.richTextBox_Input.Size = new System.Drawing.Size(348, 22);
            this.richTextBox_Input.TabIndex = 4;
            this.richTextBox_Input.Text = "";
            this.richTextBox_Input.Click += new System.EventHandler(this.richTextBox_Input_Click);
            this.richTextBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(186, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "语法提示（Debug）";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_Pars
            // 
            this.textBox_Pars.Location = new System.Drawing.Point(302, 10);
            this.textBox_Pars.Multiline = true;
            this.textBox_Pars.Name = "textBox_Pars";
            this.textBox_Pars.Size = new System.Drawing.Size(10, 13);
            this.textBox_Pars.TabIndex = 2;
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 282);
            this.Controls.Add(this.textBox_Pars);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Output);
            this.Name = "Console";
            this.Text = "Console";
            this.Load += new System.EventHandler(this.Console_Load);
            this.panel_Output.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_Input;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_Pars;
    }
}