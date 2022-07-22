using Microsoft.AppCenter.Crashes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Console : Form
    {
        //INT类型存储器 多步执行布尔存储器
        internal int EPH,KDP = 0;
        public Console()
        {
            InitializeComponent();
        }

        private void Console_Load(object sender, EventArgs e)
        {
            richTextBox_Output.ReadOnly = true;
            textBox_Pars.Visible = false;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        // 返回搜索字符
        public static string GetLastWord(string str, int i)
        {
            string x = str;
            Regex reg = new Regex(@"\S+[a-z]+\S*|[a-z]+\S*|\S+[a-z]*", RegexOptions.RightToLeft);
            x = reg.Match(x).Value;
            Regex reg2 = new Regex(@"\s");
            x = reg2.Replace(x, "");
            return x;
        }

        //关键字集
        public static List<string> AllClass()
        {
            List<string> list = new List<string>();
            list.Add("EXIT");
            list.Add("SLEEP");
            list.Add("SET");
            list.Add("ADD");
            list.Add("SIGN");
            list.Add("COMPILE");
            return list;
        }
        protected List<List<string>> rx = new List<List<string>>(); int rw = 0;
        #region 语法解析器
        protected void SyntaxParser(string row,int dwStatus = 0)
        {
            try
            {
                List<string> nInput = new List<string>();
                if (dwStatus == 0)
                {
                    richTextBox_Output.Text += $"\nlocal@user>{row}";
                }
                richTextBox_Input.Text = string.Empty;
                //语法解析
                Regex parser = new Regex(@"\S+[a-z]+\S*|[a-z]+\S*|\S+[a-z]*");
                MatchCollection result = parser.Matches(row);
                foreach (var item in result)
                {
                    nInput.Add(item.ToString());
                }
                //识别
                //方式：顺序识别
                //IDE多步语法解析器
                #region FOR
                if (nInput[0] == "END")
                {
                    rw = 0;
                    for (int i = 0; i < KDP; i++)
                    {
                        foreach (var item in rx)
                        {
                            string tempRow = "";
                            int j = 0;
                            foreach (var txt in item)
                            {
                                if (j != 0) tempRow += " ";
                                tempRow += txt;
                                j++;
                            }
                            //提前更新一下吧...
                            tempRow = tempRow.Replace("[EPH]", EPH.ToString());
                            SyntaxParser(tempRow, 0);
                            Thread.Sleep(100);
                        }

                    }
                }
                if (rw != 0)
                {
                    rx.Add(nInput);//COMPILE .\A.TXT
                    return;
                }
                if (nInput[0] == "REPEAT" && dwStatus == 1)
                {
                    if (KDP == 0)
                    {
                        //执行循环
                        KDP = Convert.ToInt32(nInput[1]);
                        rw = 1;
                        return;
                    }
                }
                #endregion
                //IDE普通命令解析器
                try
                {
                    //休眠命令
                    if (nInput[0] == "SLEEP")
                    {
                        if (nInput[1] != "EPH")
                        {
                            Thread.Sleep(Convert.ToInt32(nInput[1]));
                            richTextBox_Output.Text += $"\nConsole@Enviroment>休眠{nInput[1]}毫秒。";
                        }
                        else
                        {
                            Thread.Sleep(EPH);
                            richTextBox_Output.Text += $"\nConsole@Enviroment>休眠{EPH}毫秒。";
                        }
                    }
                    else if (nInput[0] == "SET")
                    {
                        ArrayList arraySet = new ArrayList();
                        arraySet.AddRange(nInput);
                        if (arraySet[1].ToString() == "EPH")
                        {
                            //整数型赋值
                            EPH = Convert.ToInt32(arraySet[2]);
                            richTextBox_Output.Text += $"\nConsole@Memory>将{arraySet[2]}设置到整数存储器。";
                        }
                        else
                        {
                            richTextBox_Output.Text += $"\nMemoryNotExistException：未找到该存储器";
                            try
                            {
                                throw new Exceptions.MethodNotExistException("MemoryNotExistException：未找到该存储器。");
                            }
                            catch (Exception ex)
                            {
                                System.Console.WriteLine("MemoryNotExistException：未找到该存储器。");
                                //发送错误报告
                                var properties = new Dictionary<string, string>
                            {
                                {"Display" , $"SyntaxError：{ex.Message}" }
                            };
                                string code = "";
                                foreach (var item in nInput)
                                {
                                    code += item + " ";
                                }
                                properties.Add("Code", code);
                                Crashes.TrackError(ex, properties);
                            }
                        }
                    }
                    else if (nInput[0].StartsWith("EPH"))
                    {
                        //存储器操作
                        if (nInput[0] == "EPH+")
                        {
                            EPH += Convert.ToInt32(nInput[1]);
                        }
                        else if (nInput[0] == "EPH-")
                        {
                            EPH -= Convert.ToInt32(nInput[1]);
                        }
                        else if (nInput[0] == "EPH*")
                        {
                            EPH *= Convert.ToInt32(nInput[1]);
                        }
                        else if (nInput[0] == "EPH/")
                        {
                            EPH /= Convert.ToInt32(nInput[1]);
                        }
                        else
                        {
                            try
                            {
                                throw new Exceptions.MethodNotExistException("MethodNotExistError：存储器EPH不存在该操作。");
                            }
                            catch (Exception ex)
                            {
                                System.Console.WriteLine("MethodNotExistError：存储器EPH不存在该操作。");

                                //发送错误报告
                                var properties = new Dictionary<string, string>
                            {
                                {"code" , $"{richTextBox_Output.Text}" },
                                {"display" , $"SyntaxError：{ex.Message}" }
                            };
                                Crashes.TrackError(ex, properties);
                                richTextBox_Output.Text += $"\nSyntaxError：{ex.Message}";
                            }
                        }
                        richTextBox_Output.Text += $"\nConsole@Memory>EPH：{EPH.ToString()}";
                    }
                    else if (nInput[0] == "ADD")
                    {
                        //打开信号接口
                        Main.Sign = 4;
                        if (dwStatus != 1)
                        {
                            if (nInput[1].Contains("[EPH]"))
                            {
                                nInput[1] = nInput[1].Replace("[EPH]", EPH.ToString());
                            }
                            if (nInput[2].Contains("[EPH]"))
                            {
                                nInput[2] = nInput[2].Replace("[EPH]", EPH.ToString());
                            }
                        }
                        Main.tName = nInput[1];
                        Main.tTime = Convert.ToInt32(nInput[2]);
                        richTextBox_Output.Text += $"\nConsole@Main>Main：添加任务{nInput[1]}，时长{nInput[2]}。";
                    }
                    else if (nInput[0] == "COMPILE")
                    {
                        nInput[1] = nInput[1].Replace(@".\", Application.StartupPath + @"\");
                        try
                        {
                            using (StreamReader sr = new StreamReader(nInput[1]))
                            {
                                textBox_Pars.Text = sr.ReadToEnd().Trim();
                            }
                            richTextBox_Output.Text += $"\nConsole@Main>Main：开始编译解析{nInput[1]}。";
                            //开新线程解析语法
                            Thread threadCompile = new Thread(new ThreadStart(Compile));
                            threadCompile.Start();
                        }
                        catch { richTextBox_Output.Text += $"\nFileNotExistError：指定文件不存在。"; }

                    }
                    else if (nInput[0] == "SIGN")
                    {
                        if (nInput[1] == "HELP")
                        {
                            richTextBox_Output.Text += "\nConsole@Main>信 号 规 范：";
                            richTextBox_Output.Text += "\n|SIGN = 1 => 删除任务";
                            richTextBox_Output.Text += "\n|SIGN = 2 => 伸长菜单栏";
                            richTextBox_Output.Text += "\n|SIGN = 3 => 缩短菜单栏";
                            richTextBox_Output.Text += "\n|SIGN = 4 => 新建待办";
                            richTextBox_Output.Text += "\n|SIGN = 5 => 传出自身对象集合";
                            richTextBox_Output.Text += "\n|SIGN = 6 => 查看待办信息";
                            richTextBox_Output.Text += "\n|SIGN = 7 => 关闭待办详情";
                            richTextBox_Output.Text += "\nConsole@Main>请注意：错误的使用信号将导致崩溃";
                        }
                        else
                        {
                            try
                            {
                                int signal = Convert.ToInt32(nInput[1]);
                                Main.Sign = signal;
                                richTextBox_Output.Text += $"\nConsole@Poster>成功：将{signal}信号发送到主窗口。";
                            }
                            catch (Exception ex)
                            {
                                //发送错误报告
                                var properties = new Dictionary<string, string>
                            {
                                {"code" , $"{richTextBox_Output.Text}" },
                                {"display" , $"SyntaxError：{ex.Message}" }
                            };
                                Crashes.TrackError(ex, properties);
                                richTextBox_Output.Text += $"\nSyntaxError：{ex.Message}";
                            }
                        }
                    }
                    else if (nInput[0] == "EXIT")
                    {
                        richTextBox_Output.Text = "";
                        Thread tdExit = new Thread(new ThreadStart(EXIT));
                        tdExit.Start();
                    }
                }
                catch (Exception ex)
                {
                    //发送错误报告
                    var properties = new Dictionary<string, string>
                {
                    {"code" , $"{richTextBox_Output.Text}" },
                    {"display" , $"SyntaxError：{ex.Message}" }
                };
                    Crashes.TrackError(ex, properties);
                    richTextBox_Output.Text += $"\nSyntaxError：{ex.Message}";
                }
            }
            catch(Exception ex) { ErrorCenter.AddError(DateTime.Now.ToString(), "Error", ex); }
        }
        #endregion
        protected void Compile() 
        {
            string[] command = textBox_Pars.Text.Trim().Split('\n');
            foreach (var item in command)
            {
                richTextBox_Output.Text += $"\nConsole@Compiler>{item}";
                SyntaxParser(item,1);
                Thread.Sleep(1000);
            }
            richTextBox_Output.Text += $"\nConsole@Compiler>编译解析完成。";
        } 
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //命令执行
            if (e.KeyCode == Keys.Enter)
            {
                if (Login.UserType == 1)
                {
                    MessageBox.Show("语法解析运行时权限拒绝：非管理员用户无权运行命令。", "用户系统（测试）", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SyntaxParser(richTextBox_Input.Text);
            }
            RichTextBox rich = (RichTextBox)sender;

            //语法高亮
            string s = GetLastWord(rich.Text, rich.SelectionStart);
            if (AllClass().IndexOf(s) > -1)
            {
                MySelect(rich, rich.SelectionStart, s, Color.CadetBlue, true);
            }

            //语法提示
            RichTextBox tb = (RichTextBox)sender;
            if (checkBox1.Checked)
            {
                //搜索ListBox是否已经被创建
                Control[] c = tb.Controls.Find("mylb", false);
                if (c.Length > 0)
                    ((ListBox)c[0]).Dispose();  //如果被创建则释放

                ListBox lb = new ListBox();
                lb.Name = "mylb";
                foreach (var item in AllClass())
                {
                    lb.Items.Add(item);
                }
                lb.Show();
                lb.TabIndex = 100;
                lb.Location = tb.GetPositionFromCharIndex(tb.SelectionStart);
                lb.Left += 10;
                tb.Controls.Add(lb);
            }
        }

        // 设定颜色
        public static void MySelect(System.Windows.Forms.RichTextBox tb, int i, string s, Color c, bool font)
        {
            try
            {
                tb.Select(i - s.Length, s.Length);
                tb.SelectionColor = c;
                //以下是把光标放到原来位置，并把光标后输入的文字重置
                tb.Select(i, 0);
                tb.SelectionFont = new Font(" 宋体 ", 12, (FontStyle.Regular));
                tb.SelectionColor = Color.Black;
            }
            catch { }
        }

        #region 功能函数
        internal void EXIT()
        {
            richTextBox_Output.Text += $"Console@Clear>正在准备退出...";
            for (int i = 0; i < 4; i++)
            {
                richTextBox_Output.Text += $"\n";
                Random random = new Random();
                for (int j = 0; j < 7; j++)
                {
                    if (j != 0)
                    {
                        richTextBox_Output.Text += $"  {random.Next(10, 90)}";
                    }
                    else
                    {
                        richTextBox_Output.Text += $"Ln-{i}：{random.Next(10, 90)}";
                    }
                    Thread.Sleep(150);
                }
            }
            for (int i = 5; i > 0; i--)
            {
                richTextBox_Output.Text = "";
                richTextBox_Output.Text += $"Console@Enviroment>指令收到，{i}秒后退出。";
                Thread.Sleep(1000);
            }
            Environment.Exit(0);
        }
        #endregion

        private void richTextBox_Output_TextChanged(object sender, EventArgs e)
        {
            richTextBox_Output.SelectionStart = richTextBox_Output.Text.Length; //Set the current caret position at the end
            richTextBox_Output.ScrollToCaret(); //Now scroll it automatically
        }

        private void richTextBox_Input_Click(object sender, EventArgs e)
        {
            RichTextBox tb = (RichTextBox)sender;
            Control[] c = tb.Controls.Find("mylb", false);
            if (c.Length > 0)
                ((ListBox)c[0]).Dispose();
        }
    }
}
