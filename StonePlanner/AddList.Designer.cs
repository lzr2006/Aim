namespace StonePlanner
{
    partial class AddList
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
            this.label_Listname = new System.Windows.Forms.Label();
            this.textBox_Listname = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Listname
            // 
            this.label_Listname.AutoSize = true;
            this.label_Listname.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_Listname.Location = new System.Drawing.Point(5, 9);
            this.label_Listname.Name = "label_Listname";
            this.label_Listname.Size = new System.Drawing.Size(98, 15);
            this.label_Listname.TabIndex = 0;
            this.label_Listname.Text = "清单名（&N）:";
            // 
            // textBox_Listname
            // 
            this.textBox_Listname.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Listname.Location = new System.Drawing.Point(8, 34);
            this.textBox_Listname.Name = "textBox_Listname";
            this.textBox_Listname.Size = new System.Drawing.Size(218, 22);
            this.textBox_Listname.TabIndex = 1;
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("SimSun", 10F);
            this.button_Submit.Location = new System.Drawing.Point(-7, 77);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(259, 34);
            this.button_Submit.TabIndex = 2;
            this.button_Submit.Text = "提交(&S)";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // AddList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 104);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Listname);
            this.Controls.Add(this.label_Listname);
            this.Name = "AddList";
            this.Text = "新建清单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Listname;
        private System.Windows.Forms.TextBox textBox_Listname;
        private System.Windows.Forms.Button button_Submit;
    }
}