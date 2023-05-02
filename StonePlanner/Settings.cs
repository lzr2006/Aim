using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace StonePlanner
{
    public partial class Settings : MetroForm
    {
        internal List<string> packedSettings = new List<string>();
        public Settings()
        {
            //还是将读取设置在这里
            InitializeSettings();
            Main.packedSetting = this.packedSettings;
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel_Main.Top = -vScrollBar_Control.Value - 10;
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
            //2、自提示相关
            if (checkBox_StartSwitch.Checked)
            {
                RegistryKey R_local = Registry.CurrentUser;//RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                R_run.SetValue("AimPlanner", Application.ExecutablePath);
                R_run.Close();
                R_local.Close();
            }
            else
            {
                RegistryKey R_local = Registry.CurrentUser;//RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                R_run.DeleteValue("AimPlanner", false);
                R_run.Close();
                R_local.Close();
            }
            string AutoLoginYesNo = checkBox_LoginSwitch.Checked ? "True" : "False";
            Inner.INIHolder.Write("SwitchSettings", "SentenceSwitch", AutoLoginYesNo, path);
        }


        protected void InitializeSettings() 
        {
            string path = $@"{Application.StartupPath}\settings.ini";
            packedSettings.Add(Inner.INIHolder.Read("SwitchSettings", "PictureSwitch", "False", path));
            packedSettings.Add(Inner.INIHolder.Read("SwitchSettings", "PictureSwitchTime", "False", path));
            packedSettings.Add(Inner.INIHolder.Read("SwitchSettings", "SentenceSwitch", "False", path));
            packedSettings.Add(Inner.INIHolder.Read("SwitchSettings", "SentenceSwitchTime", "False", path));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
