using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static StonePlanner.Structs;
using MetroFramework.Forms;

namespace StonePlanner
{
    public partial class AddTodo : MetroForm
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
        public delegate void PlanAddInvoke(Plan plan);
        public Action<int> Addsignal;
        PlanAddInvoke PlanAdditionInvoke;
        public AddTodo(PlanAddInvoke TargetFun,Action<int> Addsignal)
        {
            InitializeComponent();
            PlanAdditionInvoke = new PlanAddInvoke(TargetFun);
            this.Addsignal = Addsignal;
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
            domainUpDown_Difficulty.ReadOnly = true;
            label_T.Text = "新建一个待办";
            metroButton_Submit.Text = "新建待办(&D)";
            textBox_Numbered.ReadOnly = true;
            //Default HH and mm
            //Default MotherFucker
            textBox_hh.Text = DateTime.Now.ToString("HH");
            textBox_mm.Text = DateTime.Now.ToString("mm");
            //难度添加
            for (double i = 0.1; i < 2.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"EASY {i:F1}");
            }
            for (double i = 2.0; i < 4.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"MIDDLE {i:F1}");
            }
            for (double i = 4.0; i < 6.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"HARD {i:F1}");
            }
            for (double i = 6.0; i < 9.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"DESPAIR {i:F1}");
            }
            for (double i = 9.0; i < 10.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"BEYOND {i:F1}");
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
                //WFJsonStructure.DataItem weather;
                //Main.wf.GetWInfo(out weather);
                //if (Convert.ToInt32(weather.air) >= 180)
                //{
                //    //TIPS：今天天气状态良好，可以做想做的事情。
                //    label_Tips.Text = $"TIPS:空气较差（{weather.air}），不建议在外活动。";
                //}
                //else if (Convert.ToInt32(weather.uvIndex) > 6)
                //{
                //    label_Tips.Text = $"TIPS:今日紫外线较强（{weather.uvIndex}），请做好防护。";
                //}
            }
            catch
            {
                //天气预报 not loaded (x)
                //developer should be fucked (√)夜班c
            }
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            try
            {
                //封装类送走
                PlanClassC psc = new PlanClassC();
                psc.capital = textBox_Capital.Text;
                psc.seconds = Convert.ToInt32(textBox_Time.Text);
                psc.intro = textBox_Intro.Text;
                psc.lasting = Convert.ToInt32(textBox_Lasting.Text);
                psc.explosive = Convert.ToInt32(textBox_Explosive.Text);
                psc.wisdom = Convert.ToInt32(textBox_Wisdom.Text);
                psc.parent = comboBox_List.SelectedItem.ToString();
                DateTime _ = new DateTime(
                    dateTimePicker_Now.Value.Year,
                    dateTimePicker_Now.Value.Month,
                    dateTimePicker_Now.Value.Day,
                    Convert.ToInt32(textBox_hh.Text),
                    Convert.ToInt32(textBox_mm.Text),
                    0
                    );
                psc.UDID = new Random().Next(100000000, 999999999);
                psc.startTime = _.ToBinary();
                psc.Addsignal = Addsignal;
                double diff = 0D;
                try
                {
                    diff = Math.Round(Convert.ToDouble(domainUpDown_Difficulty.SelectedItem.ToString().Split(' ')[1]), 1);
                }
                catch { diff = 0D; }
                psc.difficulty = diff;
                //对指针传出
                PlanAdditionInvoke(new Plan(psc));
                Close();
                //封送结构体
                //Main.planner = psc;
                //Main.AddSign(4);
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n这通常是您错误的键入了某个值，或没有输入某个值导致。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void groupBox_Area1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton_Add_Click(object sender, EventArgs e)
        {
            AddList al = new AddList();
            al.Show();
        }
    }
}
