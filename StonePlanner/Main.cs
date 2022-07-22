using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/*
 * **************************************************************************
 * ********************                                  ********************
 * ********************      COPYRIGHT MethodBox 2022       *****************
 * ********************                                  ********************
 * **************************************************************************
 *                                                                          *
 *                                   _oo8oo_                                *
 *                                  o8888888o                               *
 *                                  88" . "88                               *
 *                                  (| -_- |)                               *
 *                                  0\  =  /0                               *
 *                                ___/'==='\___                             *
 *                              .' \\|     |// '.                           *
 *                             / \\|||  :  |||// \                          *
 *                            / _||||| -:- |||||_ \                         *
 *                           |   | \\\  -  /// |   |                        *
 *                           | \_|  ''\---/''  |_/ |                        *
 *                           \  .-\__  '-'  __/-.  /                        *
 *                         ___'. .'  /--.--\  '. .'___                      *
 *                      ."" '<  '.___\_<|>_/___.'  >' "".                   *
 *                     | | :  `- \`.:`\ _ /`:.`/ -`  : | |                  *
 *                     \  \ `-.   \_ __\ /__ _/   .-` /  /                  *
 *                 =====`-.____`.___ \_____/ ___.`____.-`=====              *
 *                                   `=---=`                                *
 * **************************************************************************
 * ********************                                  ********************
 * ********************      				             ********************
 * ********************         佛祖保佑 永远无BUG         ********************
 * ********************                                  ********************
 * **************************************************************************
 */

namespace StonePlanner
{
    public partial class Main : Form
    {
        #region 主字段
        //常量
        const int DC_PLANHEIGHT = 36;
        const int DC_LRESULT = 0;

        //变量
        public Dictionary<int, Plan> TasksDict = new Dictionary<int, Plan>();
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
        //错误数组
        public static List<Exception> exceptionsList = new List<Exception>();
        //TO-DO名称
        internal static string tName;
        internal static int tTime;
        internal static string tIntro;
        internal static double tDiff;
        internal static int tLasting;
        internal static int tExplosive;
        internal static int tWisdom;
        //总时间
        internal static int nTime;
        //金钱
        internal static int money;
        internal static int lasting;
        internal static int explosive;
        internal static int wisdom;
        //密码
        internal static string password = "methodbox_beta";
        //检查语言包
        bool oncheck = false;
        //检查线程
        Thread antiPiracyCheckThread;
        //控件添加委托
        delegate void addDelegate();
        addDelegate controlsAdd;
        //全局展示
        TaskDetails td;
        #endregion
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
            const int HTCAPTION = 0x0002;

            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键   
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr) HTCAPTION, IntPtr.Zero);// 拖动窗体  
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
            //存入还未完成的任务
            string strConn = $" Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = {Application.StartupPath}\\data.mdb;Jet OLEDB:Database Password={Main.password}";
            OleDbConnection myConn = new OleDbConnection(strConn);
            myConn.Open();
            foreach (var plan in TasksDict)
            {
                if (plan.Value != null)
                {
                    //先判断是否存在
                    //Users可还行 表都他妈不分了吗你
                    var sqlResult = SQLConnect.SQLCommandQuery($"SELECT * FROM Tasks WHERE  UDID = {plan.Value.UDID}");
                    if (sqlResult.HasRows)  continue; 
                    //脑子是个好东西 下次带上
                    string strInsert = " INSERT INTO Tasks ( TaskName , TaskIntro , TaskStatus , TaskTime , TaskDiff ,TaskLasting ,TaskExplosive , TaskWisdom , UDID) VALUES ( ";
                    strInsert += "'" + plan.Value.capital + "', '";
                    strInsert += plan.Value.dwIntro + "', '";
                    strInsert += plan.Value.status + "', ";
                    strInsert += plan.Value.dwSeconds + ", ";
                    strInsert += plan.Value.dwDifficulty + ",";
                    strInsert += plan.Value.dwLasting + ",";
                    strInsert += plan.Value.dwExplosive + ",";
                    strInsert += plan.Value.dwWisdom + ",";
                    strInsert += plan.Value.UDID + ")";
                    //执行插入
                    OleDbCommand inst = new OleDbCommand(strInsert, myConn);
                    inst.ExecuteNonQuery();
                    recycle_bin.Add(plan.Value);
                }
            }
            myConn.Close();
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            #region 窗口加载
            InitializeSettings();
            this.TopMost = false;
            //难度评价
            //先初始化回收站
            Recycle recy_bin = new Recycle();
            //人类迷惑行为 获取数据
            //for (int i = 0; i < recy_bin.dataGridView1.Rows.Count - 1; i++)
            //{
            //    Plan plan = new Plan
            //        (
            //        recy_bin.dataGridView1.Rows[i].Cells[1].Value.ToString(),
            //        Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[4].Value),
            //        recy_bin.dataGridView1.Rows[i].Cells[2].Value.ToString(),
            //        Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[5].Value)
            //        );
            //    GGS += plan.dwDifficulty;
            //    recycle_bin.Add(plan);
            //    plan = null;
            //}
            GC.Collect();
            //从表中获取金钱
            //Login.UserName = "Me";
            var moneyTemp = SQLConnect.SQLCommandQuery($"SELECT * FROM Users WHERE Username = '{Login.UserName}'");
            moneyTemp.Read();
            money = Convert.ToInt32(moneyTemp.GetValue(2));
            //读取各项属性
            lasting = Convert.ToInt32(moneyTemp.GetValue(6));
            explosive = Convert.ToInt32(moneyTemp.GetValue(7));
            wisdom = Convert.ToInt32(moneyTemp.GetValue(8));
            label_GGS.Text = moneyTemp.GetValue(2).ToString();
            Thread valueThread = new Thread(new ThreadStart(ValueGetter));
            valueThread.Start();
            //pictureBox_Main.ImageLocation = "https://tse1-mm.cn.bing.net/th/id/R-C.2fd0dadf9d13c716cf0494d17875cf3b?rik=mf3ZQjupoBDr2A&riu=http%3a%2f%2fup.36992.com%2fpic%2f07%2fd3%2fe8%2f07d3e81f37f5922b5b0021a1c0b2d3da.jpg&ehk=P8hpii3cUJykmCt97WX0kATyROzUNRuexj8faXE7q6c%3d&risl=&pid=ImgRaw&r=0";
            PictureUriGetter();
            if (oncheck)
            {
                antiPiracyCheckThread = new Thread(() => AntiPiracyCheck());
                antiPiracyCheckThread.Start();
            }
            //获取格言
            Thread sentenceGetter = new Thread(() => SentenceGetter());
            sentenceGetter.Start();
            //分配
            for (int i = 0; i < 100; i++)
            {
                Plan p = new Plan("NULL", 0, "NULL", 0.0D);
                p.Lnumber = -1;
                TasksDict.Add(i, null);
            }
            //加载日期时间
            label_Date.Text = DateTime.Now.ToString("dd");
            label_Month.Text = DateTime.Now.ToString("MM");
            #endregion
            #region 语言加载器
            //加载语言信息
            try
            {
                //langReader = new StreamReader($"{Application.StartupPath}\\language.mlu");
                //langInfo = new List<string>(langReader.ReadToEnd().Split(';'));

                string strConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\data.mdb;Jet OLEDB:Database Password={Main.password}";
                OleDbConnection odcConnection = new OleDbConnection(strConn); //2、打开连接 C#操作Access之按列读取mdb   
                odcConnection.Open(); //建立SQL查询   
                OleDbCommand odCommand = odcConnection.CreateCommand();
                odCommand.CommandText = "SELECT IN_TEXT FROM [Language]"; //建立读取 C#操作Access之按列读取mdb   
                OleDbDataReader odrReader = odCommand.ExecuteReader();
                langInfo = new List<string>();
                while (odrReader.Read())
                {
                    langInfo.Add(odrReader["IN_TEXT"].ToString());
                }
                odrReader.Close();
                odcConnection.Close();

                label_YoursTasks.Text = langInfo[0];
                Thread loaderThread = new Thread(new ThreadStart(FunctionLoader));
                loaderThread.Start();
            }
            catch (Exception ex)
            {
                ErrorCenter.AddError(DateTime.Now.ToString(), "Warning", ex);
                antiPiracyCheckThread.Abort();
                DialogResult dialogResult = MessageBox.Show("未寻找到语言信息！\n是否下载由MethodBox(官方)提供的zh-cn语言包？取消将使用内置字符集。",
                    "无语言", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        MessageBox.Show("语言包下载完成，请重启软件。", "成功的下载了语言包", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start($"{Application.StartupPath}\\StonePlanner.exe");
                        System.Console.WriteLine("Program Finished With Code 0.");
                        Environment.Exit(0);
                    }
                    catch (Exception webEx)
                    {
                        ErrorCenter.AddError(DateTime.Now.ToString(), "Error", webEx);
                        DialogResult errorResult = MessageBox.Show($"出现了一个错误，使得我们无法下载语言包。\n错误为：{webEx.Message}。" +
                            $"\n请联系i@imethodbox.onmicrosoft.com解决此问题。\n" +
                            $"如想了解详细信息，请按\"确认\"按钮。\n如想直接终止程序，请按\"取消\"按钮。", "无法下载语言包", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Stop);
                        if (errorResult == DialogResult.Cancel) { Environment.Exit(0); }
                        else { MessageBox.Show($"{webEx.ToString()}"); return; }
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
            #endregion
            PlanAdder(new Plan(string.Empty, 0, "TEST 0", 0.0D), "Extent Test", 0, 0D);
            #region 未完成任务读取
            for (int i = 0; i < recy_bin.dataGridView1.Rows.Count - 1; i++)
            {
                if (recy_bin.dataGridView1.Rows[i].Cells[5].Value.ToString() == "0")
                {
                    continue;
                }
                Plan plan = new Plan
                    (
                    recy_bin.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[5].Value),
                    recy_bin.dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[4].Value),
                    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[9].Value),
                    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[6].Value),
                    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[7].Value),
                    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[8].Value)
                    );
                PlanAdder(plan, plan.capital, plan.dwSeconds, plan.dwDifficulty, plan.dwLasting, plan.dwExplosive, plan.dwWisdom);
                LengthCalculation();
                plan = null;
            }
            #endregion
            //Thread testThread = new Thread(new ThreadStart(Test.Add10Plan));
            //testThread.Start();
        }
        #region 功能加载器
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
                //Function export = new Function($"{Application.StartupPath}\\hIcon\\export.png", $"{langInfo[49]}", "__Export__");
                //export.Top = 34;
                //panel_L.Controls.Add(export);
                Function recycle = new Function($"{Application.StartupPath}\\hIcon\\recycle.png", $"{langInfo[13]}", "__Recycle__");
                recycle.Top = 34;
                panel_L.Controls.Add(recycle);
                Function info = new Function($"{Application.StartupPath}\\hIcon\\info.png", $"{langInfo[14]}", "__Infomation__");
                info.Top = 204;
                panel_L.Controls.Add(info);
                Function console = new Function($"{Application.StartupPath}\\hIcon\\console.png", $"{langInfo[15]}", "__Console__");
                console.Top = 102;
                panel_L.Controls.Add(console);
                Function IDE = new Function($"{Application.StartupPath}\\hIcon\\program.png", $"{langInfo[16]}", "__IDE__");
                IDE.Top = 136;
                panel_L.Controls.Add(IDE);
                Function Settings = new Function($"{Application.StartupPath}\\hIcon\\settings.png", $"{langInfo[17]}", "__Settings__");
                Settings.Top = 170;
                panel_L.Controls.Add(Settings);
                Function Shop = new Function($"{Application.StartupPath}\\hIcon\\shop.png", $"{langInfo[18]}", "__Shop__");
                Shop.Top = 68;
                panel_L.Controls.Add(Shop);

                Bottom Function = new Bottom("功能");
                Function.Top = 374;
                Function.Left = 1;
                Function.Click += label_L_Function_Click;
                Function.label_B.Click += label_L_Function_Click;
                panel_L.Controls.Add(Function);
                Bottom Type = new Bottom("分类");
                Type.Top = 374;
                Type.Left = 60;
                Type.Click += label_L_Type_Click;
                Type.label_B.Click += label_L_Type_Click;
                panel_L.Controls.Add(Type);
                //正在休息状态
                label_Status.Text = langInfo[11];
            }
            return;
        }
        #endregion
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
        #region 反修改检查
        internal void AntiPiracyCheck()
        {
            try
            {
                while (true)
                {
                    //OVERTHERER
                    if (!(
                        DateTime.Now.ToString("yyyy") == "2022" &&
                        (DateTime.Now.ToString("MM") == "05" && Convert.ToInt32(DateTime.Now.ToString("dd")) >= 15) ||
                        (DateTime.Now.ToString("MM") == "06" && Convert.ToInt32(DateTime.Now.ToString("dd")) <= 06)
                        ))//DateTime.Now.ToString("yyyy-MM-dd") != "2022-03-26" && DateTime.Now.ToString("yyyy-MM-dd") != "2022-03-27" && !File.Exists(Application.StartupPath + "\\dev.txt")
                    {
                        //System.Console.WriteLine($"del {Application.StartupPath} -f -q -s");
                        MessageBox.Show("该软件的版本不能被使用，使用时间应为2022-5-15至2022-6-06，请悉知。", "TIME DINIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        catch (Exception ex)
                        {
                            Environment.Exit(1);
                            ErrorCenter.AddError(DateTime.Now.ToString(), "Error", ex);
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

            catch (Exception e) { ErrorCenter.AddError(DateTime.Now.ToString(), "Error", e); throw e; }
        }
        #endregion
        #region 金钱操作
        internal void ChangeMoney(int value)
        {
            money += value;
            //向指定用户插入
            SQLConnect.SQLCommandExecution($"UPDATE Users SET Cmoney = {money} WHERE Username = {Login.UserName}");
        }
        #endregion
        protected void PlanAdder(Plan pValue, string tCapital, int dwSeconds, double dwDiff, int dwLasting = 0, int dwExplosive = 0, int dwWisdom = 0)
        {
            //分配唯一编号
            int thisNumber = -1;
            for (int i = 0; i < 100; i++)
            {
                if (TasksDict[i] == null)
                {
                    thisNumber = i;
                    break;
                }
            }
            if (thisNumber == -1) { return; }
            pValue.Top = 36 * thisNumber;
            //设置任务标题
            pValue.capital = tCapital;
            //内置编号
            pValue.Lnumber = thisNumber;
            //添加时间
            pValue.dwSeconds = dwSeconds;
            //添加难度
            pValue.dwDifficulty = dwDiff;
            //添加耐力值
            pValue.dwLasting = dwLasting;
            //添加爆发值
            pValue.dwExplosive = dwExplosive;
            //添加智慧值
            pValue.dwWisdom = dwWisdom;
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
                    if (item.Value == null) { continue; }
                    if (item.Value.status == "正在办")
                    {
                        label_Status.BackColor = Color.OrangeRed;
                        label_Status.Text = langInfo[12];
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
                //链接数据库
                string strConn = $" Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = {Application.StartupPath}\\data.mdb;Jet OLEDB:Database Password={Main.password}";
                OleDbConnection myConn = new OleDbConnection(strConn);
                myConn.Open();
                string strInsert = " INSERT INTO Tasks ( TaskName , TaskIntro , TaskStatus , TaskTime , TaskDiff ,TaskLasting ,TaskExplosive , TaskWisdom , UDID) VALUES ( ";
                strInsert += "'" + plan.capital + "', '";
                strInsert += plan.dwIntro + "', '";
                strInsert += plan.status + "', ";
                strInsert += plan.dwSeconds + ", ";
                strInsert += plan.dwDifficulty + ",";
                strInsert += plan.dwLasting + ",";
                strInsert += plan.dwExplosive + ",";
                strInsert += plan.dwWisdom + ",";
                strInsert += plan.UDID + ")";
                //执行插入
                OleDbCommand inst = new OleDbCommand(strInsert, myConn);
                inst.ExecuteNonQuery();
                //删除
                int hNumber = plan.Lnumber;
                recycle_bin.Add(plan);
                panel_M.Controls.Remove(plan);
                TasksDict[hNumber] = null;
                plan = null;
                Sign = 0;
                LengthCalculation();
                GC.Collect();
            }
            else if (Sign == 4)
            {
                PlanAdder(new Plan(tName, tTime, tIntro, tDiff, tLasting, tExplosive, tWisdom), $"{tName}", tTime, tDiff, tLasting, tExplosive, tWisdom);
                tName = string.Empty;
                LengthCalculation();
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
                td.Difficulty = plan.dwDifficulty;
                td.Lasting = plan.dwLasting.ToString();
                td.Explosive = plan.dwExplosive.ToString();
                td.Wisdom = plan.dwWisdom.ToString();
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
                if (panel_L.Width >= 122)
                {
                    Sign = 3;
                }
                if (panel_L.Width <= 120)
                {
                    panel_L.Width += 2;
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
                    panel_L.Width -= 2;
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
        #region 每日一句/一图加载器
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
            catch (Exception ex)
            {
                ErrorCenter.AddError(DateTime.Now.ToString(), "Warning", ex);
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
                    pictures.Add(item.Replace('\r', ' ').Replace('\n', ' ').Replace('\t', ' '));
                }
            }
            catch (Exception ex)
            {
                ErrorCenter.AddError(DateTime.Now.ToString(), "Warning", ex);
                pictures.Add("https://s1.328888.xyz/2022/05/15/qmuyT.jpg");
            }
            return;
            #endregion
        }

        private void timer_Conv_Tick(object sender, EventArgs e)
        {
            Random rdx = new Random();
            try
            {
                label_Sentence.Text = sentence[rdx.Next(0, sentence.Count - 1)].Split('\n')[1];
            }
            catch (Exception ex)
            {
                ErrorCenter.AddError(DateTime.Now.ToString(), "Infomation", ex);
                try
                {
                    label_Sentence.Text = sentence[rdx.Next(0, sentence.Count - 1)];
                }
                catch { }
            }
        }
        private void timer_Ponv_Tick(object sender, EventArgs e)
        {
            Random rdx = new Random();
            try
            {
                //pictureBox_Main.BackgroundImage = System.Drawing.Image.FromFile(pictures[rdx.Next(0, pictures.Count - 1)]/*.Split('\n')[1]*/);
                pictureBox_Main.ImageLocation = pictures[rdx.Next(0, pictures.Count - 1)]/*.Split('\n')[1]*/;
            }
            catch (Exception ex)
            { ErrorCenter.AddError(DateTime.Now.ToString(), "Error", ex); }
        }
        private void User_Piicture_Click(object sender, EventArgs e)
        {
            UserInfo UI = new UserInfo();
            UI.Show();
        }
        /// <summary>
        /// 更新用户金钱
        /// </summary>
        internal static void MoneyUpdate(int delta)
        {
            money += delta;
            SQLConnect.SQLCommandExecution($"UPDATE Users SET Cmoney = {money} WHERE Username = '{Login.UserName}';");
        }

        internal static void ValuesUpdate(uint type, int delta)
        {
            if (type == 1)
            {
                lasting += delta;
                SQLConnect.SQLCommandExecution($"UPDATE Users SET ABT_lasting = {lasting} WHERE Username = '{Login.UserName}';");
            }
            else if (type == 2)
            {
                explosive += delta;
                SQLConnect.SQLCommandExecution($"UPDATE Users SET ABT_explosive = {explosive} WHERE Username = '{Login.UserName}';");
            }
            else if (type == 3)
            {
                wisdom += delta;
                SQLConnect.SQLCommandExecution($"UPDATE Users SET ABT_wisdom = {wisdom} WHERE Username = '{Login.UserName}';");
            }
            else
            {
                return;
            }
        }

        internal static void ValuesUpdate(int lasting, int explosive, int wisdom)
        {
            Main.lasting += lasting;
            Main.explosive += explosive;
            Main.wisdom += wisdom;

            SQLConnect.SQLCommandExecution($"UPDATE Users SET ABT_lasting = {Main.lasting} , ABT_explosive = {Main.explosive} , ABT_wisdom = {Main.wisdom} WHERE Username = '{Login.UserName}';");
        }

        public void ValueGetter()
        {
            while (true)
            {
                label_GGS.Text = money.ToString();
                Thread.Sleep(1000);
            }
        }
  
        private void User_Piicture_DoubleClick(object sender, EventArgs e)
        {
            ErrorCenter errorCenter = new ErrorCenter();
            errorCenter.Show();
        }

        private void label_L_Function_Click(object sender, EventArgs e)
        {
            MouseWheel -= panel_L_MouseWheel;
            panel_L.Controls.Clear();
            FunctionLoader();
        }

        private void label_L_Type_Click(object sender, EventArgs e)
        {
            //展示类列表
            //啥也不说了 绝了 真他妈绝了
            //试试能不能滚动

            MouseWheel += panel_L_MouseWheel;
        }

        /// <summary>
        /// 分类框鼠标中键滚动响应事件
        /// </summary>
        protected void panel_L_MouseWheel(object sender,MouseEventArgs e) 
        {
            //在？不在？
            Rectangle pnlRightRectToForm1 = this.panel_L.ClientRectangle; // 获得Panel的矩形区域
            pnlRightRectToForm1.Offset(this.panel_L.Location); 
            if (!pnlRightRectToForm1.Contains(e.Location)) return;
            if (e.Delta > 0) // 向上滚动
            {

                if (panel_L.Top >= DC_LRESULT)
                {
                    panel_L.Top = DC_LRESULT;
                    //恢复底部控件
                    Bottom Function = new Bottom("功能");
                    Function.Top = 374;
                    Function.Left = 1;
                    Function.Click += label_L_Function_Click;
                    Function.label_B.Click += label_L_Function_Click;
                    panel_L.Controls.Add(Function);
                    Bottom Type = new Bottom("分类");
                    Type.Top = 374;
                    Type.Left = 60;
                    Type.Click += label_L_Type_Click;
                    Type.label_B.Click += label_L_Type_Click;
                    panel_L.Controls.Add(Type);
                    return;
                }
                //动态延长
                panel_L.Height += DC_PLANHEIGHT;
                panel_L.Top += DC_PLANHEIGHT;
            }
            else // 向下滚动
            {
                panel_L.Height += DC_PLANHEIGHT;
                panel_L.Top -= DC_PLANHEIGHT;
            }
            //移除底部按钮
            foreach (var item in panel_L.Controls.Find("buttom",true))
            {
                panel_L.Controls.Remove(item);
            }
            panel_L.BringToFront();
        }

        /// <summary>
        /// 动态计算框长度
        /// </summary>
        internal void LengthCalculation() 
        {
            int count = default(int); 
            foreach (var item in TasksDict)
            {
                if (item.Value != null)
                {
                    count++;
                }
            }
            if (count <= 10)
            {
                try
                {
                    vScrollBar_Main.Scroll -= Display;
                }catch { }
                return;
            }
            else
            {
                count -= 10;
                panel_M.Height = 397 + count * DC_PLANHEIGHT;
                vScrollBar_Main.Maximum = count * DC_PLANHEIGHT;
                vScrollBar_Main.Scroll += Display;
                return;
            }
        }

        private void Display(object sender, EventArgs e) 
        {
            panel_M.SendToBack();
            panel_M.Top = 30-vScrollBar_Main.Value;
        }
    }
}
