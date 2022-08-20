using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class SignSettings : Form
    {
        public SignSettings()
        {
            InitializeComponent();
        }

        private void timer_Get_Tick(object sender, EventArgs e)
        {
            listBox_M.Items.Clear();
            foreach (var item in Main.signQueue)
            {
                listBox_M.Items.Add(item);
            }
            if (listBox_M.Items.Count == 0)
            {
                listBox_M.Items.Add("当前没有信号在队列中！");
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            Main.signQueue.Dequeue();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            Main.signQueue.Clear();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Main.AddSign(Convert.ToInt32(textBox_Input.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("信号格式错误","添加失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
