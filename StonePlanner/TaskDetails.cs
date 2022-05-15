using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class TaskDetails : UserControl
    {

        public TaskDetails()
        {
            InitializeComponent();
        }

        private void TaskDetails_Load(object sender, EventArgs e)
        {
            if (label_StatusR.Text == "已办完")
            {
                label_StatusR.ForeColor = Color.Green;
            }
            else if (label_StatusR.Text == "正在办")
            {
                label_StatusR.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                label_StatusR.ForeColor = Color.Red;
            }
            if (label_StatusR.Text == "")
            {
                label_StatusR.Text = "暂无简介";
            }
        }
        private void Type(Control sender, int p_1, double p_2)
        {
            GraphicsPath oPath = new GraphicsPath();
            oPath.AddClosedCurve(
            new Point[] {
                new Point(0, sender.Height / p_1),
                new Point(sender.Width / p_1, 0),
                new Point(sender.Width - sender.Width / p_1, 0),
                new Point(sender.Width, sender.Height / p_1),
                new Point(sender.Width, sender.Height - sender.Height / p_1),
                new Point(sender.Width - sender.Width / p_1, sender.Height),
                new Point(sender.Width / p_1, sender.Height),
                new Point(0, sender.Height - sender.Height / p_1) },
            (float)p_2);
            sender.Region = new Region(oPath);
        }

        private void TaskDetails_Paint(object sender, PaintEventArgs e)
        {
            Type(this, 15, 0.2);
            //ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Ivory, ButtonBorderStyle.Solid);
        }

        //属性访问器
        public string Capital { get => label_Capital.Text; set => label_Capital.Text = value; }
        public string Intro { get => label_Intro.Text; set => label_Intro.Text = value; }
        public string StatusResult { get => label_StatusR.Text; set => label_StatusR.Text = value; }
        public string Time { get => label_TimeR.Text; set => label_TimeR.Text = $"{value}s"; }
        
        private void pictureBox_T_Exit_Click(object sender, EventArgs e)
        {
            Main.Sign = 7;
        }
    }
}
