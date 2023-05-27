using System;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class About : MetroForm
    {
        /// <summary>
        /// 构造函数，用于加载窗口中的控件
        /// </summary>
        public About()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用于显示感谢窗口
        /// </summary>
        public void button1_Click(object sender, EventArgs e)
        {
            Thanks t = new Thanks();
            t.Show();
        }

        /// <summary>
        /// 用于显示感谢窗口
        /// </summary>
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            Thanks t = new Thanks();
            t.Show();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}