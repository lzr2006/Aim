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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Top = new System.Windows.Forms.Panel();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.label_Capital = new System.Windows.Forms.Label();
            this.label_IO = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.label_Connect = new System.Windows.Forms.Label();
            this.textBox_Connect = new System.Windows.Forms.TextBox();
            this.richTextBox_Main = new System.Windows.Forms.RichTextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_Servername = new System.Windows.Forms.TextBox();
            this.label_Servername = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.White;
            this.panel_Top.Controls.Add(this.pictureBox_Exit);
            this.panel_Top.Controls.Add(this.pictureBox_Icon);
            this.panel_Top.Controls.Add(this.label_Capital);
            this.panel_Top.Location = new System.Drawing.Point(-2, -1);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(888, 33);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.BackgroundImage = global::StonePlanner.Properties.Resources.exit;
            this.pictureBox_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Exit.Location = new System.Drawing.Point(851, 2);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(29, 28);
            this.pictureBox_Exit.TabIndex = 2;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Icon.BackgroundImage")));
            this.pictureBox_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Icon.Location = new System.Drawing.Point(5, 2);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(29, 28);
            this.pictureBox_Icon.TabIndex = 1;
            this.pictureBox_Icon.TabStop = false;
            // 
            // label_Capital
            // 
            this.label_Capital.AutoSize = true;
            this.label_Capital.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Capital.Location = new System.Drawing.Point(41, 7);
            this.label_Capital.Name = "label_Capital";
            this.label_Capital.Size = new System.Drawing.Size(69, 20);
            this.label_Capital.TabIndex = 1;
            this.label_Capital.Text = "label1";
            // 
            // label_IO
            // 
            this.label_IO.AutoSize = true;
            this.label_IO.Location = new System.Drawing.Point(12, 262);
            this.label_IO.Name = "label_IO";
            this.label_IO.Size = new System.Drawing.Size(217, 15);
            this.label_IO.TabIndex = 1;
            this.label_IO.Text = "I/O流(I/O Stream)信息显示：";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Font = new System.Drawing.Font("宋体", 10F);
            this.label_IP.Location = new System.Drawing.Point(12, 72);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(120, 17);
            this.label_IP.TabIndex = 2;
            this.label_IP.Text = "IP地址（&I）：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox_IP.Location = new System.Drawing.Point(129, 68);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(176, 27);
            this.textBox_IP.TabIndex = 3;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox_Port.Location = new System.Drawing.Point(129, 102);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(176, 27);
            this.textBox_Port.TabIndex = 5;
            this.textBox_Port.Text = "8848";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Font = new System.Drawing.Font("宋体", 10F);
            this.label_Port.Location = new System.Drawing.Point(12, 106);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(119, 17);
            this.label_Port.TabIndex = 4;
            this.label_Port.Text = "端口号（&P）：";
            // 
            // label_Connect
            // 
            this.label_Connect.AutoSize = true;
            this.label_Connect.Font = new System.Drawing.Font("宋体", 10F);
            this.label_Connect.Location = new System.Drawing.Point(11, 140);
            this.label_Connect.Name = "label_Connect";
            this.label_Connect.Size = new System.Drawing.Size(119, 17);
            this.label_Connect.TabIndex = 6;
            this.label_Connect.Text = "连接数（&C）：";
            // 
            // textBox_Connect
            // 
            this.textBox_Connect.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox_Connect.Location = new System.Drawing.Point(129, 136);
            this.textBox_Connect.Name = "textBox_Connect";
            this.textBox_Connect.Size = new System.Drawing.Size(176, 27);
            this.textBox_Connect.TabIndex = 7;
            // 
            // richTextBox_Main
            // 
            this.richTextBox_Main.Font = new System.Drawing.Font("Courier New", 8.82F);
            this.richTextBox_Main.Location = new System.Drawing.Point(15, 281);
            this.richTextBox_Main.Name = "richTextBox_Main";
            this.richTextBox_Main.Size = new System.Drawing.Size(846, 101);
            this.richTextBox_Main.TabIndex = 8;
            this.richTextBox_Main.Text = "";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(15, 167);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(290, 33);
            this.button_Submit.TabIndex = 9;
            this.button_Submit.Text = "启动服务器";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textBox_Servername
            // 
            this.textBox_Servername.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox_Servername.Location = new System.Drawing.Point(129, 34);
            this.textBox_Servername.Name = "textBox_Servername";
            this.textBox_Servername.Size = new System.Drawing.Size(176, 27);
            this.textBox_Servername.TabIndex = 11;
            this.textBox_Servername.Text = "方法盒子";
            // 
            // label_Servername
            // 
            this.label_Servername.AutoSize = true;
            this.label_Servername.Font = new System.Drawing.Font("宋体", 10F);
            this.label_Servername.Location = new System.Drawing.Point(12, 39);
            this.label_Servername.Name = "label_Servername";
            this.label_Servername.Size = new System.Drawing.Size(120, 17);
            this.label_Servername.TabIndex = 10;
            this.label_Servername.Text = "名  称（&N）：";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 393);
            this.Controls.Add(this.textBox_Servername);
            this.Controls.Add(this.label_Servername);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.richTextBox_Main);
            this.Controls.Add(this.textBox_Connect);
            this.Controls.Add(this.label_Connect);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.label_IO);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private System.Windows.Forms.Label label_Capital;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Label label_IO;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Label label_Connect;
        private System.Windows.Forms.TextBox textBox_Connect;
        private System.Windows.Forms.RichTextBox richTextBox_Main;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TextBox textBox_Servername;
        private System.Windows.Forms.Label label_Servername;
    }
}

