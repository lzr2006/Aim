using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace StonePlanner
{
    public partial class TestTools : MetroForm
    {
        public TestTools()
        {
            InitializeComponent();
        }

        private void TestTools_Load(object sender, EventArgs e)
        {
            listView_Main.LargeImageList = imageList_M;
            imageList_M.ImageSize = new Size(37, 36);
            imageList_M.Images.Add(Image.FromFile($"{Application.StartupPath}\\icon\\t_variable.png"));
            imageList_M.Images.Add(Image.FromFile($"{Application.StartupPath}\\icon\\t_errorcenter.png"));
            imageList_M.Images.Add(Image.FromFile($"{Application.StartupPath}\\icon\\t_signqueue.png"));
            listView_Main.Items.Add("变量查看").ImageIndex = 0;
            listView_Main.Items.Add("错误中心").ImageIndex = 1;
            listView_Main.Items.Add("信号队列").ImageIndex = 2;
        }

        private void listView_Main_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            MessageBox.Show(listView_Main.SelectedItems[0].SubItems[0].Text);
        }

        private void listView_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView_Main.SelectedItems[0].SubItems[0].Text == "变量查看")
                {
                    new Testify().Show();
                }
                else if (listView_Main.SelectedItems[0].SubItems[0].Text == "错误中心")
                {
                    new ErrorCenter().Show();
                }
                else if (listView_Main.SelectedItems[0].SubItems[0].Text == "信号队列")
                {
                    new SignSettings().Show();
                }
            }
            catch { }
        }
    }
}
