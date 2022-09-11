using System.Net;

namespace StonePlanner.StartUp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            int top = 0;
            WebClient wc = new WebClient();
            string res = await wc.DownloadStringTaskAsync(new Uri("https://lzr2006.github.io/wkgd/Aim/source.txt"));
            while (res == null)
            {
            }
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
                        string vName = inVersion[i].Split(':')[0];
                        Splitter spirt = new Splitter(vName);
                        spirt.Top = top;
                        panel_Main.Controls.Add(spirt);
                        top += 21;
                        continue;
                    }
                    Version ver = new Version($"{inVersion[i].Split('-')[0]}",
                        Image.FromFile($"{Application.StartupPath}\\res\\aim.png"), false,
                        $"{inVersion[i].Split('-')[1]}");
                    ver.Top = top;
                    panel_Main.Controls.Add(ver);
                    top += 68;
                }
            }
            Console.WriteLine(res);
        }

        private void panel_L_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}