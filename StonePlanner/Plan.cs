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
        /// <summary>
        /// 任务大标题
        /// </summary>
        public string capital;
        /// <summary>
        /// 任务自动编号值
        /// </summary>
        public int Lnumber;
        /// <summary>
        /// 任务状态
        /// </summary>
        public string status = "待办";
        /// <summary>
        /// 完成任务所需时间
        /// </summary>
        public int dwSeconds;
        /// <summary>
        /// 任务具体介绍
        /// </summary>
        public string dwIntro = "";
        /// <summary>
        /// 任务难度
        /// </summary>
        public double dwDifficuly = 0.0D;

        public Plan(string lpCapital, int dwSeconds,string dwIntro)
        {
            InitializeComponent();
            capital = lpCapital;
            this.dwSeconds = dwSeconds;
            this.dwIntro = dwIntro;
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            label_TaskDes.Text = capital;
            button_Finish.Text = Main.langInfo[1];
            label_Time.Text = dwSeconds.ToString();
            this.timer1.Enabled = true;
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
        protected override void CreateHandle()
        {
            if (!IsHandleCreated)
            {
                try
                {
                    base.CreateHandle();
                }
                catch { }
                finally
                {
                    if (!IsHandleCreated)
                    {
                        base.RecreateHandle();
                    }
                }
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

        private void timer2_Tick(object sender, EventArgs e)
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

        private void label_TaskDes_Click_1(object sender, EventArgs e)
        {
            Main.Sign = 6;
            Main.plan = this;
        }
    }
    
}
