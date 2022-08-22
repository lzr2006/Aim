namespace StonePlanner
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label_Capital = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.timer_SignalHandler = new System.Windows.Forms.Timer(this.components);
            this.panel_RightAll = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Capital
            // 
            this.label_Capital.AutoSize = true;
            this.label_Capital.Font = new System.Drawing.Font("宋体", 13F);
            this.label_Capital.Location = new System.Drawing.Point(49, 9);
            this.label_Capital.Name = "label_Capital";
            this.label_Capital.Size = new System.Drawing.Size(76, 22);
            this.label_Capital.TabIndex = 1;
            this.label_Capital.Text = "label1";
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Icon.BackgroundImage")));
            this.pictureBox_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Icon.Location = new System.Drawing.Point(6, 1);
            this.pictureBox_Icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(37, 34);
            this.pictureBox_Icon.TabIndex = 1;
            this.pictureBox_Icon.TabStop = false;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.BackgroundImage")));
            this.pictureBox_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Exit.Location = new System.Drawing.Point(1241, 4);
            this.pictureBox_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(33, 31);
            this.pictureBox_Exit.TabIndex = 2;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.White;
            this.panel_Top.Controls.Add(this.pictureBox_Exit);
            this.panel_Top.Controls.Add(this.pictureBox_Icon);
            this.panel_Top.Controls.Add(this.label_Capital);
            this.panel_Top.Location = new System.Drawing.Point(-3, -1);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1281, 39);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // timer_SignalHandler
            // 
            this.timer_SignalHandler.Enabled = true;
            this.timer_SignalHandler.Tick += new System.EventHandler(this.timer_SignalHandler_Tick);
            // 
            // panel_RightAll
            // 
            this.panel_RightAll.Location = new System.Drawing.Point(0, 36);
            this.panel_RightAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_RightAll.Name = "panel_RightAll";
            this.panel_RightAll.Size = new System.Drawing.Size(221, 519);
            this.panel_RightAll.TabIndex = 1;
            // 
            // panel_Main
            // 
            this.panel_Main.Location = new System.Drawing.Point(221, 38);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1060, 528);
            this.panel_Main.TabIndex = 2;
            this.panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 556);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_RightAll);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Capital;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Timer timer_SignalHandler;
        private System.Windows.Forms.Panel panel_RightAll;
        private System.Windows.Forms.Panel panel_Main;
    }
}

