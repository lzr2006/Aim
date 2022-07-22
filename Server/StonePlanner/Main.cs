using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Main : Form
    {
        public static string Version = "V2.3.3";
        private string _ip = string.Empty;
        private int _port = 0;
        private int _maxconn = 1;
        protected string reply = string.Empty;
        private Socket _socket = null;
        private byte[] buffer = new byte[1024 * 1024 * 2];
        protected Socket clientSocket;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.Text = $"MethodBox·Aim Server ({Version})";
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
            richTextBox_Main.Text += $@"【{DateTime.Now.ToString("HH:mm:ss")}】欢迎使用MAS，有意见记得反馈哦。";
        }

        protected void InfoAdd(string info) 
        {
            richTextBox_Main.Text += $"\n【{DateTime.Now.ToString("HH:mm:ss")}】{info}";
        }
        #region 窗体圆角
        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
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
        public void StartListen()
        {
            try
            {
                //1.0 实例化套接字(IP4寻找协议,流式协议,TCP协议)
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //2.0 创建IP对象
                IPAddress address = IPAddress.Parse(_ip);
                //3.0 创建网络端口,包括ip和端口
                IPEndPoint endPoint = new IPEndPoint(address, _port);
                //4.0 绑定套接字
                _socket.Bind(endPoint);
                //5.0 设置最大连接数
                _socket.Listen(_maxconn);
                InfoAdd($"监听{_socket.LocalEndPoint.ToString()}消息成功");
                //6.0 开始监听
                Thread thread = new Thread(ListenClientConnect);
                thread.Start();

            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 监听客户端连接
        /// </summary>
        private void ListenClientConnect()
        {
            try
            {
                while (true)
                {
                    clientSocket = _socket.Accept();
                    clientSocket.Send(Encoding.UTF8.GetBytes(reply));
                    Thread thread = new Thread(ReceiveMessage);
                    thread.Start(clientSocket);
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 接收客户端消息
        /// </summary>
        /// <param name="socket">来自客户端的socket</param>
        private void ReceiveMessage(object socket)
        {
            Socket clientSocket = (Socket) socket;
            while (true)
            {
                try
                {
                    //获取从客户端发来的数据
                    int length = clientSocket.Receive(buffer);
                    var message = Encoding.UTF8.GetString(buffer, 0, length);
                    InfoAdd($"客户端：{clientSocket.RemoteEndPoint.ToString()}，消息：{message}。");
                    EventHandler(message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    break;
                }
            }
        }

        protected void EventHandler(string message) 
        {
            if (message == "LogInfo")
            {
                reply = textBox_Servername.Text;
                clientSocket.Send(Encoding.UTF8.GetBytes(textBox_Servername.Text));
            }
        }

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

        private void button_Submit_Click(object sender, EventArgs e)
        {
            _ip = textBox_IP.Text;
            _port = Convert.ToInt32(textBox_Port.Text);
            _maxconn = Convert.ToInt32(textBox_Connect.Text);

            StartListen();
        }
    }
}
