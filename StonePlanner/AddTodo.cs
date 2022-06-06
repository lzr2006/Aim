using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void AddTodo_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            label_T.Text = Main.langInfo[3];
            label_TodoName.Text = Main.langInfo[4];
            label_Numbered.Text = Main.langInfo[5];
            button_New.Text = Main.langInfo[6];
            textBox_Numbered.ReadOnly = true;

            //难度添加
            for (double i = 0.1; i < 2.0; i+=0.1)
            {
                domainUpDown_Difficulty.Items.Add($"EASY {i}");
            }
            for (double i = 2.1; i < 4.0; i += 0.1)
            {
                domainUpDown_Difficulty.Items.Add($"MIDDLE {i}");
            }
            for(double i = 4.1; i < 6.0; i += 0.1)
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
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            try
            {
                Main.Sign = 4;
                Main.tName = textBox_Capital.Text;
                Main.tTime = Convert.ToInt32(textBox_Time.Text);
                Main.tIntro = textBox_Intro.Text;
                double diff = Math.Round(Convert.ToDouble(domainUpDown_Difficulty.SelectedItem.ToString().Split(' ')[1]),1);
                Main.tDiff = diff;
                Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCAPTION = 2;

            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键   
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);// 拖动窗体  
            }
        }

        private void panel_Top_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
