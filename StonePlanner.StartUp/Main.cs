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
        protected string res;
        private async void Main_Load(object sender, EventArgs e)
        {
            top = 0;
            panel_Top.BringToFront();
            panel_Main.SendToBack();
            WebClient wc = new WebClient();
            string res = await wc.DownloadStringTaskAsync(new Uri("https://lzr2006.github.io/wkgd/Aim/source.txt"));
            while (res == null) { }
            ReLoad(res);
        }

        protected void ReLoad(string res) 
        {
            List<string> versionList = new List<string>(res.Split(','));
            foreach (var item in versionList)
            {
                List<string> inVersion = new List<string>(item.Split('\n'));
                for (int i = 0; i < inVersion.Count; i++)
                {
                    if (inVersion[i] == "")
                    {
                        continue;
                    }
                    inVersion[i] = inVersion[i].Replace('\r', ' ');
                    if (i == 0)
                    {
                        string vName = inVersion[i].Split(':')[0] + "°æ±¾";
                        Splitter spirt = new Splitter(vName);
                        spirt.Top = top;
                        panel_Main.Controls.Add(spirt);
                        top += 20;
                        continue;
                    }
                    try
                    {
                        Version ver = new Version($"{inVersion[i].Split('-')[0]}",
                            Image.FromFile($"{Application.StartupPath}\\res\\aim.png"), false,
                            $"{inVersion[i].Split('-')[1]}");
                        ver.Top = top;
                        ver.Left = -30;
                        panel_Main.Controls.Add(ver);
                        top += 48;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
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
            ReLoad(res);
        }
    }
}