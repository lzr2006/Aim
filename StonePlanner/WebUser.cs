using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class WebUser : Form
    {
        protected Socket receiveSocket;
        public WebUser(Socket receiveSocket)
        {
            InitializeComponent();

            this.receiveSocket = receiveSocket;
        }

        private void WebUser_Load(object sender, EventArgs e)
        {
            //Thread td = new Thread(Receive);
            //td.IsBackground = true;
            //td.Start();
        }

        //protected void Receive() 
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            byte[] buffer = new byte[1024 * 1024];
        //            receiveSocket.Receive(buffer, SocketFlags.None);
        //            string serverInfo = Encoding.UTF8.GetString(buffer).Trim().Replace("\0","");
                    
        //        }
        //        catch { receiveSocket.Close(); return; }
        //    }
        //}
    }
}
