using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.Xml.Serialization;
using MetroFramework.Forms;
using static StonePlanner.DataType;

namespace StonePlanner
{
    public partial class Update : MetroForm
    {
        string updateSource = @"https://raw.githubusercontent.com/lzr2006/lzr2006.github.io/main/Services/StonePlanner/update.txt";
        List<VersionInfo> versions = new List<VersionInfo>();
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            //Download update data
            WebClient client = new WebClient();
            client.DownloadStringCompleted +=
                new DownloadStringCompletedEventHandler(DataFinished);
            client.DownloadStringAsync(new Uri(updateSource));
            metroLabel_NowVersion.Text =
                $"当前版本：{BASE_DATA.VERSION_NAME.Split(' ')[1]}" +
                $"({BASE_DATA.VRESION_COUNT})";
        }

        private void DataFinished(object sender, DownloadStringCompletedEventArgs e) 
        {
            string result = e.Result;
            List<string> route = new List<string>(result.Split('\n'));
            foreach (var item in route)
            {
                if (item == "")
                    break;
                DataType.VersionInfo versionInfo = new DataType.VersionInfo();
                versionInfo.Version = item.Split(';')[0];
                int num;
                int.TryParse(item.Split(';')[1], out num);
                versionInfo.Number = num;
                versionInfo.DownloadUri = new Uri(item.Split(';')[2]);
                versions.Add(versionInfo);
            }
            metroLabel_Info.Text = "获取信息成功！";
        }


        private void metroRadioButton_Beta_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton_Beta.Checked)
            {
                metroLabel_NewVersion.Text =
                    $"最新版本：{versions[1].Version}({versions[1].Number})";
                Button_Submit.Enabled = 
                    versions[1].IsNeedUpdate(BASE_DATA.VRESION_COUNT);
            }
        }

        private void metroRadioButton_Release_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton_Release.Checked)
            {
                metroLabel_NewVersion.Text =
                    $"最新版本：{versions[0].Version}({versions[0].Number})";
                Button_Submit.Enabled = 
                    versions[0].IsNeedUpdate(BASE_DATA.VRESION_COUNT);
            }
        }

        private void metroRadioButton_Dev_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton_Dev.Checked)
            {
                metroLabel_NewVersion.Text =
                    $"最新版本：{versions[2].Version}({versions[2].Number})";
                Button_Submit.Enabled = 
                    versions[2].IsNeedUpdate(BASE_DATA.VRESION_COUNT);
            }
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            //Download newest version
            if (true)
            {

            }
        }
    }
}