namespace StonePlanner
{
    partial class Thanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thanks));
            this.panel_Background = new System.Windows.Forms.Panel();
            this.panel_Text = new System.Windows.Forms.Panel();
            this.label_E = new System.Windows.Forms.Label();
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.label_Main = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Background.SuspendLayout();
            this.panel_Text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Background
            // 
            this.panel_Background.BackColor = System.Drawing.Color.Black;
            this.panel_Background.Controls.Add(this.panel_Text);
            this.panel_Background.Location = new System.Drawing.Point(-4, -6);
            this.panel_Background.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Background.Name = "panel_Background";
            this.panel_Background.Size = new System.Drawing.Size(728, 480);
            this.panel_Background.TabIndex = 0;
            this.panel_Background.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Background_Paint);
            // 
            // panel_Text
            // 
            this.panel_Text.Controls.Add(this.label_E);
            this.panel_Text.Controls.Add(this.pictureBox_Main);
            this.panel_Text.Controls.Add(this.label_Main);
            this.panel_Text.Font = new System.Drawing.Font("YouYuan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_Text.Location = new System.Drawing.Point(-40, 13);
            this.panel_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Text.Name = "panel_Text";
            this.panel_Text.Size = new System.Drawing.Size(1130, 465);
            this.panel_Text.TabIndex = 0;
            // 
            // label_E
            // 
            this.label_E.AutoSize = true;
            this.label_E.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_E.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_E.Location = new System.Drawing.Point(634, 450);
            this.label_E.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_E.Name = "label_E";
            this.label_E.Size = new System.Drawing.Size(98, 15);
            this.label_E.TabIndex = 2;
            this.label_E.Text = "&Click to Exit";
            this.label_E.Click += new System.EventHandler(this.label_E_Click);
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Main.BackgroundImage")));
            this.pictureBox_Main.Location = new System.Drawing.Point(125, 59);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(452, 2511);
            this.pictureBox_Main.TabIndex = 1;
            this.pictureBox_Main.TabStop = false;
            // 
            // label_Main
            // 
            this.label_Main.AutoSize = true;
            this.label_Main.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Main.ForeColor = System.Drawing.Color.White;
            this.label_Main.Location = new System.Drawing.Point(91, 154);
            this.label_Main.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Main.Name = "label_Main";
            this.label_Main.Size = new System.Drawing.Size(0, 17);
            this.label_Main.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Thanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 471);
            this.Controls.Add(this.panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Thanks";
            this.Text = "Thanks";
            this.Load += new System.EventHandler(this.Thanks_Load);
            this.panel_Background.ResumeLayout(false);
            this.panel_Text.ResumeLayout(false);
            this.panel_Text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Background;
        private System.Windows.Forms.Panel panel_Text;
        private System.Windows.Forms.Label label_Main;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.Label label_E;
    }
}