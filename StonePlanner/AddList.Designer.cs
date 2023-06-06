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
            this.metroLabel_Name = new MetroFramework.Controls.MetroLabel();
            this.textBox_Listname = new MetroFramework.Controls.MetroTextBox();
            this.metroButton_Submit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel_Name
            // 
            this.metroLabel_Name.AutoSize = true;
            this.metroLabel_Name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel_Name.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel_Name.Location = new System.Drawing.Point(17, 51);
            this.metroLabel_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel_Name.Name = "metroLabel_Name";
            this.metroLabel_Name.Size = new System.Drawing.Size(73, 25);
            this.metroLabel_Name.TabIndex = 3;
            this.metroLabel_Name.Text = "清单名:";
            // 
            // textBox_Listname
            // 
            // 
            // 
            // 
            this.textBox_Listname.CustomButton.Image = null;
            this.textBox_Listname.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.textBox_Listname.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Listname.CustomButton.Name = "";
            this.textBox_Listname.CustomButton.Size = new System.Drawing.Size(17, 18);
            this.textBox_Listname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Listname.CustomButton.TabIndex = 1;
            this.textBox_Listname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Listname.CustomButton.UseSelectable = true;
            this.textBox_Listname.CustomButton.Visible = false;
            this.textBox_Listname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox_Listname.Lines = new string[0];
            this.textBox_Listname.Location = new System.Drawing.Point(21, 78);
            this.textBox_Listname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Listname.MaxLength = 30;
            this.textBox_Listname.Name = "textBox_Listname";
            this.textBox_Listname.PasswordChar = '\0';
            this.textBox_Listname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Listname.SelectedText = "";
            this.textBox_Listname.SelectionLength = 0;
            this.textBox_Listname.SelectionStart = 0;
            this.textBox_Listname.ShortcutsEnabled = true;
            this.textBox_Listname.Size = new System.Drawing.Size(254, 28);
            this.textBox_Listname.TabIndex = 4;
            this.textBox_Listname.UseSelectable = true;
            this.textBox_Listname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Listname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton_Submit
            // 
            this.metroButton_Submit.Location = new System.Drawing.Point(21, 117);
            this.metroButton_Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton_Submit.Name = "metroButton_Submit";
            this.metroButton_Submit.Size = new System.Drawing.Size(254, 27);
            this.metroButton_Submit.TabIndex = 5;
            this.metroButton_Submit.Text = "添加";
            this.metroButton_Submit.UseSelectable = true;
            this.metroButton_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // AddList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 153);
            this.Controls.Add(this.metroButton_Submit);
            this.Controls.Add(this.textBox_Listname);
            this.Controls.Add(this.metroLabel_Name);
            this.MaximizeBox = false;
            this.Name = "AddList";
            this.Padding = new System.Windows.Forms.Padding(15, 48, 15, 16);
            this.Text = "新建清单";
            this.Load += new System.EventHandler(this.AddList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel_Name;
        private MetroFramework.Controls.MetroTextBox textBox_Listname;
        private MetroFramework.Controls.MetroButton metroButton_Submit;
    }
}