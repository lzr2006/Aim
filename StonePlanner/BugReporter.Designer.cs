namespace StonePlanner
{
    partial class BugReporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugReporter));
            this.label_B = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_B.Location = new System.Drawing.Point(25, 401);
            this.label_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(921, 138);
            this.label_B.TabIndex = 2;
            this.label_B.Text = resources.GetString("label_B.Text");
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("宋体", 11F);
            this.label_C.Location = new System.Drawing.Point(7, 9);
            this.label_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(0, 19);
            this.label_C.TabIndex = 0;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(875, 1);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(409, 384);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(31, 84);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(964, 309);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BugReporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 560);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_C);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BugReporter";
            this.Padding = new System.Windows.Forms.Padding(27, 75, 27, 25);
            this.Text = "应用程序内部错误";
            this.Load += new System.EventHandler(this.BugReporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_C;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}