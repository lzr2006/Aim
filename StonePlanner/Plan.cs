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
        //编写+重构
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
        public double dwDifficulty = 0.0D;
        //第三次重构
        /// <summary>
        /// 任务持久力<code>MA_LASTING值</code>
        /// </summary>
        public int dwLasting;
        /// <summary>
        /// 任务爆发力<code>MA_EXPLOSIVE值</code>
        /// </summary>
        public int dwExplosive;
        /// <summary>
        /// 任务智慧值<code>MA_WISDOM值</code>
        /// </summary>
        public int dwWisdom;
        //第四次重构
        /// <summary>
        /// 任务唯一标识符 
        /// </summary>
        /* 
         * 我人麻了 真不知道你是怎么想的
         * 任务状态这种无用东西加上 ID不要了
         * 或许你刚开始确实没想到要做大 但是你之前有三次重构
         * 什么都加了 就是ID没加
         * 脑子被驴踢了是吧
         * 记住 写代码要用脑子写 而不是寄吧
         * 导致现在一个什么问题 用所谓UDID标识 而不是ID
         * 那ID的用途是什么 占用空间吗
         */
        public int UDID;

        public Plan(string lpCapital, int dwSeconds,string dwIntro,double dwDifficulty,int dwLasting = 0,int dwExplosive = 0,int dwWisdom = 0)
        {
            InitializeComponent();
            capital = lpCapital;
            this.dwSeconds = dwSeconds;
            this.dwIntro = dwIntro;
            this.dwDifficulty = dwDifficulty;
            this.dwLasting = dwLasting;
            this.dwExplosive = dwExplosive;
            this.dwWisdom = dwWisdom;
            this.UDID = new Random().Next(100000000, 999999999);
        }

        public Plan(string lpCapital, int dwSeconds, string dwIntro, double dwDifficulty,int UUID, int dwLasting = 0, int dwExplosive = 0, int dwWisdom = 0)
        {
            InitializeComponent();
            capital = lpCapital;
            this.dwSeconds = dwSeconds;
            this.dwIntro = dwIntro;
            this.dwDifficulty = dwDifficulty;
            this.dwLasting = dwLasting;
            this.dwExplosive = dwExplosive;
            this.dwWisdom = dwWisdom;
            this.UDID = UUID;
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
                catch(Exception ex) { ErrorCenter.AddError(DateTime.Now.ToString(), "Error", ex); }
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
            //更新金钱
            Main.MoneyUpdate(+(int) this.dwDifficulty * 10);
            //更新属性
            Main.ValuesUpdate(+dwLasting, +dwExplosive, +dwWisdom);
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
