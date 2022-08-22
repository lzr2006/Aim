using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class ServerInfo : UserControl
    {

        internal string outIP = "";
        public ServerInfo()
        {
            InitializeComponent();
        }
        int T;
        private void ServerInfo_Load(object sender, EventArgs e)
        {
            T = Main.T;
            timer_Update.Enabled = true;
        }

        private void Type(Control sender, int p_1, double p_2)
        {
            GraphicsPath oPath = new GraphicsPath();
            oPath.AddClosedCurve(
                new Point[] {
            new Point(0, sender.Height / p_1),
            new Point(sender.Width / p_1, 0),
            new Point(sender.Width - sender.Width / p_1, 0),
            new Point(sender.Width, sender.Height / p_1),
            new Point(sender.Width, sender.Height - sender.Height / p_1),
            new Point(sender.Width - sender.Width / p_1, sender.Height),
            new Point(sender.Width / p_1, sender.Height),
            new Point(0, sender.Height - sender.Height / p_1) },
                (float) p_2);

            sender.Region = new Region(oPath);
        }

        private void panel_ConnectCount_Paint(object sender, PaintEventArgs e)
        {
            Type(panel_ConnectCount, 18, 0.1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Type(panel_Status, 18, 0.1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Type(panel_Runtime, 18, 0.1);
        }

        private void timer_Update_Tick(object sender, EventArgs e)
        {
            T++;
            label_OnlineR.Text = Main.ssMain.C.ToString() + "人";
            label_TimeR.Text = ConvertT(T);
        }
        public static string ConvertT(int T)
        {
            if (T < 60)
            {

                return T.ToString().Length switch
                {
                    1 => $"00:00:0{T}",
                    2 => $"00:00:{T}",
                    _ => $"00:00:00"
                };
            }
            else if (T < 3600)
            {
                int i = 0;
                for (; T >= 60; i++)
                {
                    T -= 60;
                }
                //用个吊的模式化，有病是吧
                //我明白，但是在月球上放一个屁难道会让木星的大红斑产生对海底汪汪队的毁灭性打击吗
                //T.Length = 1,L.Length = 1 => S = 1
                //T.Length = 2,L.Length = 1 => S = 4
                //T.Length = 1,L.Length = 2 => S = 2
                //T.Length = 2,L.Length = 2 => S = 8
                var mm = i.ToString().Length == 1 ? $"0{i}" : $"{i}";
                var ss = T.ToString().Length == 1 ? $"0{T}" : $"{T}";
                return $"00:{mm}:{ss}";
            }
            else
            {
                int j = 0;
                for (; T >= 3600; j++)
                {
                    T -= 3600;
                }
                int i = 0;
                for (; T >= 60; i++)
                {
                    T -= 60;
                }
                var hh = j.ToString().Length == 1 ? $"0{j}" : $"{j }";
                var mm = i.ToString().Length == 1 ? $"0{i}" : $"{i }";
                var ss = T.ToString().Length == 1 ? $"0{T}" : $"{T }";
                return $"{hh}:{mm}:{ss}";
            }
        }

        private void label_OnlineR_TextChanged(object sender, EventArgs e)
        {
            listBox_Users.Items.Clear();
            foreach (var item in Main.ssMain.ipNamePairs)
            {
                listBox_Users.Items.Add($"{item.Value}：{item.Key}");
            }
        }

        private void button_Kick_Click(object sender, EventArgs e)
        {
            try
            {
                string res = Main.ssMain.UserKicker((listBox_Users.Items[listBox_Users.SelectedIndex]).ToString());
                MessageBox.Show(res, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"踢出用户失败，可能是用户已退出！\n具体原因：{ex.Message}.","踢出失败",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = (listBox_Users.Items[listBox_Users.SelectedIndex]).ToString();
                Socket socket = Main.ssMain.ipSocketPairs[ip.Split('：')[1].Trim().Replace("\0", "")];
                byte[] buffer = Encoding.UTF8.GetBytes("-Getinfo");
                socket.Send(buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查看信息失败，可能是用户已退出！\n具体原因：{ex.Message}.", "踢出失败", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button_Task_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = (listBox_Users.Items[listBox_Users.SelectedIndex]).ToString().Split('：')[1].Trim().Replace("\0", "");
                outIP = ip;

                //显示
                Main.AddSignal((int) Signals.Signal.SN_REMOVESERVERSETTINGS);
                Main.AddSignal((int) Signals.Signal.SN_REMOVESERVERINFO);
                Main.AddSignal((int) Signals.Signal.SN_ADDTASKSETTINGS);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"获取用户失败，可能是用户已退出！\n具体原因：{ex.Message}.", "踢出失败", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// 重试
        /// </summary>
        /// <param name="arr">ArrayList arr that Required：An <code>Action</code> which generic,count,and wait time.</param>
        protected async void ReTry(ArrayList arr) 
        {
            for (int i = 0; i < Convert.ToInt32(arr[1]); i++)
            {
                await Task.Run(() => arr[0] as Func<bool>);
            }
        }
    }
}
