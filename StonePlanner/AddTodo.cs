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
    public partial class AddTodo : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
        public AddTodo()
        {
            InitializeComponent();
        }

        internal AddTodo(Structs.PlanStruct planStruct)
        {
            InitializeComponent();
            try
            {
                domainUpDown_Difficulty.Text = "SERVER" + " " + planStruct.Difficulty.ToString();
            }
            catch
            {
                domainUpDown_Difficulty.Text = "SERVER" + " " + "0.0";
            }
            try
            {
                textBox_Capital.Text = planStruct.Capital;
            }
            catch
            {
                textBox_Capital.Text = "无标题";
            }
            try
            {
                textBox_Explosive.Text = planStruct.Explosive.ToString();
            }
            catch
            {
                textBox_Explosive.Text = "0";
            }
            try
            {
                textBox_Intro.Text = planStruct.Intro;
            }
            catch
            {
                textBox_Intro.Text = "无简介";
            }
            try
            {
                textBox_Lasting.Text = planStruct.Lasting.ToString();
            }
            catch
            {
                textBox_Lasting.Text = "0";
            }
            try
            {
                textBox_Time.Text = planStruct.Seconds.ToString();
            }
            catch
            {
                textBox_Time.Text = "100";
            }
            try
            {
                textBox_Wisdom.Text = planStruct.Wisdom.ToString();
            }
            catch
            {
                textBox_Wisdom.Text = "0";
            }
        }

        private void AddTodo_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            label_T.Text = Main.langInfo[3];
            label_TodoName.Text = Main.langInfo[4];
            label_Numbered.Text = Main.langInfo[5];
            button_New.Text = Main.langInfo[6];
            textBox_Numbered.ReadOnly = true;
            //Default HH and mm
            //Default MotherFucker
            textBox_hh.Text = DateTime.Now.ToString("HH");
            textBox_mm.Text = DateTime.Now.ToString("mm");
            //难度添加
            for (double i = 0.1; i < 2.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"EASY {i}");
            }
            for (double i = 2.1; i < 4.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"MIDDLE {i}");
            }
            for (double i = 4.1; i < 6.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"HARD {i}");
            }
            for (double i = 6.1; i < 9.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"DESPAIR {i}");
            }
            for (double i = 9.1; i < 10.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"BEYOND {i}");
            }

            //读取清单
            var sResult = SQLConnect.SQLCommandQuery("SELECT * FROM Lists");
            while (sResult.Read())
            {
                comboBox_List.Items.Add(sResult[1]);
            }

            //加载TIPS
            try
            {
                WFJsonStructure.DataItem weather;
                Main.wf.GetWInfo(out weather);
                if (Convert.ToInt32(weather.air) >= 180)
                {
                    //TIPS：今天天气状态良好，可以做想做的事情。
                    label_Tips.Text = $"TIPS:空气较差（{weather.air}），不建议在外活动。";
                }
                else if (Convert.ToInt32(weather.uvIndex) > 6)
                {
                    label_Tips.Text = $"TIPS:今日紫外线较强（{weather.uvIndex}），请做好防护。";
                }
            }
            catch
            {
                //天气预报 not loaded (x)
                //developer should be fucked (√)
            }
        }

        private unsafe void button_New_Click(object sender, EventArgs e)
        {
            try
            {
                //封装类送走
                PlanClassC psc = new PlanClassC();
                psc.lpCapital = textBox_Capital.Text;
                psc.iSeconds = Convert.ToInt32(textBox_Time.Text);
                psc.dwIntro = textBox_Intro.Text;
                psc.iLasting = Convert.ToInt32(textBox_Lasting.Text);
                psc.iExplosive = Convert.ToInt32(textBox_Explosive.Text);
                psc.iWisdom = Convert.ToInt32(textBox_Wisdom.Text);
                psc.lpParent = comboBox_List.SelectedItem.ToString();
                DateTime _ = new DateTime(
                    dateTimePicker_Now.Value.Year,
                    dateTimePicker_Now.Value.Month,
                    dateTimePicker_Now.Value.Day,
                    Convert.ToInt32(textBox_hh.Text),
                    Convert.ToInt32(textBox_mm.Text),
                    0
                    );
                psc.UDID = new Random().Next(100000000, 999999999);
                psc.dwStart = _.ToBinary();
                double diff = 0D;
                try
                {
                    diff = Math.Round(Convert.ToDouble(domainUpDown_Difficulty.SelectedItem.ToString().Split(' ')[1]), 1);
                }
                catch { diff = 0D; }
                psc.dwDifficulty = diff;
                //封送结构体
                Main.planner = psc;
                Main.AddSign(4);
                Close();
            }
            catch (Exception ex)
            {
                ErrorCenter.AddError(DateTime.Now.ToString(), "Warning", ex);
                MessageBox.Show(ex.Message + "\n这通常是您错误的键入了某个值导致。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCAPTION = 2;

            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键   
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr) HTCAPTION, IntPtr.Zero);// 拖动窗体  
            }
        }

        private void panel_Top_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox_T_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
