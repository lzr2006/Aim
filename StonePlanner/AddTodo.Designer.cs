namespace StonePlanner
{
    partial class AddTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTodo));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_T = new System.Windows.Forms.Label();
            this.label_TodoName = new System.Windows.Forms.Label();
            this.textBox_Capital = new System.Windows.Forms.TextBox();
            this.label_Numbered = new System.Windows.Forms.Label();
            this.textBox_Numbered = new System.Windows.Forms.TextBox();
            this.button_New = new System.Windows.Forms.Button();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.label_ToDoTime = new System.Windows.Forms.Label();
            this.label_ToDoIntro = new System.Windows.Forms.Label();
            this.textBox_Intro = new System.Windows.Forms.TextBox();
            this.label_Difficulty = new System.Windows.Forms.Label();
            this.domainUpDown_Difficulty = new System.Windows.Forms.DomainUpDown();
            this.label_Lasting = new System.Windows.Forms.Label();
            this.textBox_Lasting = new System.Windows.Forms.TextBox();
            this.textBox_Explosive = new System.Windows.Forms.TextBox();
            this.label_Explosive = new System.Windows.Forms.Label();
            this.textBox_Wisdom = new System.Windows.Forms.TextBox();
            this.label_Wisdom = new System.Windows.Forms.Label();
            this.pictureBox_T_Exit = new System.Windows.Forms.PictureBox();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Top.Controls.Add(this.pictureBox_T_Exit);
            this.panel_Top.Controls.Add(this.label_T);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(236, 30);
            this.panel_Top.TabIndex = 1;
            this.panel_Top.DoubleClick += new System.EventHandler(this.panel_Top_DoubleClick);
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_T.Location = new System.Drawing.Point(50, 6);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(123, 19);
            this.label_T.TabIndex = 2;
            this.label_T.Text = "新建一个待办";
            // 
            // label_TodoName
            // 
            this.label_TodoName.AutoSize = true;
            this.label_TodoName.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_TodoName.Location = new System.Drawing.Point(10, 42);
            this.label_TodoName.Name = "label_TodoName";
            this.label_TodoName.Size = new System.Drawing.Size(84, 15);
            this.label_TodoName.TabIndex = 2;
            this.label_TodoName.Text = "标 题(&T)：";
            // 
            // textBox_Capital
            // 
            this.textBox_Capital.Location = new System.Drawing.Point(88, 39);
            this.textBox_Capital.Name = "textBox_Capital";
            this.textBox_Capital.Size = new System.Drawing.Size(135, 21);
            this.textBox_Capital.TabIndex = 1;
            // 
            // label_Numbered
            // 
            this.label_Numbered.AutoSize = true;
            this.label_Numbered.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_Numbered.Location = new System.Drawing.Point(11, 259);
            this.label_Numbered.Name = "label_Numbered";
            this.label_Numbered.Size = new System.Drawing.Size(84, 15);
            this.label_Numbered.TabIndex = 4;
            this.label_Numbered.Text = "编 号(&N)：";
            // 
            // textBox_Numbered
            // 
            this.textBox_Numbered.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Numbered.Location = new System.Drawing.Point(88, 257);
            this.textBox_Numbered.Name = "textBox_Numbered";
            this.textBox_Numbered.Size = new System.Drawing.Size(135, 21);
            this.textBox_Numbered.TabIndex = 3;
            this.textBox_Numbered.Text = "MANIS自动分配编号";
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(13, 281);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(210, 23);
            this.button_New.TabIndex = 4;
            this.button_New.Text = "新建待办(&D)";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // textBox_Time
            // 
            this.textBox_Time.Location = new System.Drawing.Point(88, 62);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(135, 21);
            this.textBox_Time.TabIndex = 2;
            // 
            // label_ToDoTime
            // 
            this.label_ToDoTime.AutoSize = true;
            this.label_ToDoTime.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_ToDoTime.Location = new System.Drawing.Point(11, 65);
            this.label_ToDoTime.Name = "label_ToDoTime";
            this.label_ToDoTime.Size = new System.Drawing.Size(84, 15);
            this.label_ToDoTime.TabIndex = 7;
            this.label_ToDoTime.Text = "时 间(&S)：";
            // 
            // label_ToDoIntro
            // 
            this.label_ToDoIntro.AutoSize = true;
            this.label_ToDoIntro.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_ToDoIntro.Location = new System.Drawing.Point(10, 114);
            this.label_ToDoIntro.Name = "label_ToDoIntro";
            this.label_ToDoIntro.Size = new System.Drawing.Size(84, 15);
            this.label_ToDoIntro.TabIndex = 8;
            this.label_ToDoIntro.Text = "介 绍(&I)：";
            // 
            // textBox_Intro
            // 
            this.textBox_Intro.Location = new System.Drawing.Point(88, 111);
            this.textBox_Intro.Multiline = true;
            this.textBox_Intro.Name = "textBox_Intro";
            this.textBox_Intro.Size = new System.Drawing.Size(135, 59);
            this.textBox_Intro.TabIndex = 9;
            // 
            // label_Difficulty
            // 
            this.label_Difficulty.AutoSize = true;
            this.label_Difficulty.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_Difficulty.Location = new System.Drawing.Point(11, 88);
            this.label_Difficulty.Name = "label_Difficulty";
            this.label_Difficulty.Size = new System.Drawing.Size(84, 15);
            this.label_Difficulty.TabIndex = 10;
            this.label_Difficulty.Text = "难 度(&D)：";
            // 
            // domainUpDown_Difficulty
            // 
            this.domainUpDown_Difficulty.Location = new System.Drawing.Point(89, 87);
            this.domainUpDown_Difficulty.Name = "domainUpDown_Difficulty";
            this.domainUpDown_Difficulty.Size = new System.Drawing.Size(134, 21);
            this.domainUpDown_Difficulty.TabIndex = 11;
            this.domainUpDown_Difficulty.Text = "UNKNOWN 0.0";
            // 
            // label_Lasting
            // 
            this.label_Lasting.AutoSize = true;
            this.label_Lasting.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_Lasting.Location = new System.Drawing.Point(11, 179);
            this.label_Lasting.Name = "label_Lasting";
            this.label_Lasting.Size = new System.Drawing.Size(84, 15);
            this.label_Lasting.TabIndex = 12;
            this.label_Lasting.Text = "耐 力(&L)：";
            // 
            // textBox_Lasting
            // 
            this.textBox_Lasting.Location = new System.Drawing.Point(88, 178);
            this.textBox_Lasting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Lasting.Name = "textBox_Lasting";
            this.textBox_Lasting.Size = new System.Drawing.Size(135, 21);
            this.textBox_Lasting.TabIndex = 13;
            // 
            // textBox_Explosive
            // 
            this.textBox_Explosive.Location = new System.Drawing.Point(88, 204);
            this.textBox_Explosive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Explosive.Name = "textBox_Explosive";
            this.textBox_Explosive.Size = new System.Drawing.Size(135, 21);
            this.textBox_Explosive.TabIndex = 15;
            // 
            // label_Explosive
            // 
            this.label_Explosive.AutoSize = true;
            this.label_Explosive.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_Explosive.Location = new System.Drawing.Point(11, 206);
            this.label_Explosive.Name = "label_Explosive";
            this.label_Explosive.Size = new System.Drawing.Size(84, 15);
            this.label_Explosive.TabIndex = 14;
            this.label_Explosive.Text = "爆 发(&E)：";
            // 
            // textBox_Wisdom
            // 
            this.textBox_Wisdom.Location = new System.Drawing.Point(88, 231);
            this.textBox_Wisdom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Wisdom.Name = "textBox_Wisdom";
            this.textBox_Wisdom.Size = new System.Drawing.Size(135, 21);
            this.textBox_Wisdom.TabIndex = 17;
            // 
            // label_Wisdom
            // 
            this.label_Wisdom.AutoSize = true;
            this.label_Wisdom.Font = new System.Drawing.Font("SimSun", 11F);
            this.label_Wisdom.Location = new System.Drawing.Point(11, 233);
            this.label_Wisdom.Name = "label_Wisdom";
            this.label_Wisdom.Size = new System.Drawing.Size(84, 15);
            this.label_Wisdom.TabIndex = 16;
            this.label_Wisdom.Text = "智 慧(&W)：";
            // 
            // pictureBox_T_Exit
            // 
            this.pictureBox_T_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_T_Exit.BackgroundImage")));
            this.pictureBox_T_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_T_Exit.Location = new System.Drawing.Point(207, 3);
            this.pictureBox_T_Exit.Name = "pictureBox_T_Exit";
            this.pictureBox_T_Exit.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_T_Exit.TabIndex = 18;
            this.pictureBox_T_Exit.TabStop = false;
            this.pictureBox_T_Exit.Click += new System.EventHandler(this.pictureBox_T_Exit_Click);
            // 
            // AddTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 310);
            this.Controls.Add(this.textBox_Wisdom);
            this.Controls.Add(this.label_Wisdom);
            this.Controls.Add(this.textBox_Explosive);
            this.Controls.Add(this.label_Explosive);
            this.Controls.Add(this.textBox_Lasting);
            this.Controls.Add(this.label_Lasting);
            this.Controls.Add(this.domainUpDown_Difficulty);
            this.Controls.Add(this.label_Difficulty);
            this.Controls.Add(this.textBox_Intro);
            this.Controls.Add(this.label_ToDoIntro);
            this.Controls.Add(this.textBox_Time);
            this.Controls.Add(this.label_ToDoTime);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.textBox_Numbered);
            this.Controls.Add(this.label_Numbered);
            this.Controls.Add(this.textBox_Capital);
            this.Controls.Add(this.label_TodoName);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTodo";
            this.Text = "AddTodo";
            this.Load += new System.EventHandler(this.AddTodo_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_T_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_TodoName;
        private System.Windows.Forms.TextBox textBox_Capital;
        private System.Windows.Forms.Label label_Numbered;
        private System.Windows.Forms.TextBox textBox_Numbered;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.Label label_ToDoTime;
        private System.Windows.Forms.Label label_ToDoIntro;
        private System.Windows.Forms.TextBox textBox_Intro;
        private System.Windows.Forms.Label label_Difficulty;
        private System.Windows.Forms.DomainUpDown domainUpDown_Difficulty;
        private System.Windows.Forms.Label label_Lasting;
        private System.Windows.Forms.TextBox textBox_Lasting;
        private System.Windows.Forms.TextBox textBox_Explosive;
        private System.Windows.Forms.Label label_Explosive;
        private System.Windows.Forms.TextBox textBox_Wisdom;
        private System.Windows.Forms.Label label_Wisdom;
        private System.Windows.Forms.PictureBox pictureBox_T_Exit;
    }
}