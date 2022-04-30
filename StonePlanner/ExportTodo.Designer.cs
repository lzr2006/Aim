namespace StonePlanner
{
    partial class ExportTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportTodo));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_T = new System.Windows.Forms.Label();
            this.richTextBox_M = new System.Windows.Forms.RichTextBox();
            this.pictureBox_T_Exit = new System.Windows.Forms.PictureBox();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Top.Controls.Add(this.pictureBox_T_Exit);
            this.panel_Top.Controls.Add(this.label_T);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(239, 30);
            this.panel_Top.TabIndex = 1;
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_T.Location = new System.Drawing.Point(56, 6);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(123, 19);
            this.label_T.TabIndex = 3;
            this.label_T.Text = "导出您的待办";
            // 
            // richTextBox_M
            // 
            this.richTextBox_M.Location = new System.Drawing.Point(0, 30);
            this.richTextBox_M.Name = "richTextBox_M";
            this.richTextBox_M.Size = new System.Drawing.Size(236, 168);
            this.richTextBox_M.TabIndex = 2;
            this.richTextBox_M.Text = "";
            // 
            // pictureBox_T_Exit
            // 
            this.pictureBox_T_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T_Exit.BackgroundImage")));
            this.pictureBox_T_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_T_Exit.Location = new System.Drawing.Point(205, 3);
            this.pictureBox_T_Exit.Name = "pictureBox_T_Exit";
            this.pictureBox_T_Exit.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_T_Exit.TabIndex = 3;
            this.pictureBox_T_Exit.TabStop = false;
            this.pictureBox_T_Exit.Click += new System.EventHandler(this.pictureBox_T_Exit_Click);
            // 
            // ExportTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 197);
            this.Controls.Add(this.richTextBox_M);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportTodo";
            this.Text = "ExportToDo";
            this.Load += new System.EventHandler(this.ExportTodo_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.RichTextBox richTextBox_M;
        private System.Windows.Forms.PictureBox pictureBox_T_Exit;
    }
}