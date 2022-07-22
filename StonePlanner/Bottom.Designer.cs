namespace StonePlanner
{
    partial class Bottom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_B = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("宋体", 10F);
            this.label_B.Location = new System.Drawing.Point(16, 5);
            this.label_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(42, 17);
            this.label_B.TabIndex = 1;
            this.label_B.Text = "功能";
            this.label_B.Click += new System.EventHandler(this.label_B_Click);
            // 
            // Bottom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label_B);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bottom";
            this.Size = new System.Drawing.Size(80, 28);
            this.Load += new System.EventHandler(this.Bottom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label_B;
    }
}
