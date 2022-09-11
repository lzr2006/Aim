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
    public partial class Activation : Form
    {
        public Activation()
        {
            InitializeComponent();
        }

        private void Activation_Load(object sender, EventArgs e)
        {
            if (Main.banned)
            {
                label_Tip.Text = "此时无法激活MethodBox·Aim";
                button_Submit.Enabled = false;
            }
        }

        private void linkLabel_D2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void linkLabel_D1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://afdian.net/item?plan_id=3f0291421c6211edb4b752540025c377");
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (Main.banned)
            {
                label_Tip.Text = "Aim出现了一个未知错误（Ban）";
                return;
            }
            if (License.Code.codes.Contains(textBox_Code.Text))
            {
                MessageBox.Show("激活成功，感谢您对MethodBox的支持。\n请重启软件。","激活成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //写入
                SQLConnect.SQLCommandExecution($"UPDATE Users SET Pwd = '{textBox_Code.Text}' WHERE Username = 'mactivation'", ref Main.odcConnection);
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("激活失败，请检查激活码是否有误。", "激活失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
