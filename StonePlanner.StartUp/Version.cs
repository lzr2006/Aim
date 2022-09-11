using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner.StartUp
{
    public partial class Version : UserControl
    {
        string name, address;
        Image img;
        bool download;
        public Version(string szName, Image lpImg,bool bDownloaded,string lpszDownloadAddress)
        {
            InitializeComponent();

            name = szName;
            img = lpImg;
            download = bDownloaded;
            address = lpszDownloadAddress;
        }

        private async void button_Download_Click(object sender, EventArgs e)
        {
            if (download)
            {
                System.Diagnostics.Process.Start(@$"{Application.StartupPath}\\ver\\{name}\\stoneplanner.exe");
            }
            else
            {
                try
                {
                    var url = address;
                    var save = @$"{Application.StartupPath}\\ver\\{name}.zip";
                    using (var web = new WebClient())
                    {
                        await web.DownloadFileTaskAsync(url, save);
                    }
                    Directory.CreateDirectory(@$"{Application.StartupPath}\\ver\\{name}");
                    ZipFile.ExtractToDirectory(@$"{Application.StartupPath}\\ver\\{name}.zip", @$"{Application.StartupPath}\\ver\\{name}");
                    MessageBox.Show("下载完成", "下载完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("该版本暂不支持下载！","无法下载",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
        }

        private void Version_Load(object sender, EventArgs e)
        {
            label_Main.Text = name;
            pictureBox_Icon.BackgroundImage = img;
            if (Directory.Exists(@$"{Application.StartupPath}\\ver\\{name}"))
            {
                download = true;
            }
            button_Download.Text = download switch
            {
                true => "启动",
                false => "加载"
            };
        }
    }
}
