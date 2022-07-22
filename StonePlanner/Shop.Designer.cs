namespace StonePlanner
{
    partial class Shop
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_tLeft = new System.Windows.Forms.Button();
            this.btn_tRight = new System.Windows.Forms.Button();
            this.label_Main = new System.Windows.Forms.Label();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(888, 591);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_tLeft
            // 
            this.btn_tLeft.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tLeft.Location = new System.Drawing.Point(15, 10);
            this.btn_tLeft.Name = "btn_tLeft";
            this.btn_tLeft.Size = new System.Drawing.Size(51, 29);
            this.btn_tLeft.TabIndex = 1;
            this.btn_tLeft.Text = "<";
            this.btn_tLeft.UseVisualStyleBackColor = true;
            this.btn_tLeft.Click += new System.EventHandler(this.btn_tLeft_Click);
            // 
            // btn_tRight
            // 
            this.btn_tRight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tRight.Location = new System.Drawing.Point(205, 10);
            this.btn_tRight.Name = "btn_tRight";
            this.btn_tRight.Size = new System.Drawing.Size(51, 29);
            this.btn_tRight.TabIndex = 2;
            this.btn_tRight.Text = ">";
            this.btn_tRight.UseVisualStyleBackColor = true;
            this.btn_tRight.Click += new System.EventHandler(this.btn_tRight_Click);
            // 
            // label_Main
            // 
            this.label_Main.AutoSize = true;
            this.label_Main.Font = new System.Drawing.Font("宋体", 11.5F);
            this.label_Main.Location = new System.Drawing.Point(87, 17);
            this.label_Main.Name = "label_Main";
            this.label_Main.Size = new System.Drawing.Size(135, 16);
            this.label_Main.TabIndex = 3;
            this.label_Main.Text = "第 1 页，共 1 页";
            // 
            // panel_Controls
            // 
            this.panel_Controls.Controls.Add(this.btn_tRight);
            this.panel_Controls.Controls.Add(this.label_Main);
            this.panel_Controls.Controls.Add(this.btn_tLeft);
            this.panel_Controls.Location = new System.Drawing.Point(314, 331);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(318, 48);
            this.panel_Controls.TabIndex = 4;
            // 
            // panel_Main
            // 
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(914, 325);
            this.panel_Main.TabIndex = 5;
            this.panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Controls.ResumeLayout(false);
            this.panel_Controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_tLeft;
        private System.Windows.Forms.Button btn_tRight;
        private System.Windows.Forms.Label label_Main;
        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button button1;
    }
}