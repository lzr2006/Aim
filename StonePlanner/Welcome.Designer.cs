namespace StonePlanner
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.timer_AnimationHandler = new System.Windows.Forms.Timer(this.components);
            this.label_C1 = new System.Windows.Forms.Label();
            this.pictureBox_D = new System.Windows.Forms.PictureBox();
            this.label_C2 = new System.Windows.Forms.Label();
            this.pictureBox_T = new System.Windows.Forms.PictureBox();
            this.label_C3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Main.BackgroundImage")));
            this.pictureBox_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Main.Location = new System.Drawing.Point(-41, -39);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(426, 238);
            this.pictureBox_Main.TabIndex = 0;
            this.pictureBox_Main.TabStop = false;
            this.pictureBox_Main.SizeChanged += new System.EventHandler(this.pictureBox_Main_SizeChanged);
            // 
            // timer_AnimationHandler
            // 
            this.timer_AnimationHandler.Enabled = true;
            this.timer_AnimationHandler.Interval = 10;
            this.timer_AnimationHandler.Tick += new System.EventHandler(this.timer_AnimationHandler_Tick);
            // 
            // label_C1
            // 
            this.label_C1.AutoSize = true;
            this.label_C1.BackColor = System.Drawing.Color.Transparent;
            this.label_C1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_C1.Location = new System.Drawing.Point(114, 112);
            this.label_C1.Name = "label_C1";
            this.label_C1.Size = new System.Drawing.Size(195, 34);
            this.label_C1.TabIndex = 1;
            this.label_C1.Text = "AimPlanner";
            // 
            // pictureBox_D
            // 
            this.pictureBox_D.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_D.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_D.BackgroundImage")));
            this.pictureBox_D.Location = new System.Drawing.Point(-11, 161);
            this.pictureBox_D.Name = "pictureBox_D";
            this.pictureBox_D.Size = new System.Drawing.Size(396, 38);
            this.pictureBox_D.TabIndex = 2;
            this.pictureBox_D.TabStop = false;
            this.pictureBox_D.SizeChanged += new System.EventHandler(this.pictureBox_D_SizeChanged);
            // 
            // label_C2
            // 
            this.label_C2.AutoSize = true;
            this.label_C2.BackColor = System.Drawing.Color.Transparent;
            this.label_C2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label_C2.Location = new System.Drawing.Point(284, 92);
            this.label_C2.Name = "label_C2";
            this.label_C2.Size = new System.Drawing.Size(79, 20);
            this.label_C2.TabIndex = 3;
            this.label_C2.Text = "Epsilon";
            // 
            // pictureBox_T
            // 
            this.pictureBox_T.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_T.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T.BackgroundImage")));
            this.pictureBox_T.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_T.Location = new System.Drawing.Point(5, 5);
            this.pictureBox_T.Name = "pictureBox_T";
            this.pictureBox_T.Size = new System.Drawing.Size(30, 34);
            this.pictureBox_T.TabIndex = 4;
            this.pictureBox_T.TabStop = false;
            // 
            // label_C3
            // 
            this.label_C3.AutoSize = true;
            this.label_C3.BackColor = System.Drawing.Color.Transparent;
            this.label_C3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label_C3.Location = new System.Drawing.Point(40, 13);
            this.label_C3.Name = "label_C3";
            this.label_C3.Size = new System.Drawing.Size(99, 20);
            this.label_C3.TabIndex = 5;
            this.label_C3.Text = "MethodBox";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 180);
            this.Controls.Add(this.label_C3);
            this.Controls.Add(this.pictureBox_T);
            this.Controls.Add(this.label_C2);
            this.Controls.Add(this.pictureBox_D);
            this.Controls.Add(this.label_C1);
            this.Controls.Add(this.pictureBox_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.Timer timer_AnimationHandler;
        private System.Windows.Forms.Label label_C1;
        private System.Windows.Forms.PictureBox pictureBox_D;
        private System.Windows.Forms.Label label_C2;
        private System.Windows.Forms.PictureBox pictureBox_T;
        private System.Windows.Forms.Label label_C3;
    }
}