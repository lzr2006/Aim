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
            this.label_C = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_B = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_C.Location = new System.Drawing.Point(5, 7);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(322, 15);
            this.label_C.TabIndex = 0;
            this.label_C.Text = "很抱歉，应用程序发生了内部错误，原因如下：";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(721, 268);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_B.Location = new System.Drawing.Point(9, 303);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(727, 75);
            this.label_B.TabIndex = 2;
            this.label_B.Text = resources.GetString("label_B.Text");
            // 
            // BugReporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 385);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_C);
            this.Name = "BugReporter";
            this.Text = "应用程序内部错误";
            this.Load += new System.EventHandler(this.BugReporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_B;
    }
}