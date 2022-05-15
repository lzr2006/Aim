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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel_Main.Top = -vScrollBar_Control.Value;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //写入
            string path = $@"{Application.StartupPath}\settings.ini";
            //1、切换设置
            string SwitchPicturesYesNo = checkBox_PictureSwitch.Checked ? "True" : "False";
            Inner.INIHolder.Write("SwitchSettings", "PictureSwitch",SwitchPicturesYesNo,path);
            Inner.INIHolder.Write("SwitchSettings", "PictureSwitchTime", textBox_PictureSwitchTime_R.Text, path);
            string SwitchSentencesYesNo = checkBox_PictureSwitch.Checked ? "True" : "False";
            Inner.INIHolder.Write("SwitchSettings", "SentenceSwitch", SwitchSentencesYesNo, path);
            Inner.INIHolder.Write("SwitchSettings", "SentenceSwitchTime", textBox_SentenceSwitchTime_R.Text, path);
        }
    }
}
