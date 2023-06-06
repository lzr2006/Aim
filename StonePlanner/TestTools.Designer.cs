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
            this.imageList_M = new System.Windows.Forms.ImageList(this.components);
            this.listView_Main = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // imageList_M
            // 
            this.imageList_M.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_M.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_M.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView_Main
            // 
            this.listView_Main.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView_Main.FullRowSelect = true;
            this.listView_Main.HideSelection = false;
            this.listView_Main.Location = new System.Drawing.Point(37, 77);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.OwnerDraw = true;
            this.listView_Main.Size = new System.Drawing.Size(476, 240);
            this.listView_Main.TabIndex = 0;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.UseSelectable = true;
            this.listView_Main.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_Main_ItemChecked);
            this.listView_Main.SelectedIndexChanged += new System.EventHandler(this.listView_Main_SelectedIndexChanged);
            // 
            // TestTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 340);
            this.Controls.Add(this.listView_Main);
            this.MaximizeBox = false;
            this.Name = "TestTools";
            this.Text = "测试工具";
            this.Load += new System.EventHandler(this.TestTools_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList_M;
        private MetroFramework.Controls.MetroListView listView_Main;
    }
}