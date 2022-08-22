using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class TaskSettings : UserControl
    {
        public TaskSettings()
        {
            InitializeComponent();
        }
        int l1 = 0;
        private void button_New_Click(object sender, EventArgs e)
        {
            try
            {
                //封装Plan结构体
                Structs.PlanStruct pps = new Structs.PlanStruct();
                pps.Intro = textBox_Intro.Text;
                pps.Capital = textBox_Capital.Text;
                pps.Parent = "Null";
                pps.UDID = new Random().Next(1000000, 9999999);
                pps.Explosive = Convert.ToInt32(textBox_Explosive.Text);
                pps.Difficulty = Convert.ToDouble(domainUpDown_Difficulty.Text.Split(' ')[1]);
                pps.Wisdom = Convert.ToInt32(textBox_Wisdom.Text);
                pps.Lasting = Convert.ToInt32(textBox_Lasting.Text);
                pps.Seconds = Convert.ToInt32(textBox_Time.Text);
                //查找用户
                string ip = textBox_User.Text;
                //取得Socket
                Socket sendSocket = Main.ssMain.ipSocketPairs[ip];
                //发送消息
                byte[] buffer = ByteConvert.ObjectToBytes(pps);
                sendSocket.Send(buffer, SocketFlags.None);
            }
            catch { MessageBox.Show("信息输入错误或未选择用户！","连接失败",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
        }

        private void TaskSettings_Load(object sender, EventArgs e)
        {
            textBox_User.ReadOnly = true;
        }

        internal void ShowTask(Dictionary<string,int> pairs) 
        {
            foreach (var item in pairs)
            {
                listBox_UserTask.Items.Add(item.Key);
                l1 = item.Value;
            }
        } 

        private void timer_IPU_Tick(object sender, EventArgs e)
        {
            if (Main.siMain.outIP != "")
            {
                textBox_User.Text = Main.siMain.outIP;
                Main.siMain.outIP = "";
            }
        }

        private void radioButton_G_N_Click(object sender, EventArgs e)
        {
            MessageBox.Show("为充分保留公平性，本功能已被取消","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            radioButton_G_N.Checked = false;
            radioButton_G_Y.Checked = true;
        }

        private void timer_DPU_Tick(object sender, EventArgs e)
        {
            listBox_UserTask.Items.Clear();
            //请求拉取任务列表
            if (textBox_User.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    //查找用户
                    string ip = textBox_User.Text;
                    //取得Socket
                    Socket sendSocket = Main.ssMain.ipSocketPairs[ip];
                    //发送消息
                    byte[] buffer = Encoding.UTF8.GetBytes("-Gettask");
                    sendSocket.Send(buffer, SocketFlags.None);
                }
                catch { listBox_UserTask.Items.Add("拉取该用户的任务失败"); }
            }
        }

        private void listBox_UserTask_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Brush mybsh = Brushes.Black;
                // 判断是什么类型的标签
                if (l1 == 1)
                {
                    mybsh = Brushes.Green;
                }
                else if (l1 == 2)
                {
                    mybsh = Brushes.Red;
                }
                // 焦点框
                e.DrawFocusRectangle();
                //文本 
                e.Graphics.DrawString(listBox_UserTask.Items[e.Index].ToString(), e.Font, mybsh, e.Bounds, StringFormat.GenericDefault);
            }
        }
    }
}
