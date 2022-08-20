namespace StonePlanner
{
    partial class ActivationRequired
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivationRequired));
            this.pictureBox_Caplial = new System.Windows.Forms.PictureBox();
            this.label_CAp = new System.Windows.Forms.Label();
            this.textBox_EnterCode = new System.Windows.Forms.TextBox();
            this.label_D = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Caplial)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Caplial
            // 
            this.pictureBox_Caplial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Caplial.BackgroundImage")));
            this.pictureBox_Caplial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Caplial.Location = new System.Drawing.Point(2, 4);
            this.pictureBox_Caplial.Name = "pictureBox_Caplial";
            this.pictureBox_Caplial.Size = new System.Drawing.Size(296, 47);
            this.pictureBox_Caplial.TabIndex = 0;
            this.pictureBox_Caplial.TabStop = false;
            // 
            // label_CAp
            // 
            this.label_CAp.AutoSize = true;
            this.label_CAp.Font = new System.Drawing.Font("SimHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CAp.Location = new System.Drawing.Point(318, 90);
            this.label_CAp.Name = "label_CAp";
            this.label_CAp.Size = new System.Drawing.Size(133, 29);
            this.label_CAp.TabIndex = 1;
            this.label_CAp.Text = "需要激活";
            // 
            // textBox_EnterCode
            // 
            this.textBox_EnterCode.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnterCode.Location = new System.Drawing.Point(146, 138);
            this.textBox_EnterCode.Name = "textBox_EnterCode";
            this.textBox_EnterCode.Size = new System.Drawing.Size(406, 26);
            this.textBox_EnterCode.TabIndex = 2;
            // 
            // label_D
            // 
            this.label_D.AutoSize = true;
            this.label_D.Location = new System.Drawing.Point(219, 183);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(341, 12);
            this.label_D.TabIndex = 3;
            this.label_D.Text = "您的版本（Evaluation）不允许您使用该功能，请激活后使用。";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(558, 138);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 26);
            this.button_Submit.TabIndex = 4;
            this.button_Submit.Text = "激活";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // ActivationRequired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 221);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label_D);
            this.Controls.Add(this.textBox_EnterCode);
            this.Controls.Add(this.label_CAp);
            this.Controls.Add(this.pictureBox_Caplial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivationRequired";
            this.Text = "ActivationRequired";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Caplial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Caplial;
        private System.Windows.Forms.Label label_CAp;
        private System.Windows.Forms.TextBox textBox_EnterCode;
        private System.Windows.Forms.Label label_D;
        private System.Windows.Forms.Button button_Submit;
    }
}