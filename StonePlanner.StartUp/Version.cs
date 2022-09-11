using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner.StartUp
{
    public partial class Version : UserControl
    {
        string name;
        Image img;
        bool download;
        public Version(string szName, Image lpImg,bool bDownloaded,string lpszDownloadAddress)
        {
            InitializeComponent();

            name = szName;
            img = lpImg;
            download = bDownloaded;
        }

        private void Version_Load(object sender, EventArgs e)
        {
            label_Main.Text = name;
            pictureBox_Icon.BackgroundImage = img;
            button_Download.Text = download switch
            {
                true => "启动",
                false => "加载"
            };
        }
    }
}
