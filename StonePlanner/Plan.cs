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
    public partial class Plan : UserControl
    {
        public string capital;
        public int Lnumber;
        public string status = "待办";
        public int dwSeconds;
        public string dwIntro = "";
        public string dwAim = "";
        public Plan(string lpCapital, int dwSeconds)
        {
            InitializeComponent();
            capital = lpCapital;
            this.dwSeconds = dwSeconds;
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            label_TaskDes.Text = capital;
            button_Finish.Text = Main.langInfo[1];
            label_Time.Text = dwSeconds.ToString();
        }

        private void panel_Status_Click(object sender, EventArgs e)
        {
            if (panel_Status.BackColor == Color.LightGray)
            {
                panel_Status.BackColor = Color.Red;
                status = "正在办";
            }
            else 
            {
                panel_Status.BackColor = Color.LightGray;
                status = "待办";
            }
           
        }

        private void button_Finish_Click(object sender, EventArgs e)
        {
            Main.Sign = 1;
            Main.plan = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dwSeconds <= 0)
            {
                dwSeconds = 0;
                panel_Status.BackColor = Color.Lime;
                status = "已办完";
            }
            if (panel_Status.BackColor == Color.Red)
            {
                dwSeconds -= 1;
            }
            label_Time.Text = dwSeconds.ToString();
        }
    }
}
