namespace StonePlanner
{
    partial class Importer
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
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.button_Choose = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.label_iInfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Import = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("宋体", 11F);
            this.label_Address.Location = new System.Drawing.Point(5, 11);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(85, 19);
            this.label_Address.TabIndex = 0;
            this.label_Address.Text = "预设包：";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Address.Location = new System.Drawing.Point(80, 7);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(253, 28);
            this.textBox_Address.TabIndex = 1;
            // 
            // button_Choose
            // 
            this.button_Choose.Location = new System.Drawing.Point(339, 7);
            this.button_Choose.Name = "button_Choose";
            this.button_Choose.Size = new System.Drawing.Size(40, 28);
            this.button_Choose.TabIndex = 2;
            this.button_Choose.Text = "...";
            this.button_Choose.UseVisualStyleBackColor = true;
            this.button_Choose.Click += new System.EventHandler(this.button_Choose_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("宋体", 11F);
            this.label_Password.Location = new System.Drawing.Point(385, 11);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(66, 19);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "密码：";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(445, 7);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(226, 28);
            this.textBox_Password.TabIndex = 4;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(677, 7);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(62, 28);
            this.button_Open.TabIndex = 5;
            this.button_Open.Text = "打开";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // label_iInfo
            // 
            this.label_iInfo.AutoSize = true;
            this.label_iInfo.Font = new System.Drawing.Font("宋体", 11F);
            this.label_iInfo.Location = new System.Drawing.Point(5, 48);
            this.label_iInfo.Name = "label_iInfo";
            this.label_iInfo.Size = new System.Drawing.Size(123, 19);
            this.label_iInfo.TabIndex = 6;
            this.label_iInfo.Text = "预设包内容：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(727, 345);
            this.dataGridView1.TabIndex = 7;
            // 
            // button_Import
            // 
            this.button_Import.Font = new System.Drawing.Font("宋体", 11F);
            this.button_Import.Location = new System.Drawing.Point(228, 417);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(86, 41);
            this.button_Import.TabIndex = 8;
            this.button_Import.Text = "导入";
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("宋体", 11F);
            this.button_Back.Location = new System.Drawing.Point(445, 417);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(88, 40);
            this.button_Back.TabIndex = 9;
            this.button_Back.Text = "返回";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 459);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Import);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_iInfo);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.button_Choose);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label_Address);
            this.MaximizeBox = false;
            this.Name = "Importer";
            this.Text = "预设导入器";
            this.Load += new System.EventHandler(this.Importer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Button button_Choose;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Label label_iInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.Button button_Back;
    }
}