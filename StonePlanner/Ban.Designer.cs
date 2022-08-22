namespace StonePlanner
{
    partial class Ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ban));
            this.panel_Capital = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Ban = new System.Windows.Forms.Label();
            this.label_C2 = new System.Windows.Forms.Label();
            this.panel_D = new System.Windows.Forms.Panel();
            this.label_C = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Capital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_D.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Capital
            // 
            this.panel_Capital.BackColor = System.Drawing.Color.Yellow;
            this.panel_Capital.Controls.Add(this.label1);
            this.panel_Capital.Location = new System.Drawing.Point(-1, -2);
            this.panel_Capital.Name = "panel_Capital";
            this.panel_Capital.Size = new System.Drawing.Size(377, 35);
            this.panel_Capital.TabIndex = 0;
            this.panel_Capital.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Capital_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F);
            this.label1.Location = new System.Drawing.Point(126, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Whoops!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(106, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 116);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_Ban
            // 
            this.label_Ban.AutoSize = true;
            this.label_Ban.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Ban.Location = new System.Drawing.Point(13, 171);
            this.label_Ban.Name = "label_Ban";
            this.label_Ban.Size = new System.Drawing.Size(339, 20);
            this.label_Ban.TabIndex = 2;
            this.label_Ban.Text = "您（101.198.198.198）已被MBOX封禁";
            // 
            // label_C2
            // 
            this.label_C2.AutoSize = true;
            this.label_C2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_C2.Location = new System.Drawing.Point(13, 205);
            this.label_C2.Name = "label_C2";
            this.label_C2.Size = new System.Drawing.Size(149, 20);
            this.label_C2.TabIndex = 3;
            this.label_C2.Text = "封禁代码如下：";
            // 
            // panel_D
            // 
            this.panel_D.BackColor = System.Drawing.Color.GreenYellow;
            this.panel_D.Controls.Add(this.label_C);
            this.panel_D.Location = new System.Drawing.Point(47, 242);
            this.panel_D.Name = "panel_D";
            this.panel_D.Size = new System.Drawing.Size(292, 35);
            this.panel_D.TabIndex = 4;
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("Courier New", 12F);
            this.label_C.Location = new System.Drawing.Point(1, 7);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(262, 22);
            this.label_C.TabIndex = 5;
            this.label_C.Text = "MBAN:1145-14-1919-810";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "请将您认为可能被封禁的文件与\r\n封禁代码一并上交至MethodBox来解封。";
            // 
            // Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_D);
            this.Controls.Add(this.label_C2);
            this.Controls.Add(this.label_Ban);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_Capital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ban";
            this.Text = "Ban";
            this.Load += new System.EventHandler(this.Ban_Load);
            this.panel_Capital.ResumeLayout(false);
            this.panel_Capital.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_D.ResumeLayout(false);
            this.panel_D.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Capital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Ban;
        private System.Windows.Forms.Label label_C2;
        private System.Windows.Forms.Panel panel_D;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label2;
    }
}