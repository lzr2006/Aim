namespace StonePlanner
{
    partial class ControlButton
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
            this.panel_L = new System.Windows.Forms.Panel();
            this.pictureBox_M = new System.Windows.Forms.PictureBox();
            this.label_F = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_M)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_L
            // 
            this.panel_L.Location = new System.Drawing.Point(0, 0);
            this.panel_L.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_L.Name = "panel_L";
            this.panel_L.Size = new System.Drawing.Size(13, 130);
            this.panel_L.TabIndex = 0;
            this.panel_L.Click += new System.EventHandler(this.label_F_Click);
            this.panel_L.MouseLeave += new System.EventHandler(this.This_MouseLeave);
            this.panel_L.MouseHover += new System.EventHandler(this.ControlButton_MouseHover);
            // 
            // pictureBox_M
            // 
            this.pictureBox_M.Location = new System.Drawing.Point(23, 31);
            this.pictureBox_M.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_M.Name = "pictureBox_M";
            this.pictureBox_M.Size = new System.Drawing.Size(43, 40);
            this.pictureBox_M.TabIndex = 1;
            this.pictureBox_M.TabStop = false;
            this.pictureBox_M.Click += new System.EventHandler(this.label_F_Click);
            this.pictureBox_M.MouseLeave += new System.EventHandler(this.This_MouseLeave);
            this.pictureBox_M.MouseHover += new System.EventHandler(this.ControlButton_MouseHover);
            // 
            // label_F
            // 
            this.label_F.AutoSize = true;
            this.label_F.Font = new System.Drawing.Font("宋体", 13F);
            this.label_F.Location = new System.Drawing.Point(85, 41);
            this.label_F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_F.Name = "label_F";
            this.label_F.Size = new System.Drawing.Size(98, 22);
            this.label_F.TabIndex = 2;
            this.label_F.Text = "开服设置";
            this.label_F.Click += new System.EventHandler(this.label_F_Click);
            this.label_F.MouseLeave += new System.EventHandler(this.This_MouseLeave);
            this.label_F.MouseHover += new System.EventHandler(this.ControlButton_MouseHover);
            // 
            // ControlButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label_F);
            this.Controls.Add(this.pictureBox_M);
            this.Controls.Add(this.panel_L);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ControlButton";
            this.Size = new System.Drawing.Size(221, 104);
            this.Load += new System.EventHandler(this.ControlButton_Load);
            this.Click += new System.EventHandler(this.label_F_Click);
            this.MouseLeave += new System.EventHandler(this.This_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ControlButton_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_M)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panel_L;
        internal System.Windows.Forms.PictureBox pictureBox_M;
        internal System.Windows.Forms.Label label_F;
    }
}
