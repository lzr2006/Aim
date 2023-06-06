using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace StonePlanner
{
    //没有Bug的程序不是好程序
    //                     ——MethodBox
    public partial class SchedulingCalendar : MetroForm
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
        Dictionary<DateTime, string> schd;
        bool ed;
        string result;
        SchedulingCalendarDay[,] dayarr;
        public SchedulingCalendar(Dictionary<DateTime, string> schd, 
            out string alert, bool bed = false)
        {
            InitializeComponent();
            this.schd = schd;
            ed = bed;
            if (bed)
            {
                alert = GetResult();
                return;
            }
            else
            {
                alert = "";
            }
        }

        protected void ReLoad()
        {
            foreach (var item in schd)
            {
                foreach (var d in dayarr)
                {
                    if (d is null)
                    {
                        continue;
                    }
                    try { int.Parse(d.label_Day.Text); } catch { continue; }
                    if (int.Parse(d.label_Day.Text) == item.Key.Day
                        && item.Key.Month == Convert.ToInt32(label_Now.Text.Split('年')[1].Split('月')[0])
                        && item.Key.Year == Convert.ToInt32(label_Now.Text.Split('年')[0]))
                    {
                        d.label_D.Text = item.Value;
                        if (item.Value == " 白班")
                        {
                            d.label_D.BackColor = Color.Orange;
                        }
                        else if (item.Value == " 夜班")
                        {
                            d.label_D.BackColor = Color.Blue;
                            d.label_D.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private string GetResult()
        {
            Add();
            label_Now.Text = $"{DateTime.Now.Year}年{DateTime.Now.Month}月";
            //扫描主窗口内容
            ReLoad();
            //判断是否发送排班提示
            Visible = false;
            Opacity = 0;
            //获得今天的排班
            string status = "";
            //托盘气泡提示
            foreach (var item in dayarr)
            {
                if (item is null)
                {
                    continue;
                }
                else
                {
                    if (item.label_Day.Text == DateTime.Now.Day.ToString())
                    {
                        status = item.label_D.Text;
                    }
                }
            }
            if (status == "" || status == " 班次")
            {
                result = "您今天没有要上的班";
            }
            else
            {
                result = $"您今天的班次为{status}";
            }
            ShadowType = MetroFormShadowType.None;
            Hide();
            return result;
        }


        private void SchedulingCalendar_Load(object sender, EventArgs e)
        {
            Add();
            label_Now.Text = $"{DateTime.Now.Year}年{DateTime.Now.Month}月";
            //扫描主窗口内容
            ReLoad();
            //判断是否发送排班提示
            if (ed)
            {
                Visible = false;
                Opacity = 0;
                //获得今天的排班
                string status = "";
                //托盘气泡提示
                foreach (var item in dayarr)
                {
                    if (item is null)
                    {
                        continue;
                    }
                    else
                    {
                        if (item.label_Day.Text == DateTime.Now.Day.ToString())
                        {
                            status = item.label_D.Text;
                        }
                    }
                }
                if (status == "" || status == " 班次")
                {
                    result = "您今天没有要上的班";
                }
                else
                {
                    result = $"您今天的班次为{status}";
                }
                ShadowType = MetroFormShadowType.None;
                ShowInTaskbar = false;
                Hide();
                return;
            }
        }

        protected void DayAddedHandler(object sender, ControlEventArgs e)
        {

        }

        protected void Add(int? month = null, int? year = null)
        {
            bool d = false;
            //label_Now.Controls.Clear();
            //计算第一天
            panel_CM.Controls.Clear();
            if (month is null)
            {
                d = true;
            }
            if (month is null) month = DateTime.Now.Month;
            if (year is null) year = DateTime.Now.Year;
            var mday = 1;
            try { mday = GetDay((Enums.MonthInt) month); }
            catch (NotImplementedException) { month += 1; }
            if (month == 2 && (year) % 4 == 0)
            {
                mday++;
            }
            //计算1日是周几
            DateTime dt = DateTime.Now;
            if (year is not null && month is not null)
            {
                dt = new DateTime
                    (
                        (int) year,
                        (int) month,
                        dt.Day
                    );
            }
            uint wkday = (uint) (int) ZellerCalculation(dt);
            //画矩阵！
            //五行七列式
            //INT[第几个周，这周的第几天]
            dayarr = new SchedulingCalendarDay[6, 7];
            //小母猪发情时起的变量名
            var (j, k) = (0, 0);
            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                {
                    if (wkday == 0)
                    {
                        wkday = 7;
                    }
                    j = (((int) wkday) - 1);
                }
                else
                {
                    j = 0;
                }
                for (; j < 7; j++)
                {
                    k++;
                    if (k > mday)
                    {
                        break;
                    }
                    //如果还有呢？
                    SchedulingCalendarDay day = new(k)
                    {
                        Left = j * 73,
                        Top = i * 66
                    };
                    panel_CM.Controls.Add(day);
                    //数组会不会越界？我不知道，全凭运气
                    dayarr[i, j] = day;
                }
            }
            //尝 试 查找今天
            if (d)
            {
                int today = DateTime.Now.Day;
                //今天的位置
                //--【wkday】
                int position = (int) wkday - 1 + today;
                int y = (int) Math.Ceiling((decimal) (position / 7));
                while (position > 7)
                {
                    position -= 7;
                }
                int x = position;
                //Result-Oriented Programming
                dayarr[y, x - 1].BackColor = Color.White;
            }
        }

        internal int GetDay(Enums.MonthInt mmInt)
        {
            return mmInt switch
            {
                Enums.MonthInt.January => 31,
                Enums.MonthInt.February => 27,
                Enums.MonthInt.March => 31,
                Enums.MonthInt.April => 30,
                Enums.MonthInt.May => 31,
                Enums.MonthInt.June => 30,
                Enums.MonthInt.July => 31,
                Enums.MonthInt.August => 31,
                Enums.MonthInt.September => 30,
                Enums.MonthInt.October => 31,
                Enums.MonthInt.November => 30,
                Enums.MonthInt.December => 31,
                _ => throw new NotImplementedException("他妈的，不存在这个月")
            };
        }

        internal Enums.Week ZellerCalculation(DateTime dt, int? day = null)
        {
            int year = dt.Year;
            int mon = dt.Month;
            if (day is null)
            {
                day = 1;
            }

            int century = int.Parse(year.ToString().Substring(0, 2));
            year = int.Parse(year.ToString().Substring(2, 2));//年份
            if (mon == 1 || mon == 2)
            {
                mon += 12; //'某年的1、2月要看作上一年的13、14月来计算
                year -= 1;
            }
            int week;
            week = year + year / 4 + century / 4 - century * 2 + 26 * (mon + 1) / 10 + (int) day - 1;
            week = week % 7;
            if (week < 0)
            {
                week += 7;
            }
            return (Enums.Week) (ushort) week;
        }

        private void pictureBox_T_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(label_Now.Text.Split('年')[0]);
            int month = Convert.ToInt32(label_Now.Text.Split('年')[1].Split('月')[0]);
            if (month > 0) month -= 1;
            else { month = 12; year -= 1; }
            label_Now.Text = $"{year}年{month}月";
            Add(month, year);
            ReLoad();
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(label_Now.Text.Split('年')[0]);
            int month = Convert.ToInt32(label_Now.Text.Split('年')[1].Split('月')[0]);
            if (month < 12) month += 1;
            else { month = 1; year += 1; }
            label_Now.Text = $"{year}年{month}月";
            Add(month, year);
            ReLoad();
        }

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCAPTION = 0x0002;
            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键   
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr) HTCAPTION, IntPtr.Zero);// 拖动窗体  
            }
        }
        private void notifyIconinfo_Click(object sender, EventArgs e)
        {
            Visible = true;
            Opacity = 100;
        }
    }
}