using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Main : Form
    {
        internal static int T = 0;
        internal static string Version = "Epsilon 1.0";
        internal static ServerSettings ssMain = new ServerSettings();
        internal static ServerInfo siMain = new ServerInfo();
        internal static TaskSettings tsMain = new TaskSettings();

        static Queue<int> signQueue = new Queue<int>();

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Console.WriteLine(ServerInfo.ConvertT(1));
            CheckForIllegalCrossThreadCalls = false;
            this.Text = $"MethodBox·Aim Server DashBoard  ({Version}) ";
            label_Capital.Text = Text;
            //圆角
            if (this.WindowState == FormWindowState.Normal)
            {
                SetWindowRegion();
            }
            else
            {
                this.Region = null;
            }
            FunctionLoader();
        }

        internal static bool AddSignal(int nSign) 
        {
            if (signQueue.Count <= 16)
            {
                signQueue.Enqueue(nSign);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void FunctionLoader() 
        {
            panel_RightAll.Controls.Add(new ControlButton("服务设置", Image.FromFile($@"{Application.StartupPath}\icon\server.png"), 1));
            panel_RightAll.Controls.Add(new ControlButton("服务信息", Image.FromFile($@"{Application.StartupPath}\icon\info.png"), 2));
            panel_RightAll.Controls.Add(new ControlButton("任务设置", Image.FromFile($@"{Application.StartupPath}\icon\settings.png"), 3));
            panel_RightAll.Controls.Add(new ControlButton("关于我们", Image.FromFile($@"{Application.StartupPath}\icon\about.png"), 4));
            panel_RightAll.Controls.Add(new ControlButton("更多事物", Image.FromFile($@"{Application.StartupPath}\icon\more.png"), 5));
            panel_Main.Controls.Add(ssMain);
            return;
        }

        #region 窗体圆角
        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 10);
            this.Region = new Region(FormPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rect">窗体大小</param>
        /// <param name="radius">圆角大小</param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arcRect, 180, 90);//左上角

            arcRect.X = rect.Right - diameter;//右上角
            path.AddArc(arcRect, 270, 90);

            arcRect.Y = rect.Bottom - diameter;// 右下角
            path.AddArc(arcRect, 0, 90);

            arcRect.X = rect.Left;// 左下角
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }
        #endregion
      
        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCAPTION = 2;

            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键   
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr) HTCAPTION, IntPtr.Zero);// 拖动窗体  
            }
        }

        int I = 0;
        private void timer_SignalHandler_Tick(object sender, EventArgs e)
        {
            if (I % 10 == 0)
            {
                T++;
            }
            I++;
            //信号解码处理
            if (signQueue.Count == 0) { return; }
            int v = signQueue.Dequeue();
            if ((Signals.Signal)v == Signals.Signal.SN_CLEAR)
            {
              
            }
            else if ((Signals.Signal)v == Signals.Signal.SN_ADDSERVERINFO)
            {
                panel_Main.Controls.Add(siMain);
                siMain.BringToFront();
            }
            else if ((Signals.Signal) v == Signals.Signal.SN_REMOVESERVERINFO)
            {
                panel_Main.Controls.Remove(siMain);
            }

            else if ((Signals.Signal) v == Signals.Signal.SN_ADDSERVERSETTINGS)
            {
                ssMain.Show();
                ssMain.Visible = true;
                ssMain.BringToFront();
            }
            else if ((Signals.Signal) v == Signals.Signal.SN_REMOVESERVERSETTINGS)
            {
                ssMain.Hide();
                ssMain.Visible = false;
            }
            else if ((Signals.Signal) v == Signals.Signal.SN_ADDTASKSETTINGS)
            {
                panel_Main.Controls.Add(tsMain);
                tsMain.BringToFront();
            }
            else if ((Signals.Signal) v == Signals.Signal.SN_REMOVETASKSETTINGS)
            {
                panel_Main.Controls.Remove(tsMain);
            }
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}