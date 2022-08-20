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
    public partial class SchedulingCalendarDay : UserControl
    {
        protected int day;
        public SchedulingCalendarDay(int day)
        {
            InitializeComponent();

            this.day = day;
        }

        private void SchedulingCalendarDay_Load(object sender, EventArgs e)
        {
            label_Day.Text = day.ToString().Length switch
            {
                1 => $"0{day}",
                2 => day.ToString(),
                _ => throw new FormatException("不应该存在的日期")
            };
        }
    }
}
