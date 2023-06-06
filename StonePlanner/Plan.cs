using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StonePlanner.Structs;

namespace StonePlanner
{
    public partial class Plan : UserControl
    {
        //编写+第一次重构
        /*
         * 一次写好 是最明智的做法
         * 继承 继承 继承
         * 封装 封装 封装
         * 多态 多态 多态
         * 面向对象白学了属于是
         * 现在写出这样的大粪来
         */
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
        public int seconds;
        /// <summary>
        /// 任务具体介绍
        /// </summary>
        public string intro = "";
        /// <summary>
        /// 任务难度
        /// </summary>
        public double difficulty = 0.0D;
        //第二次重构
        /*
         * 重载 重载 重载 重载
         * 写的都是些什么玩意
         * 我不希望看到
         * 你有一亿个重载
         * 让你创新 不是创死我自己
         */
        /// <summary>
        /// 任务持久力<code>MA_LASTING值</code>
        /// </summary>
        public int lasting;
        /// <summary>
        /// 任务爆发力<code>MA_EXPLOSIVE值</code>
        /// </summary>
        public int explosive;
        /// <summary>
        /// 任务智慧值<code>MA_WISDOM值</code>
        /// </summary>
        public int wisdom;
        //第三次重构
        /* 
         * 我人麻了 真不知道你是怎么想的
         * 任务状态这种无用东西加上 ID不要了
         * 或许你刚开始确实没想到要做大 但是你之前有两次重构
         * 什么都加了 就是ID没加
         * 脑子被驴踢了是吧
         * 记住 写代码要用脑子写 而不是寄吧
         * 导致现在一个什么问题 用所谓UDID标识 而不是ID
         * 那ID的用途是什么 占用空间吗
         */
        /// <summary>
        /// 任务唯一标识符 
        /// </summary>
        public int ID;
        //第四次重构
        /*
         * 世界爆炸
         * 重构是最痛苦的事情 没有之一
         * 把这些东西都的封装起来不好吗
         * 非得弄得到处都是 乱七八糟
         * 牵一发而动全身 直接大出血
         * 以后更新 我看你怎么办
         * 哼哼啊啊啊啊啊啊啊啊啊啊（恼）
         */
        /// <summary>
        /// 所属类别
        /// </summary>
        public string parent;
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime startTime;
        /*
         * 第五次重构
         * 我们修复了遍地都是的重载和乱七八糟的类
         * 乱世已过，静待花开
         */

        internal Plan(PlanClassA @struct)
        {
            InitializeComponent();
            this.capital = @struct.capital;
            this.seconds = @struct.seconds;
            this.intro = @struct.intro;
            this.difficulty = @struct.difficulty;
            this.lasting = @struct.lasting;
            this.explosive = @struct.explosive;
            this.wisdom = @struct.wisdom;
            this.parent = @struct.parent;
            this.startTime = DateTime.FromBinary(@struct.startTime);
            //智障代码
            this.ID = new Random().Next(100000000, 999999999);
        }

        internal Plan(PlanClassB @struct)
        {
            InitializeComponent();
            this.capital = @struct.capital;
            this.seconds = @struct.seconds;
            this.intro = @struct.intro;
            this.difficulty = @struct.difficulty;
            this.lasting = @struct.lasting;
            this.explosive = @struct.explosive;
            this.wisdom = @struct.wisdom;
            this.startTime = DateTime.FromBinary(@struct.startTime);
            this.ID = @struct.UDID;
        }

        internal Plan(PlanClassC @struct)
        {
            InitializeComponent();
            try
            {
                this.capital = @struct.capital;
                this.seconds = @struct.seconds;
                this.intro = @struct.intro;
                this.difficulty = @struct.difficulty;
                this.lasting = @struct.lasting;
                this.explosive = @struct.explosive;
                this.wisdom = @struct.wisdom;
                this.parent = @struct.parent;
                this.startTime = DateTime.FromBinary(@struct.startTime);
                this.ID = @struct.UDID;
            }
            catch (NullReferenceException e) 
            {
                ErrorCenter.AddError(DataType.ExceptionsLevel.Caution, e);
            }
        }

 

        private void Plan_Load(object sender, EventArgs e)
        {
            label_TaskDes.Text = capital;
            button_Finish.Text = "完成";
            label_Time.Text = seconds.ToString();
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
                catch(Exception ex) { ErrorCenter.AddError(DataType.ExceptionsLevel.Error, ex); }
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
            button_Finish.Enabled = false;
            //更新金钱
            //添加限制条件：只有任务完成时才可以被删除
            if (this.seconds == 0)
            {
                Main.MoneyUpdate(+(int) this.difficulty * 10);
                //更新属性
                Main.ValuesUpdate(+lasting, +explosive, +wisdom);
                Main.AddSign(1);
                Main.plan = this;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds <= 0)
            {
                seconds = 0;
                panel_Status.BackColor = Color.Lime;
                status = "已办完";
            }
            if (panel_Status.BackColor == Color.Red)
            {
                seconds -= 1;
            }
            label_Time.Text = seconds.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (seconds <= 0)
            {
                seconds = 0;
                panel_Status.BackColor = Color.Lime;
                status = "已办完";
            }
            if (panel_Status.BackColor == Color.Red)
            {
                seconds -= 1;
            }
            label_Time.Text = seconds.ToString();
        }

        private void label_TaskDes_Click_1(object sender, EventArgs e)
        {
            Main.AddSign(6);
            Main.plan = this;
        }
    }
    
}
