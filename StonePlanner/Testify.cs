using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Testify : MetroForm
    {
        public Testify()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = Login.UserName;
            label3.Text = $"登录类型：{Login.UserType}";
            label4.Text = $"用户金钱：{Main.money}";
            label5.Text = $"用户耐力值：{Main.lasting}";
            label6.Text = $"用户爆发值：{Main.explosive}";
            label7.Text = $"用户智慧值：{Main.wisdom}";
            label8.Text = $"剩余时间：{Main.nTime}";
            label9.Text = $"主信号值：0";
        }

        private void Testify_Load(object sender, EventArgs e)
        {

        }
    }
}
