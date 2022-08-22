namespace StonePlanner
{
    partial class TestTools
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
            this.listView_Main = new System.Windows.Forms.ListView();
            this.imageList_M = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView_Main
            // 
            this.listView_Main.HideSelection = false;
            this.listView_Main.Location = new System.Drawing.Point(-2, 0);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(541, 343);
            this.listView_Main.TabIndex = 0;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_Main_ItemChecked);
            this.listView_Main.SelectedIndexChanged += new System.EventHandler(this.listView_Main_SelectedIndexChanged);
            // 
            // imageList_M
            // 
            this.imageList_M.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_M.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_M.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TestTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 340);
            this.Controls.Add(this.listView_Main);
            this.Name = "TestTools";
            this.Text = "测试工具";
            this.Load += new System.EventHandler(this.TestTools_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.ImageList imageList_M;
    }
}