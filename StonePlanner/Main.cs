﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Main : Form
    {
        public Dictionary<int,Plan> TasksDict = new Dictionary<int,Plan>();
        //信号
        /*
         * SIGN具体解释
         * SIGN = 1 => 删除任务
         * SIGN = 2 => 伸长菜单栏
         * SIGN = 3 => 缩短菜单栏
         * SIGN = 4 => 新建待办
         * SIGN = 5 => 传出自身对象集合
         * SIGN = 6 => 查看待办信息
         * SIGN = 7 => 关闭待办详情
         */
        internal static int Sign = 0;
        //传出请求删除的请求体对象本身
        internal static Plan plan = null;
        //自己
        Main main;
        //语言数组
        internal static List<string> langInfo;
        internal static List<string> sentence = new List<string>();
        internal static List<string> pictures = new List<string>();
        internal static List<string> packedSetting = new List<string>();
        //废弃任务数组
        public static List<Plan> recycle_bin = new List<Plan>();
        //TO-DO名称
        internal static string tName;
        internal static int tTime;
        internal static string tIntro;
        internal static double tDiff;
        //总时间
        internal static int nTime;
        //检查语言包
        bool oncheck = false;
        //检查线程
        Thread antiPiracyCheckThread;
        //控件添加委托
        delegate void addDelegate();
        addDelegate controlsAdd;
        //全局展示
        TaskDetails td;
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            controlsAdd = new addDelegate(FunctionLoader);
            this.main = this;
            Settings settings = new Settings();
            settings.Dispose();
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
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
        protected void InitializeSettings() 
        {
            if (packedSetting[0] == "True") { timer_Ponv.Enabled = true; } else { timer_Ponv.Enabled = false; }
            timer_Ponv.Interval = Convert.ToInt32(packedSetting[1]);
            if (packedSetting[2] == "True") { timer_Conv.Enabled = true; } else { timer_Conv.Enabled = false; }
            timer_Conv.Interval = Convert.ToInt32(packedSetting[3]);
        }
        private void pictureBox_T_Exit_Click(object sender, EventArgs e)
        {
            //存储
            string allTask = "";
            foreach (var item in recycle_bin)
            {
                allTask += item.capital + ";";
                //allTask += item.dwAim + ";";
                allTask += item.dwSeconds;
                allTask += "\n";
            }
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\TaskMemory.txt",true))
            {
                sw.Write(allTask);
            }
            allTask = null;
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitializeSettings();
            this.TopMost = true;
            string allTask;
            using (StreamReader sr = new StreamReader(Application.StartupPath + @"\TaskMemory.txt"))
            {
                allTask = sr.ReadToEnd();
            }
            string[] taskListString = allTask.Split('\n');
            pictureBox_Main.ImageLocation = "https://tse1-mm.cn.bing.net/th/id/R-C.2fd0dadf9d13c716cf0494d17875cf3b?rik=mf3ZQjupoBDr2A&riu=http%3a%2f%2fup.36992.com%2fpic%2f07%2fd3%2fe8%2f07d3e81f37f5922b5b0021a1c0b2d3da.jpg&ehk=P8hpii3cUJykmCt97WX0kATyROzUNRuexj8faXE7q6c%3d&risl=&pid=ImgRaw&r=0";
            PictureUriGetter();
            taskListString = taskListString.Take(taskListString.Count() - 1).ToArray();
            foreach (var item in taskListString)
            {
                try
                {
                    string[] temp = item.Split(';');
                    Plan plan = new Plan(temp[0], Convert.ToInt32(temp[1]), "LEGACY");
                    recycle_bin.Add(plan);
                }
                catch(Exception ex) { throw ex; }
            }
            //Console.WriteLine(InnerFuncs.GetMD5WithFilePath($"{Application.StartupPath}\\language.mlu"));
            if (oncheck)
            {
                antiPiracyCheckThread = new Thread(() => AntiPiracyCheck());
                antiPiracyCheckThread.Start();
            }
            //获取格言
            Thread sentenceGetter = new Thread(() => SentenceGetter());
            sentenceGetter.Start();
            for (int i = 0; i < 10; i++)
            {
                Plan p = new Plan("NULL",0,"NULL");
                p.Lnumber = -1;
                TasksDict.Add(i, null);
            }
            //加载日期时间
            label_Date.Text = DateTime.Now.ToString("dd");
            label_Month.Text = DateTime.Now.ToString("MM");
            //加载语言信息
            StreamReader langReader;
            try
            {
                langReader = new StreamReader($"{Application.StartupPath}\\language.mlu");
                langInfo = new List<string>(langReader.ReadToEnd().Split(';'));
                label_YoursTasks.Text = langInfo[0];
                langReader.Close();
                Thread loaderThread = new Thread(new ThreadStart(FunctionLoader));
                loaderThread.Start();
            }
            catch{
                antiPiracyCheckThread.Abort();
                DialogResult dialogResult = MessageBox.Show("未寻找到语言信息！\n是否下载由MethodBox(官方)提供的zh-cn语言包？取消将使用内置字符集。",
                    "无语言",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                //下载语言包
                if (dialogResult == DialogResult.Yes) 
                {
                    try
                    {
                        WebClient MyWebClient = new WebClient();
                        MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                        Byte[] pageData = MyWebClient.DownloadData("https://lzr2006.github.io/wkgd/Services/StonePlanner/language.txt"); //下载
                        //string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            
                        string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                        using (StreamWriter sw = new StreamWriter($"{Application.StartupPath}\\language.mlu"))//将获取的内容写入文本
                        {
                            sw.Write(pageHtml);
                            sw.Close();
                        }
                        MessageBox.Show("语言包下载完成，请重启软件。","成功的下载了语言包",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start($"{Application.StartupPath}\\StonePlanner.exe");
                        System.Console.WriteLine("Program Finished With Code 0.");
                        Environment.Exit(0);
                    }
                    catch (Exception webEx)
                    {
                        DialogResult errorResult =  MessageBox.Show($"出现了一个错误，使得我们无法下载语言包。\n错误为：{webEx.Message}。" +
                            $"\n请联系i@imethodbox.onmicrosoft.com解决此问题。\n" +
                            $"如想了解详细信息，请按\"确认\"按钮。\n如想直接终止程序，请按\"取消\"按钮。","无法下载语言包",MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Stop);
                        if (errorResult == DialogResult.Cancel) {Environment.Exit(0);}
                        else { MessageBox.Show($"{webEx.ToString()}");return; }
                    }
                    Thread loaderThread = new Thread(new ThreadStart(FunctionLoader));
                    loaderThread.Start();
                }
                else
                {
                    //不下载语言包
                    //生成一堆乱码应付一下，以免程序报废
                    Thread tdHolder = new Thread(() => languageHolder());
                    tdHolder.Start();
                    Thread.Sleep(1000);
                    Thread loaderThread = new Thread(new ThreadStart(FunctionLoader));
                    tdHolder.Join();
                    loaderThread.Start();
                }
            }
            PlanAdder(new Plan(string.Empty,0,"TEST 0"), "Extent Test",0,0D);
        }

        protected void FunctionLoader() 
        {
            //加载功能 34高
            if (main.InvokeRequired)
            {
                main.Invoke(controlsAdd);
            }
            else
            {
                Function newTodo = new Function($"{Application.StartupPath}\\hIcon\\new.png", $"{langInfo[2]}", "__New__");
                newTodo.Top = 0;
                panel_L.Controls.Add(newTodo);
                Function export = new Function($"{Application.StartupPath}\\hIcon\\export.png", $"{langInfo[7]}", "__Export__");
                export.Top = 34;
                panel_L.Controls.Add(export);
                Function recycle = new Function($"{Application.StartupPath}\\hIcon\\recycle.png", $"{langInfo[14]}", "__Recycle__");
                recycle.Top = 68;
                panel_L.Controls.Add(recycle);
                Function info = new Function($"{Application.StartupPath}\\hIcon\\info.png", $"{langInfo[15]}", "__Infomation__");
                info.Top = 102;
                panel_L.Controls.Add(info);
                Function console = new Function($"{Application.StartupPath}\\hIcon\\console.png", $"{langInfo[16]}", "__Console__");
                console.Top = 136;
                panel_L.Controls.Add(console);
                Function IDE = new Function($"{Application.StartupPath}\\hIcon\\program.png", $"{langInfo[17]}", "__IDE__");
                IDE.Top = 170;
                panel_L.Controls.Add(IDE);
                Function Settings = new Function($"{Application.StartupPath}\\hIcon\\settings.png", $"{langInfo[18]}", "__Settings__");
                Settings.Top = 204;
                panel_L.Controls.Add(Settings);
                //正在休息状态
                label_Status.Text = langInfo[12];
            }
            return;
        }

        internal void languageHolder() 
        {
            langInfo = new List<string>();
            for (int i = 0; i < 30; i++)
            {
                langInfo.Add(null);
                for (int j = 0; j < 4; j++)
                {
                    langInfo[i] += Inner.InnerFuncs.GenerateChineseWords(1)[0];
                    Thread.Sleep(1);
                }
            }
        }
        internal void AntiPiracyCheck() 
        {
            try
            {
                while (true)
                {
                    //OVERTHERER
                    if (!(
                        DateTime.Now.ToString("yyyy") == "2022"&&
                        (DateTime.Now.ToString("MM") == "05" && Convert.ToInt32(DateTime.Now.ToString("dd")) >= 15) ||
                        (DateTime.Now.ToString("MM") == "06" && Convert.ToInt32(DateTime.Now.ToString("dd")) <= 06)
                        ))//DateTime.Now.ToString("yyyy-MM-dd") != "2022-03-26" && DateTime.Now.ToString("yyyy-MM-dd") != "2022-03-27" && !File.Exists(Application.StartupPath + "\\dev.txt")
                    {
                        //System.Console.WriteLine($"del {Application.StartupPath} -f -q -s");
                        MessageBox.Show("该软件的版本不能被使用，使用时间应为2022-5-15至2022-6-06，请悉知。","TIME DINIED",MessageBoxButtons.OK,MessageBoxIcon.Information);
                      //  Inner.InnerFuncs.CmdExecuter.RunCmd($"del {Application.StartupPath} -f -q -s");
                        File.Delete(Application.StartupPath + "\\");
                        Environment.Exit(1);
                    }
                    WebClient MyWebClient = new WebClient();
                    MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                    Byte[] pageData = MyWebClient.DownloadData("https://lzr2006.github.io/wkgd/Services/StonePlanner/language.txt"); //下载                                                                                            //string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            
                    string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                    StreamReader sr = new StreamReader($"{Application.StartupPath}\\language.mlu");
                    string localLanguage = sr.ReadToEnd();
                    sr.Close();
                    if (localLanguage != pageHtml)
                    {
                        try
                        {
                            string fileName = $"{Application.StartupPath}\\language.mlu";//要检查被那个进程占用的文件 
                            File.Delete(fileName);
                            System.Diagnostics.Process.Start($"{Application.StartupPath}\\StonePlanner.exe");
                            System.Console.WriteLine("Program Finished With Code 0.");
                            Environment.Exit(0);
                        }
                        catch
                        {
                            Environment.Exit(1);
                        }
                        using (StreamWriter sw = new StreamWriter($"{Application.StartupPath}\\language.mlu"))//将获取的内容写入文本
                        {
                            sw.Write(pageHtml);
                            sw.Flush();
                            sw.Close();
                        }

                    }
                    Thread.Sleep(10000);
                }
                //检查语言包
            }

            catch(Exception e) { throw e; }
        }
        protected void PlanAdder(Plan pValue,string tCapital,int dwSeconds,double dwDiff) 
        {
            //分配唯一编号
            int thisNumber = -1;
            for (int i = 0; i < 10; i++)
            {
                if (TasksDict[i] == null)
                {
                    thisNumber = i;
                    break;
                }
            }if(thisNumber == -1) { return; }
            pValue.Top = 36 * thisNumber;
            //设置任务标题
            pValue.capital = tCapital;
            //内置编号
            pValue.Lnumber = thisNumber;
            //添加时间
            pValue.dwSeconds = dwSeconds;
            //添加难度
            pValue.dwDifficuly = dwDiff;
            //添加到字典
            TasksDict[thisNumber] = pValue;
            panel_M.Controls.Add(pValue);
        }

        private void timer_EventHandler_Tick(object sender, EventArgs e)
        {
            //监测工作状态
            if (true)
            {
                foreach (var item in TasksDict)
                {
                    if (item.Value == null){continue;}
                    if (item.Value.status == "正在办")
                    {
                        label_Status.BackColor = Color.OrangeRed;
                        label_Status.Text = langInfo[13];
                        break;
                    }
                    else 
                    {
                        label_Status.BackColor = Color.Lime;
                        label_Status.Text = langInfo[12];
                    }
                }
            }
            //获取并回显时间
            nTime = 0;
            foreach (var item in TasksDict)
            {
                if (item.Value == null) { continue; }
                nTime += item.Value.dwSeconds;
            }
            label_NeedTime.Text = "剩余" + Inner.InnerFuncs.SecToHms(nTime);

            //事件处理集（EHS）
            if (Sign == 1)
            {
                int hNumber = plan.Lnumber;
                recycle_bin.Add(plan);
                panel_M.Controls.Remove(plan);
                TasksDict[hNumber] = null;
                plan = null;
                Sign = 0;
            }
            else if (Sign == 4)
            {
                PlanAdder(new Plan(tName, tTime,tIntro), $"{tName}",tTime,tDiff);
                tName = string.Empty;
                Sign = 0;
            }
            else if (Sign == 6)
            {
                panel_TaskDetail.Controls.Remove(td);
                td = new TaskDetails();
                td.Left = 16;
                td.Top = 20;
                td.Capital = plan.capital;
                td.Time = plan.dwSeconds.ToString();
                td.Intro = plan.dwIntro;
                td.StatusResult = plan.status;
                td.Difficulty = plan.dwDifficuly;
                SoundPlayer sp = new SoundPlayer($@"{Application.StartupPath}\hIcon\Click.wav");
                sp.Play();
                panel_TaskDetail.Controls.Add(td);
                td.BringToFront();
                Sign = 0;
            }
            else if (Sign == 7)
            {
                panel_TaskDetail.Controls.Remove(td);
                Sign = 0;
                SoundPlayer sp = new SoundPlayer($@"{Application.StartupPath}\hIcon\Click.wav");
                sp.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // PlanAdder(new Plan(string.Empty,0,"TESTＩＩ"), "Test StringII",0);
        }

        private void timer_PenalLengthController_Tick(object sender, EventArgs e)
        {
            if (Sign == 2) 
            {
                if (panel_L.Width <= 120)
                {
                    panel_L.Width++;
                }
                else 
                {
                    Sign = 0;
                }
            }
            else if (Sign == 3)
            {
                if (panel_L.Width > 0)
                {
                    panel_L.Width--;
                }
                else
                {
                    Sign = 0;
                }
            }
            else if (Sign == 5)
            {
                ExportTodo et = new ExportTodo(panel_M.Controls);
                et.Show();
                Sign = 0;
            }
        }

        private void pictureBox_T_More_Click(object sender, EventArgs e)
        {
            if (Sign == 0)
            {
                if (panel_L.Width == 0)
                {
                    Sign = 2;
                }
                else
                {
                    Sign = 3;
                }
            }
        }
        public void SentenceGetter() 
        {
            try
            {
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData("https://lzr2006.github.io/wkgd/Services/StonePlanner/sentence.txt"); //下载                                                                                            //string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            
                string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                foreach (var item in pageHtml.Split(';'))
                {
                    sentence.Add(item);
                }
            }
            catch
            {
                sentence.Add("浪费时间叫虚度，剥用时间叫生活。");
            }
            return;
        }
        public void PictureUriGetter() 
        {
            try
            {
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData("https://lzr2006.github.io/wkgd/Services/StonePlanner/picture.txt"); //下载
                string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                foreach (var item in pageHtml.Split('\n'))
                {
                    pictures.Add(item.Replace('\r',' ').Replace('\n',' ').Replace('\t',' '));
                }
            }
            catch 
            {
                pictures.Add("https://s1.328888.xyz/2022/05/15/qmuyT.jpg");
            }
            return;
        }

        private void timer_Conv_Tick(object sender, EventArgs e)
        {
            Random rdx = new Random();
            try 
            {
                label_Sentence.Text = sentence[rdx.Next(0, sentence.Count - 1)].Split('\n')[1];
            }
            catch 
            {
                try
                {
                    label_Sentence.Text = sentence[rdx.Next(0, sentence.Count - 1)];
                }
                catch { }
            }
        }
        private void panel_TaskDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Ponv_Tick(object sender, EventArgs e)
        {
            Random rdx = new Random();
            try
            {
                //pictureBox_Main.BackgroundImage = System.Drawing.Image.FromFile(pictures[rdx.Next(0, pictures.Count - 1)]/*.Split('\n')[1]*/);
                pictureBox_Main.ImageLocation = pictures[rdx.Next(0, pictures.Count - 1)]/*.Split('\n')[1]*/;
            }
            catch
            {  }
        }
    }
}
