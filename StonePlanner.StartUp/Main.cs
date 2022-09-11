using StonePlanner.StartUp.Models;
using System.Net;

namespace StonePlanner.StartUp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        protected static int top;
        protected string versionInfo;
        private async void Main_Load(object sender, EventArgs e)
        {
            top = 0;
            panel_Top.BringToFront();
            panel_Main.SendToBack();
            var httpClient = new HttpClient();
            string versionInfo = await httpClient.GetStringAsync(new Uri("https://lzr2006.github.io/wkgd/Aim/source.txt"));
            ReLoad(versionInfo);
        }

        protected void ReLoad(string versionInfo) 
        {
            // TODO 读取标准csv的信息然后封装一个数据类
            var testVersionData = new VersionData
            {
                VersionName = "Beta 114514",
                DownloadUri = new Uri("https://114514.1919810.cs"),
                VersionType = VersionType.Beta
            };
            MessageBox.Show($"VerisonName: {testVersionData.VersionName}\n" +
                $"DownloadUri: {testVersionData.DownloadUri}\n" +
                $"VersionType: {testVersionData.VersionType}");
        }

        private void panel_L_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void vScrollBar_Main_Scroll(object sender, ScrollEventArgs e)
        {
            panel_Main.Top = -top / 100 * vScrollBar_Main.Value;
            ReLoad(versionInfo);
        }
    }
}