using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StonePlanner
{
    public class SocketClient
    {
        private string _ip = string.Empty;
        private int _port = 0;
        private string _message = string.Empty;
        internal string _buffer = string.Empty;
        private Socket _socket = null;
        private byte[] buffer = new byte[1024 * 1024 * 2];

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ip">连接服务器的IP</param>
        /// <param name="port">连接服务器的端口</param>
        public SocketClient(string ip, int port,string wMsg)
        {
            this._ip = ip;
            this._port = port;
            this._message = wMsg;

        }
        public SocketClient(int port)
        {
            this._ip = "127.0.0.1";
            this._port = port;
        }

        /// <summary>
        /// 开启服务,连接服务端
        /// </summary>
        public void StartClient()
        {
            try
            {
                //实例化套接字(IP4寻址地址,流式传输,TCP协议)
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //创建IP对象
                IPAddress address = IPAddress.Parse(_ip);
                //创建网络端口包括ip和端口
                IPEndPoint endPoint = new IPEndPoint(address, _port);
                //建立连接
                _socket.Connect(endPoint);
                System.Console.WriteLine("连接服务器成功");
                //接收数据
                int length = _socket.Receive(buffer);
                System.Console.WriteLine("接收服务器{0},消息:{1}", _socket.RemoteEndPoint.ToString(), Encoding.UTF8.GetString(buffer, 0, length));
                _buffer = Encoding.UTF8.GetString(buffer, 0, length);
                //向服务器发送消息
                Thread.Sleep(2000);
                _socket.Send(Encoding.UTF8.GetBytes(_message));
                System.Console.WriteLine("像服务发送的消息:{0}", _message);
            }
            catch (Exception ex)
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
                System.Console.WriteLine(ex.Message);
            }
            System.Console.WriteLine("发送消息结束");
            System.Console.ReadKey();
        }
    }
}
