using System.Net;
using System.Runtime.InteropServices;

namespace StonePlanner.StartUp
{
    public partial class Main : Form
    {
        const int WM_NCLBUTTONDOWN = 0x00A1;
        const int HTCAPTION = 0x0002;
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
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
            MainLoader(res);
        }
        protected void MainLoader(string res) 
        {
            List<string> versionList = new List<string>(res.Split(','));
            foreach (var item in versionList)
            {
                List<string> inVersion = new List<string>(item.Split('\n'));
                int j = inVersion.Count;
                for (int i = 0; i < j; i++)
                {
                    inVersion[i] = inVersion[i].Replace('\r', ' ');
                    if (inVersion[i] == "" || inVersion[i] == string.Empty)
                    {
                        continue;
                    }
                    if (i == 0)
                    {
                        if (inVersion[i] == "" || inVersion[i] == " ")
                        {
                            inVersion.RemoveAt(i);
                            i--;
                            j--;
                            continue;
                        }
                        string vName = inVersion[i].Split(':')[0] + "版本";
                        Splitter spirt = new Splitter(vName);
                        spirt.Top = top;
                        panel_Main.Controls.Add(spirt);
                        panel_Main.Height += 20;
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
                        panel_Main.Height += 48;
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
            panel_Main.Top = -top / 100 * vScrollBar_Main.Value + 42;
        }

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键   
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr) HTCAPTION, IntPtr.Zero);// 拖动窗体  
            }
        }
    }
}