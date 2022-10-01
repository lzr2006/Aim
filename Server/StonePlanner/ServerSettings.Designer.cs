namespace StonePlanner
{
    partial class ServerSettings
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_IpAddress = new System.Windows.Forms.Label();
            this.textBox_IpAddress = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.label_MaxConnect = new System.Windows.Forms.Label();
            this.textBox_MaxConnect = new System.Windows.Forms.TextBox();
            this.label_Method = new System.Windows.Forms.Label();
            this.comboBox__Method = new System.Windows.Forms.ComboBox();
            this.label_Output = new System.Windows.Forms.Label();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_IpAddress
            // 
            this.label_IpAddress.AutoSize = true;
            this.label_IpAddress.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_IpAddress.Location = new System.Drawing.Point(21, 21);
            this.label_IpAddress.Name = "label_IpAddress";
            this.label_IpAddress.Size = new System.Drawing.Size(125, 18);
            this.label_IpAddress.TabIndex = 0;
            this.label_IpAddress.Text = "服务器IP(&A)：";
            this.label_IpAddress.UseWaitCursor = true;
            // 
            // textBox_IpAddress
            // 
            this.textBox_IpAddress.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IpAddress.Location = new System.Drawing.Point(155, 15);
            this.textBox_IpAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_IpAddress.Name = "textBox_IpAddress";
            this.textBox_IpAddress.Size = new System.Drawing.Size(289, 28);
            this.textBox_IpAddress.TabIndex = 1;
            this.textBox_IpAddress.Text = "localhost";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Port.Location = new System.Drawing.Point(587, 15);
            this.textBox_Port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(73, 28);
            this.textBox_Port.TabIndex = 3;
            this.textBox_Port.Text = "4290";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Port.Location = new System.Drawing.Point(479, 21);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(107, 18);
            this.label_Port.TabIndex = 2;
            this.label_Port.Text = "端口号(&P)：";
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("宋体", 10F);
            this.button_Start.Location = new System.Drawing.Point(741, 21);
            this.button_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(107, 34);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "开始监听";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Font = new System.Drawing.Font("宋体", 10F);
            this.button_Stop.Location = new System.Drawing.Point(877, 12);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(107, 34);
            this.button_Stop.TabIndex = 5;
            this.button_Stop.Text = "停止监听";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // label_MaxConnect
            // 
            this.label_MaxConnect.AutoSize = true;
            this.label_MaxConnect.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_MaxConnect.Location = new System.Drawing.Point(21, 62);
            this.label_MaxConnect.Name = "label_MaxConnect";
            this.label_MaxConnect.Size = new System.Drawing.Size(161, 18);
            this.label_MaxConnect.TabIndex = 6;
            this.label_MaxConnect.Text = "最大连接人数(&M)：";
            // 
            // textBox_MaxConnect
            // 
            this.textBox_MaxConnect.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaxConnect.Location = new System.Drawing.Point(193, 58);
            this.textBox_MaxConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MaxConnect.Name = "textBox_MaxConnect";
            this.textBox_MaxConnect.Size = new System.Drawing.Size(83, 28);
            this.textBox_MaxConnect.TabIndex = 7;
            this.textBox_MaxConnect.Text = "4290";
            // 
            // label_Method
            // 
            this.label_Method.AutoSize = true;
            this.label_Method.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Method.Location = new System.Drawing.Point(323, 62);
            this.label_Method.Name = "label_Method";
            this.label_Method.Size = new System.Drawing.Size(125, 18);
            this.label_Method.TabIndex = 8;
            this.label_Method.Text = "连接方式(&W)：";
            // 
            // comboBox__Method
            // 
            this.comboBox__Method.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox__Method.FormattingEnabled = true;
            this.comboBox__Method.Items.AddRange(new object[] {
            "TCP（推荐）",
            "UDP（不推荐）"});
            this.comboBox__Method.Location = new System.Drawing.Point(453, 58);
            this.comboBox__Method.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox__Method.Name = "comboBox__Method";
            this.comboBox__Method.Size = new System.Drawing.Size(177, 28);
            this.comboBox__Method.TabIndex = 9;
            this.comboBox__Method.Text = "TCP（推荐）";
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Output.Location = new System.Drawing.Point(21, 109);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(125, 18);
            this.label_Output.TabIndex = 10;
            this.label_Output.Text = "信息接收(&I)：";
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Output.Location = new System.Drawing.Point(25, 138);
            this.richTextBox_Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.Size = new System.Drawing.Size(960, 362);
            this.richTextBox_Output.TabIndex = 11;
            this.richTextBox_Output.Text = "";
            // 
            // ServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox_Output);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.comboBox__Method);
            this.Controls.Add(this.label_Method);
            this.Controls.Add(this.textBox_MaxConnect);
            this.Controls.Add(this.label_MaxConnect);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.textBox_IpAddress);
            this.Controls.Add(this.label_IpAddress);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServerSettings";
            this.Size = new System.Drawing.Size(1056, 528);
            this.Load += new System.EventHandler(this.ServerSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_IpAddress;
        private System.Windows.Forms.TextBox textBox_IpAddress;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label_MaxConnect;
        private System.Windows.Forms.TextBox textBox_MaxConnect;
        private System.Windows.Forms.Label label_Method;
        private System.Windows.Forms.ComboBox comboBox__Method;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
    }
}
