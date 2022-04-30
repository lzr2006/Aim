using StonePlanner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Finder : Form
    {
        //实现对form1的关联
        InnerIDE mainfrom1;
        public Finder(InnerIDE form1)
        {
            InitializeComponent();
            mainfrom1 = form1;
        }


        private void Finder_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;//默认开启向下查找功能
        }

        int start = 0; int sun = 0; int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            RichTextBox rbox = mainfrom1.rtbMain;
            string str = this.textBox1.Text;
            if (this.checkBox1.Checked)//是否开启区分大小写功能
            {
                this.FindDownM(rbox, str);//向下查找
            }
            else
            {
                if (this.radioButton2.Checked)
                {
                    this.FindDown(rbox, str);
                }
                else
                {
                    this.FindUp(rbox, str);//向上查找
                }
            }
        }

        //替换textBox1中的文本为textBox2中的文本
        private void button2_Click(object sender, EventArgs e)
        {
            string str0 = this.textBox1.Text, str1 = this.textBox2.Text;
            this.replace(str0, str1);
        }

        //全部替换
        private void button3_Click(object sender, EventArgs e)
        {
            RichTextBox rbox = mainfrom1.rtbMain;
            string str0 = this.textBox1.Text, str1 = this.textBox2.Text;
            this.ReplaceAll(rbox, str0, str1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //向上查找函数
        private void FindUp(RichTextBox rbox, string str)
        {
            int rbox1 = rbox.SelectionStart;
            int index = rbox.Find(str, 0, rbox1, RichTextBoxFinds.Reverse);
            if (index > -1)
            {
                rbox.SelectionStart = index;
                rbox.SelectionLength = str.Length;
                sun++;
                rbox.Focus();
            }
            else if (index < 0)
            {
                seeks(str);
                sun = 0;
                // rbox.SelectionStart = rbox.Text.Length;
            }
        }
        private void FindDown(RichTextBox rbox, string str)
        {
            int rbox1 = rbox.Text.Length;
            if (start < rbox1)
            {
                start = rbox.Find(str, start, RichTextBoxFinds.None);
                int los = rbox.SelectionStart + str.Length;
                if ((start < 0) || (start > rbox1))
                {
                    if (count == 0)
                    {
                        this.seeks(str);
                        start = los;
                        sun = 0;
                    }
                    else
                    {
                        this.seeks(str);
                        start = los;
                        sun = 0;
                    }
                }
                else if (start == rbox1 || start < 0)
                {
                    this.seeks(str);
                    start = los;
                    sun = 0;
                }
                else
                {
                    sun++;
                    start = los;
                    rbox.Focus();
                }
            }
            else if (start == rbox1 || start < 0)
            {
                int los = rbox.SelectionStart + str.Length;
                this.seeks(str);
                start = los;
                sun = 0;
            }
            else
            {
                int los = rbox.SelectionStart + str.Length;
                this.seeks(str);
                start = los;
                sun = 0;
            }
        }
        private void FindDownM(RichTextBox rbox, string str)
        {
            int rbox1 = rbox.Text.Length;
            if (start < rbox1)
            {
                start = rbox.Find(str, start, RichTextBoxFinds.MatchCase);
                int los = rbox.SelectionStart + str.Length;
                if ((start < 0) || (start > rbox1))
                {
                    if (count == 0)
                    {
                        this.seeks(str);
                        start = los;
                        sun = 0;
                    }
                    else
                    {
                        this.seeks(str);
                        start = los;
                        sun = 0;
                    }
                }
                else if (start == rbox1 || start < 0)
                {
                    this.seeks(str);
                    start = los;
                    sun = 0;
                }
                else
                {
                    sun++;
                    start = los;
                    rbox.Focus();
                }
            }
            else if (start == rbox1 || start < 0)
            {
                int los = rbox.SelectionStart + str.Length;
                this.seeks(str);
                start = los;
                sun = 0;
            }
            else
            {
                int los = rbox.SelectionStart + str.Length;
                this.seeks(str);
                start = los;
                sun = 0;
            }
        }
        //查找完毕后的弹窗
        private void seeks(string str)
        {
            if (sun != 0)
            {
                MessageBox.Show(string.Format("查找完毕，共[{0}]个\"{1}\"!", sun, str), "查找—温馨提示");
            }
            else
            {
                MessageBox.Show(String.Format("\"{0}\"!", str), "查找—温馨提示");
            }
        }
        //替换全部的函数
        private void ReplaceAll(RichTextBox rbox, string str0, string str1)
        {
            rbox.Text = rbox.Text.Replace(str0, str1);
        }
        private void replace(string str0, string str1)
        {
            RichTextBox rbox = mainfrom1.rtbMain;
            rbox.SelectionLength = str0.Length;
            rbox.SelectedText = str1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
        }
    }
}