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
            //txtc();
        }
        internal static void Type(Control sender, int p_1, double p_2)
        {
            //圆 角
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
        public double Difficulty { set => txtc(value); }
        public string Lasting { get => label_LastingR.Text; set => label_LastingR.Text = value; }
        public string Explosive { get => label_ExplosiveR.Text; set => label_ExplosiveR.Text = value; }
        public string Wisdom { get => label_WisdomR.Text; set => label_WisdomR.Text = value; }

        private void pictureBox_T_Exit_Click(object sender, EventArgs e)
        {
            Main.AddSign(7);
        }

        //private void label_DifficultyR_TextChanged(object sender, EventArgs e)
        //{
        //    txtc();
        //}

        protected void txtc(double Difficulty)
        {
            try {
                //难度
                double dif = Difficulty;
                //染色+难度评定
                if (dif < 2)
                {
                    label_DifficultyR.Text = $"EASY {dif.ToString()}";
                    label_DifficultyR.ForeColor = Color.Green;
                    return;
                }
                if (4 > dif)
                {
                    label_DifficultyR.Text = $"MIDI {dif.ToString()}";
                    label_DifficultyR.ForeColor = Color.DeepSkyBlue;
                    return;
                }
                if (6 > dif)
                {
                    label_DifficultyR.Text = $"HARD {dif.ToString()}";
                    label_DifficultyR.ForeColor = Color.Gold;
                    return;
                }
                if (8 > dif)
                {
                    label_DifficultyR.Text = $"DESP {dif.ToString()}";
                    label_DifficultyR.ForeColor = Color.Orange;
                    return;
                }
                if (9 > dif)
                {
                    label_DifficultyR.Text = $"BEYD {dif.ToString()}";
                    label_DifficultyR.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    label_DifficultyR.Text = $"UNKW {dif.ToString()}";
                    label_DifficultyR.ForeColor = Color.Black;
                    return; 
                }

            }catch { }
        }
        
    }
}
