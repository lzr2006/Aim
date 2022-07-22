﻿using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBox_M_Pwd.UseSystemPasswordChar = true;
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            int i = comboBox_M_Type.Text == "Administrator" ? 0 : 1;
            //创建一个恢复用KEY
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[30];
            var random = new Random();
            for (int j = 0; j < Charsarr.Length; j++)
            {
                Charsarr[j] = characters[random.Next(characters.Length)];
            }
            var resultString = new String(Charsarr);
            SQLConnect.SQLCommandExecution($" INSERT INTO Users (Username , Cmoney , Type , Pwd , Rkey) VALUES ('{textBox_M_Name.Text}' , 0 , {i} , '{textBox_M_Pwd.Text}','{resultString}')"/*cmd*/);
            MessageBox.Show($"以下是您的用户恢复密钥：\n{resultString}\n请妥善保管该密钥，您将不会再次看到它了。按确定键复制到剪贴板。");
            Clipboard.SetText(resultString);
            Close();
        }
    }
}
