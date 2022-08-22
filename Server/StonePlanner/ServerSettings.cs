using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class ServerSettings : UserControl
    {
        internal int C = 0;
        public ServerSettings()
        {
            InitializeComponent();
        }
        internal static int online = 0;
        internal Dictionary <string, Socket> ipSocketPairs = new Dictionary<string, Socket>();
        internal  Dictionary <string, string> ipNamePairs = new Dictionary<string, string>();
        internal Dictionary <string, string> nameIpPairs = new Dictionary<string, string>();
        private void button_Start_Click(object sender, EventArgs e)
        {
            //使用Socket网络通信方式连接 通过TCP方式
            IPEndPoint endPoint;
            Socket socketReceive = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            try
            {
                endPoint = new IPEndPoint(ip, Convert.ToInt32(textBox_Port.Text));
                socketReceive.Bind(endPoint);
            }
            catch 
            { 
                MessageBox.Show("请输入一个正确的端口号（一般是1001-65535）。", "通信建立失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            try
            {
                Convert.ToInt32(textBox_MaxConnect.Text);
            }
            catch
            {
                MessageBox.Show("请输入一个正确的最大人数。", "监听失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try 
            {
                socketReceive.Listen(Convert.ToInt32(textBox_MaxConnect.Text));
                //打开监听线程
                Thread receiveThread = new Thread(Receive);
                receiveThread.IsBackground = true;
                receiveThread.Start(socketReceive);
                richTextBox_Output.Text += $"【Server】INFO：监听成功";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"通信建立失败，可能是该端口已被使用！\n具体原因：{ex.Message}", "监听失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        protected void Receive(object socket) 
        {
            Socket connSocket = socket as Socket;
            while (true)
            {
                //您好，套接字用错了（逃
                Socket customerSocket = connSocket.Accept();
                Thread handleThread = new Thread(Handler);
                handleThread.IsBackground = true;
                handleThread.Start(customerSocket);
                ShowMsg("Server", customerSocket.RemoteEndPoint.ToString(), "新客户进入");
            }
        }

        protected void Handler(object usocket) 
        {
            //要求发报格式
            //HEAD|BODY
            Socket customerSocket = usocket as Socket;
            while (true)
            {
                byte[] buffer = new byte[1024 * 1024];
                int l = 0;
                try
                {
                    l = customerSocket.Receive(buffer);
                }
                catch 
                {
                    ShowMsg("Response", customerSocket.RemoteEndPoint.ToString(), "远程连接已关闭");
                    //删除用户
                    try
                    {
                        ipSocketPairs.Remove(customerSocket.RemoteEndPoint.ToString());
                        string uname = ipNamePairs[customerSocket.RemoteEndPoint.ToString()];
                        ipNamePairs.Remove(customerSocket.RemoteEndPoint.ToString());
                        nameIpPairs.Remove(uname);
                    }catch { }
                    C = ipNamePairs.Count;
                    break;
                }
                if (l == 0)
                { 
                    ShowMsg("Response", customerSocket.RemoteEndPoint.ToString(), "远程连接已关闭");
                    //删除用户
                    ipSocketPairs.Remove(customerSocket.RemoteEndPoint.ToString());
                    string uname = ipNamePairs[customerSocket.RemoteEndPoint.ToString()];
                    ipNamePairs.Remove(customerSocket.RemoteEndPoint.ToString());
                    nameIpPairs.Remove(uname);
                    C = ipNamePairs.Count;
                    break; 
                }
                //收信
                ShowMsg("Receive", customerSocket.RemoteEndPoint.ToString(), System.Text.Encoding.UTF8.GetString(buffer));
                //是否加入用户，验证用户名与密码
                string letter = System.Text.Encoding.UTF8.GetString(buffer);
                letter = letter.Replace("\0", "");
                if (letter.StartsWith("-login"))
                {
                    letter = letter.Replace("-login ", "").Trim();
                    letter = letter.Replace("\0", "").Trim();
                    string userName = letter.Split(' ')[0];
                    string pasword = letter.Split(' ')[1];
                    var loginQuery = SQLConnect.SQLCommandQuery($"SELECT * FROM db_Users WHERE uname = '{userName}' AND upwd = '{pasword}';", 
                        "methodbox5");
                    if (loginQuery.HasRows)
                    {
                        //发回数据并添加至列表
                        byte[] sendBuf = System.Text.Encoding.UTF8.GetBytes("登录成功");
                        online++;
                        //登录成功，返回在线列表。
                        customerSocket.Send(ByteConvert.ObjectToBytes(nameIpPairs));
                        try
                        {
                            nameIpPairs.Add(userName, customerSocket.RemoteEndPoint.ToString());
                        }
                        catch 
                        {
                            sendBuf = System.Text.Encoding.UTF8.GetBytes("登录失败，该用户已登录。");
                            ShowMsg("Server", customerSocket.RemoteEndPoint.ToString(), "用户尝试登录失败，该用户已存在");
                            break; 
                        }
                        ipSocketPairs.Add(customerSocket.RemoteEndPoint.ToString(), customerSocket);
                        ipNamePairs.Add(customerSocket.RemoteEndPoint.ToString(), userName);
                        
                        ShowMsg("Server", customerSocket.RemoteEndPoint.ToString(), "用户登录到服务器");
                        C = ipNamePairs.Count;
                    }
                    else
                    {
                        byte[] sendBuf = System.Text.Encoding.UTF8.GetBytes("登录失败");
                        ShowMsg("Server", customerSocket.RemoteEndPoint.ToString(), "用户尝试登录失败");
                        customerSocket.Send(sendBuf);
                    }
                }
                else
                {
                    string value = "";
                    bool exist = ipNamePairs.TryGetValue(customerSocket.RemoteEndPoint.ToString(), out value);
                    if (!exist)
                    {
                        ShowMsg("Server", customerSocket.RemoteEndPoint.ToString(), "用户未登录 已拒绝");
                        byte[] sendBuf = System.Text.Encoding.UTF8.GetBytes("请先登录");
                    }
                    try
                    {
                        Structs.UserStruct @struct = new Structs.UserStruct();
                        @struct =  (Structs.UserStruct) ByteConvert.BytesToObject(buffer);
                        UserInfo ui = new UserInfo(@struct);
                        ui.Show();
                        MessageBox.Show("关闭此对话框来关闭详情页。");
                        ui.Dispose();
                    }catch { }
                    try
                    {
                        Dictionary<string, int> tInfo = new Dictionary<string, int>();
                        tInfo = (Dictionary<string, int>) ByteConvert.BytesToObject(buffer);
                        ShowMsg("Response", customerSocket.RemoteEndPoint.ToString(), "-tasklist");
                        ShowMsg("Receive", customerSocket.RemoteEndPoint.ToString(), "A tasklist");
                        Main.tsMain.ShowTask(tInfo);
                    }
                    catch{}
                    if (letter == "-getlist")
                    {
                        customerSocket.Send(ByteConvert.ObjectToBytes(nameIpPairs));
                        ShowMsg("Receive", customerSocket.RemoteEndPoint.ToString(), "-getlist");
                        ShowMsg("Response", customerSocket.LocalEndPoint.ToString(), "列表已发送");
                    }
                }
            }
        }
        protected void ShowForm(object f) { (f as Form).Show(); }
        protected void ShowMsg(string status,string user,string message) 
        {
            richTextBox_Output.Text += $"\n【{status}】{user}：{message}";
        }
        protected void ShowMsg(string s,Func<string,string> a)
        {
            s = a(s);
        }

        private void ServerSettings_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBox_IpAddress.ReadOnly = true;
            textBox_IpAddress.Text = System.Text.Encoding.UTF8.GetString(IPAddress.Any.GetAddressBytes());
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        internal string UserKicker(string uname) 
        {
            string success = "";
            try
            {
                string un = uname.Split('：')[0];
                string ip = nameIpPairs[un];
                nameIpPairs.Remove(un);
                ipNamePairs.Remove(ip);
                ipSocketPairs.Remove(ip);

                success = "用户成功被踢出服务器。";
                C = nameIpPairs.Count;
            }
            catch (Exception e) 
            {
                success = $"用户踢出失败，原因是：{e.Message}";
            }
            return success;
        }
    }
}
