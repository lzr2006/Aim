﻿namespace StonePlanner.StartUp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_L1 = new System.Windows.Forms.Label();
            this.panel_L = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.vScrollBar_Main = new System.Windows.Forms.VScrollBar();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_L.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_Top.Controls.Add(this.pictureBox1);
            this.panel_Top.Controls.Add(this.label_L1);
            this.panel_Top.Location = new System.Drawing.Point(-1, -2);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(955, 38);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(923, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_L1
            // 
            this.label_L1.AutoSize = true;
            this.label_L1.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_L1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_L1.Location = new System.Drawing.Point(9, 7);
            this.label_L1.Name = "label_L1";
            this.label_L1.Size = new System.Drawing.Size(220, 25);
            this.label_L1.TabIndex = 1;
            this.label_L1.Text = "AVC Launcher EII";
            // 
            // panel_L
            // 
            this.panel_L.Controls.Add(this.panel3);
            this.panel_L.Controls.Add(this.panel2);
            this.panel_L.Controls.Add(this.label2);
            this.panel_L.Controls.Add(this.label1);
            this.panel_L.Controls.Add(this.panel1);
            this.panel_L.Location = new System.Drawing.Point(0, 35);
            this.panel_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_L.Name = "panel_L";
            this.panel_L.Size = new System.Drawing.Size(293, 456);
            this.panel_L.TabIndex = 2;
            this.panel_L.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_L_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(18, 362);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 34);
            this.panel3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(76, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "插件管理";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(18, 322);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 34);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "启动软件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "当前用户：MethodBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "软件版本：Epsilon 1.0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(85, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 98);
            this.panel1.TabIndex = 3;
            // 
            // panel_Main
            // 
            this.panel_Main.Location = new System.Drawing.Point(296, 42);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(615, 449);
            this.panel_Main.TabIndex = 7;
            // 
            // vScrollBar_Main
            // 
            this.vScrollBar_Main.Location = new System.Drawing.Point(914, 42);
            this.vScrollBar_Main.Name = "vScrollBar_Main";
            this.vScrollBar_Main.Size = new System.Drawing.Size(28, 446);
            this.vScrollBar_Main.TabIndex = 0;
            this.vScrollBar_Main.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Main_Scroll);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 495);
            this.Controls.Add(this.vScrollBar_Main);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_L);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_L.ResumeLayout(false);
            this.panel_L.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Top;
        private Label label_L1;
        private Panel panel_L;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Panel panel_Main;
        private PictureBox pictureBox1;
        private VScrollBar vScrollBar_Main;
    }
}