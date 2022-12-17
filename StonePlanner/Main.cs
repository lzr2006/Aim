using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static StonePlanner.Structs;
using static StonePlanner.Develop.Sign;

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
        internal static Queue<int> signQueue = new Queue<int>();
        //传出请求删除的请求体对象本身
        internal static Plan plan = null;
        //自己
        Main main;
        //语言数组
        internal static List<string> langInfo;
        internal static List<string> sentence = new List<string>();
        internal static List<string> pictures = new List<string>();
        internal static List<string> packedSetting = new List<string>();
        internal static List<string> nownn = new List<string>();
        //废弃任务数组
        public static List<Plan> recycle_bin = new List<Plan>();
        //错误数组
        public static List<Exception> exceptionsList = new List<Exception>();
        //TO-DO名称
        //internal static string tName;
        //internal static int tTime;
        //internal static string tIntro;
        //internal static double tDiff;
        //internal static int tLasting;
        //internal static int tExplosive;
        //internal static int tWisdom;
        //internal static string tParent;
        //TO-DO
        internal static PlanClassC planner; //It is a void*
        //总时间
        internal static int nTime;
        //金钱
        internal static int money;
        internal static int lasting;
        internal static int explosive;
        internal static int wisdom;
        //密码
        internal static string password = "methodbox5";
        //检查语言包
        bool oncheck = false;
        internal static bool activation = false;
        internal static bool banned = false;
        //检查线程
        Thread antiPiracyCheckThread;
        //控件添加委托
        delegate void addDelegate();
        addDelegate controlsAdd;
        //全局展示
        TaskDetails td;
        //天气预报
        //internal static WeatherForecast wf = new WeatherForecast();
        //数据库查询
        internal static OleDbConnection odcConnection = new OleDbConnection();
        #endregion
        public static DateTime tStart;

        /// <summary>
        /// 主窗口构造函数，基本用途如下：
        /// 1、加载控件（自动生成）；
        /// 2、把自己赋值给自身的<code>main</code>变量；
        /// 3、取消跨线程操作检查；
        /// 4、提前加载设置窗口，以便于后期读取设置。
        /// </summary>
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            controlsAdd = new addDelegate(FunctionLoader);
            this.main = this;
            Settings settings = new Settings();
            label_XHDL.Parent = pictureBox_Main;
            settings.Dispose();
            //在这里检查激活，别问我为什么？
            var hresult = SQLConnect.SQLCommandQuery($"SELECT * FROM Users WHERE Username = 'mactivation'");
            hresult.Read();
            string code = hresult[4] as string;
            if (code == "Banned")
            {
                banned = true;
            }
            if (StonePlanner.License.Code.codes.Contains(code))
            {
                activation = true;
            }
            else
            {
                activation = false;
            }
        }
        /// <summary>
        /// 该函数用来发送Windows消息（WM）处理窗口拖动事件。
        /// </summary>
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        /// <summary>
        /// 该函数从当前线程中的窗口释放鼠标捕获，并恢复通常的鼠标输入处理。
        /// </summary>
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
        /// <summary>
        /// 该函数将拖动事件发送，以用于拖动窗口。
        /// </summary>
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
        //string message = string.Format("收到自己消息的参数:{0},{1}", m.WParam, m.LParam);
        /// <summary>
        /// 该函数用于加载基本的设置项。
        /// </summary>
        protected void InitializeSettings()
        {
            try
            {
                if (packedSetting[0] == "True") { timer_Ponv.Enabled = true; } else { timer_Ponv.Enabled = false; }
                timer_Ponv.Interval = Convert.ToInt32(packedSetting[1]);
                if (packedSetting[2] == "True") { timer_Conv.Enabled = true; } else { timer_Conv.Enabled = false; }
                timer_Conv.Interval = Convert.ToInt32(packedSetting[3]);
            }
            catch 
            {
                timer_Ponv.Enabled = true;
                timer_Conv.Enabled = true;
            }
        }
        /// <summary>
        /// 覆写窗体的消息处理函数
        /// </summary>
        /// <param name="m">消息</param>
        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case AM_EXIT:
                    Environment.Exit(0);
                    break;
                case AM_ADDMONEY:
                    MoneyUpdate(m.WParam.ToInt32());
                    break;
                //调用基类函数，以便系统处理其它消息。
                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }
        protected void TaskTimeScan() 
        {
            List<string> _tasks = new List<string>();
            foreach (var item in panel_M.Controls)
            {
                Plan temp;
                if (item is not Plan)
                {
                    continue;
                }
                else
                {
                    temp = item as Plan;
                }
                if (temp.status != "正在办")
                {
                    if (DateTime.Now >= temp.dtStartTime)
                    {
                        _tasks.Add(temp.capital);
                    }
                }
            }
            if (_tasks.Count != 0)
            {
                new Alert(_tasks).ShowDialog();
            }
            _tasks.Clear();
            Thread.Sleep(60000);
        }
        /// <summary>
        /// 该函数处理用户退出事件，存入新的还未存储的数据。
        /// </summary>
        private void pictureBox_T_Exit_Click(object sender, EventArgs e)
        {
            //存入还未完成的任务
            foreach (var plan in TasksDict)
            {
                if (plan.Value != null)
                {
                    //先判断是否存在
                    //Users可还行 表都他妈不分了吗你
                    var sqlResult = SQLConnect.SQLCommandQuery($"SELECT * FROM Tasks WHERE UDID = {plan.Value.UDID}",ref Main.odcConnection);
                    if (sqlResult.HasRows) continue;
                    //脑子是个好东西 下次带上
                    string strInsert = "INSERT INTO Tasks ( TaskName , TaskIntro , TaskStatus , TaskTime , TaskDiff ,TaskLasting ,TaskExplosive , TaskWisdom , UDID , TaskParent , StartTime) VALUES ( ";
                    strInsert += "'" + plan.Value.capital + "', '";
                    strInsert += plan.Value.dwIntro + "', '";
                    strInsert += plan.Value.status + "', ";
                    strInsert += plan.Value.dwSeconds + ", ";
                    strInsert += plan.Value.dwDifficulty + ",";
                    strInsert += plan.Value.dwLasting + ",";
                    strInsert += plan.Value.dwExplosive + ",";
                    strInsert += plan.Value.dwWisdom + ",";
                    strInsert += plan.Value.UDID + ",";
                    strInsert += "'" + plan.Value.lpParent + "',";
                    strInsert += "'" + plan.Value.dtStartTime.ToBinary() + "')";
                    //执行插入
                    SQLConnect.SQLCommandExecution(strInsert,ref Main.odcConnection);
                    recycle_bin.Add(plan.Value);
                }
            }
            //关闭数据库连接
            Main.odcConnection.Close();
            Environment.Exit(0);
        }
        /// <summary>
        /// 该函数用于主窗口加载，其基本用途如下：
        /// 1、加载设置项；
        /// 2、初始化回收站模块，用于读取数据；
        /// 3、读取用户属性并加载相应值；
        /// 4、盗版检查；
        /// 5、获取格言与图片地址或内容；
        /// 6、预分配100个空任务；
        /// 7、加载日期时间；
        /// 8、加载一个一个语言啊；
        /// 9、读取未完成任务
        /// 10、加载功能。
        /// </summary>
        private async void Main_Load(object sender, EventArgs e)
        {
            #region 窗口加载
            InitializeSettings();
            this.TopMost = false;
            //难度评价
            //先初始化回收站
            Recycle recy_bin = new Recycle();
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
                PlanClassA psa = new PlanClassA();
                psa.lpCapital = "NULL";
                psa.lpParent = null;
                psa.dwStart = 0;
                psa.iWisdom = 0;
                psa.iLasting = 0;
                psa.iExplosive = 0;
                psa.dwIntro = "NULL";
                psa.iSeconds = 0;
                Plan p = new Plan(psa);
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
                    Thread tdHolder = new Thread(() => LanguageHolder());
                    tdHolder.Start();
                    Thread.Sleep(1000);
                    Thread loaderThread = new Thread(new ThreadStart(FunctionLoader));
                    tdHolder.Join();
                    loaderThread.Start();
                }
            }
            #endregion
            CheckForIllegalCrossThreadCalls = false;
            //PlanAdder(new Plan(string.Empty, 0, "TEST 0", 0.0D, "Test"), "Extent Test", 0, 0D);
            #region 未完成任务读取
            for (int i = 0; i < recy_bin.dataGridView1.Rows.Count - 1; i++)
            {
                if (recy_bin.dataGridView1.Rows[i].Cells[5].Value.ToString() == "0")
                {
                    continue;
                }
                //完了，他妈的，重载全几把乱了
                PlanClassB psb = new PlanClassB();
                psb.lpCapital = recy_bin.dataGridView1.Rows[i].Cells[1].Value.ToString();
                psb.dwIntro = recy_bin.dataGridView1.Rows[i].Cells[2].Value.ToString();
                psb.iSeconds = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[5].Value);
                psb.dwDifficulty = Convert.ToDouble(recy_bin.dataGridView1.Rows[i].Cells[4].Value);
                psb.UDID = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[9].Value);
                psb.iLasting = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[6].Value);
                psb.iExplosive = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[7].Value);
                psb.iWisdom = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[8].Value);
                psb.dwStart = Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[11].Value);
                //Plan plan = new Plan
                //    (
                //    recy_bin.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                //    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[5].Value),
                //    recy_bin.dataGridView1.Rows[i].Cells[2].Value.ToString(),
                //    Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[4].Value),
                //    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[9].Value),
                //    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[6].Value),
                //    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[7].Value),
                //    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[8].Value)
                //    );
                PlanAdder(new Plan(psb));
                LengthCalculation();
                plan = null;
            }
            #endregion
            //Thread testThread = new Thread(new ThreadStart(Test.Add10Plan));
            //testThread.Start();
            #region 热点爬取器
            //https://v.api.aa1.cn/api/topbaidu/index.php
            //请求新闻API
            HttpClient client = new HttpClient();
            //发送Get请求
            var resultjson = await client.GetStringAsync("https://v.api.aa1.cn/api/topbaidu/index.php");
            int tmp = resultjson.Length - 2;
            resultjson = resultjson.Replace(" ", "").Substring(0, tmp - 5);
            //接下来暴力解析
            JavaScriptSerializer js = new JavaScriptSerializer();//实例化一个能够序列化数据的类
            try
            {
                NewsJsonStructure.Root list = js.Deserialize<NewsJsonStructure.Root>(resultjson); //将json数据转化为对象类型并赋值给list
                var x = list.newslist;
                foreach (var item in x)
                {
                    sentence.Add(item.title);
                }
            }
            catch (Exception ex) { ErrorCenter.AddError(DateTime.Now.ToString(), "warning", ex); }
            #endregion
            // \Linq is Gooooood!/
            // \We Love Linq!/
            sentence.FindAll(sentence => sentence.Contains("\n")).ForEach(sentence => sentence.Replace("\n",""));
            #region 功能控制器
            if (!activation)
            {
                timer_Ponv.Enabled = false;
                timer_Conv.Enabled = false;
                label_Sentence.Text = "MethodBox Aim（评估副本）";
            }
            if (banned)
            {
                timer_Ponv.Enabled = false;
                timer_Conv.Enabled = false;
                timer_EventHandler.Enabled = false;
                label_Sentence.Text = "MethodBox Aim（限制副本）";
            }
            #endregion
            Thread scanner = new Thread(new ThreadStart(TaskTimeScan));
            scanner.Start();
            GetSchedule(true);
        }

        internal static void AddSign(int sign)
        {
            if (signQueue.Count >= 36)
            {
                return;
            }
            signQueue.Enqueue(sign);
        }

        #region 功能加载器
        protected void FunctionLoader()
        {
            int i = 34;
            //加载功能 34高
            if (main.InvokeRequired)
            {
                main.Invoke(controlsAdd);
            }
            else
            {
                Function newTodo = new Function($"{Application.StartupPath}\\icon\\new.png", $"{langInfo[2]}", "__New__");
                newTodo.Top = 0;
                panel_L.Controls.Add(newTodo);
                //Function export = new Function($"{Application.StartupPath}\\icon\\export.png", $"{langInfo[49]}", "__Export__");
                //export.Top = 34;
                //panel_L.Controls.Add(export);
                Function recycle = new Function($"{Application.StartupPath}\\icon\\recycle.png", $"{langInfo[13]}", "__Recycle__");
                recycle.Top = i;
                panel_L.Controls.Add(recycle);
                Function debugger = new Function($"{Application.StartupPath}\\icon\\debug.png", $"调试工具", "__Debugger__");
                debugger.Top = 7 * i;
                panel_L.Controls.Add(debugger);
                Function info = new Function($"{Application.StartupPath}\\icon\\info.png", $"{langInfo[14]}", "__Infomation__");
                info.Top = 9 * i;
                panel_L.Controls.Add(info);
                Function console = new Function($"{Application.StartupPath}\\icon\\console.png", $"{langInfo[15]}", "__Console__");
                console.Top = 3 * i;
                panel_L.Controls.Add(console);
                Function IDE = new Function($"{Application.StartupPath}\\icon\\program.png", $"{langInfo[16]}", "__IDE__");
                IDE.Top = 4 * i;
                panel_L.Controls.Add(IDE);
                Function Online = new Function($"{Application.StartupPath}\\icon\\server.png", $"在线协作", "__Online__");
                Online.Top = 5 * i;
                panel_L.Controls.Add(Online);
                Function Settings = new Function($"{Application.StartupPath}\\icon\\settings.png", $"{langInfo[17]}", "__Settings__");
                Settings.Top = 6 * i;
                panel_L.Controls.Add(Settings);
                Function Shop = new Function($"{Application.StartupPath}\\icon\\shop.png", $"{langInfo[18]}", "__Shop__");
                Shop.Top = 2 * i;
                panel_L.Controls.Add(Shop);
                Function Schedule = new Function($"{Application.StartupPath}\\icon\\schedule.png", $"排班日历", "__Schedule__");
                Schedule.Top = 8 * i;
                panel_L.Controls.Add(Schedule);
                //你猜猜点击函数在哪里？没想到吧，在这里！
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
        internal void LanguageHolder()
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

        //列表加载器
        protected void ListHolder()
        {
            //MYUKKE IS GOOOOOOD!
            //像暂时存储副控件添加新的Controls.Add函数
            panel_L.ControlAdded += new ControlEventHandler(Another_OnControlAdded);
            panel_L.Controls.Clear();
            //这个字段是用来连接用的
            //string strConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\data.mdb;Jet OLEDB:Database Password={Main.password}";
            //OleDbConnection odcConnection = new OleDbConnection(strConn); //打开连接
            //odcConnection.Open(); //建立SQL查询   
            //OleDbCommand odCommand = odcConnection.CreateCommand();
            //搜索数据库中所有列表
            List<string> list = new List<string>();
            //OleDbConnection odcConnectiontemp = new OleDbConnection();
            //var sResult = SQLConnect.SQLCommandQuery("SELECT * FROM Lists",ref odcConnectiontemp);
            //odCommand.CommandText = "SELECT * FROM Lists";
            var sResult = SQLConnect.SQLCommandQuery("SELECT * FROM Lists",ref Main.odcConnection);
            while (sResult.Read())
            {
                list.Add(sResult[1].ToString());
            }
            //对所有列表 依次搜索其子值
            //这里读取次数太多，就不用封装好的查询了
            //引用关闭原有数据库连接
            List<Plan> sonTask = new List<Plan>();
            //猜猜DataReader在哪儿，小子
            foreach (var item in list)
            {
                //添加父节点
                Function parentMain = new Function(item, item, 1);
                panel_L.Controls.Add(parentMain);
                /*
                 * '已有打开的与此 Command 相关联的 DataReader，必须首先将它关闭。'
                 * 他妈的 DataReader在哪儿
                 * 谁来告诉我
                 * 淦我自己觉得一点问题没有
                 * 里边关里边不行 用了引用外边关
                 * 还是不行 怎么也不行
                 * 百度说用一个连接参数 我直接连接报错
                 * 奶奶的 真是绝了
                 *
                 * 怀疑：读空报错
                 *
                 * 果然是读空报错
                 * 怀疑原因是自动跳出之后再次尝试读取
                 * 你的报错能不能走点心啊
                 */
                try
                {
                    sResult = SQLConnect.SQLCommandQuery($"SELECT * FROM Tasks WHERE TaskParent = '{item}'");
                }
                catch { return; }
                //建立Plan对象
                //1 5 2 4 9 6 7 8
                while (sResult.Read())
                {
                    PlanClassB psb = new PlanClassB();
                    psb.lpCapital = sResult[1].ToString();
                    psb.dwIntro = sResult[2].ToString();
                    psb.iSeconds = Convert.ToInt32(sResult[5]);
                    psb.dwDifficulty = Convert.ToInt64(sResult[4]);
                    psb.UDID = Convert.ToInt32(sResult[9]);
                    psb.iLasting = Convert.ToInt32(sResult[6]);
                    psb.iExplosive = Convert.ToInt32(sResult[7]);
                    psb.iWisdom = Convert.ToInt32(sResult[8]);
                    using (Plan plan = new Plan
                    (
                          psb
                    )
                          )
                    { Function sonMain = new Function(sResult[1].ToString(), item, 0); panel_L.Controls.Add(sonMain); }
                }
            }
            panel_L.ControlAdded -= Another_OnControlAdded;
            return;
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
            SQLConnect.SQLCommandExecution($"UPDATE Users SET Cmoney = {money} WHERE Username = {Login.UserName}",ref Main.odcConnection);
        }
        #endregion

        //覆写添加控件事件，使其按照顺序添加
        protected void Another_OnControlAdded(object sender, ControlEventArgs e)
        {
            //底下的菜单不被考虑在内
            if (e.Control.GetType() == typeof(Bottom))
                return;
            //获取已有控件 34高
            int i = panel_L.Controls.Count;
            e.Control.Top = (i - 1) * 34;
            //回调基类原函数 添加控件
            base.OnControlAdded(e);
        }
        internal void GetSchedule(bool @out = false) 
        {
            Dictionary<DateTime, string> returns = new Dictionary<DateTime, string>();
            //内置
            foreach (var item in panel_M.Controls)
            {
                if (item is Plan)
                {
                    DateTime d = (item as Plan).dtStartTime;
                    if (returns.ContainsKey(d))
                    {
                        //频率统计
                        continue;
                    }
                    else
                    {
                        string sch = ((item as Plan).dtStartTime.Hour) switch
                        {
                            >6 and <15 => " 白班",
                            _ => " 夜班",
                        };
                        returns.Add(d, sch);
                    }
                }
            }
            SchedulingCalendar calendar = new SchedulingCalendar(returns,@out);
            calendar.Show();
        }
        /// <summary>
        /// 判断是否包含此字串的进程   模糊
        /// </summary>
        /// <param name="strProcName">进程字符串</param>
        /// <returns>是否包含</returns>
        public bool SearchProcA(string strProcName)
        {
            try
            {
                //模糊进程名  枚举
                //Process[] ps = Process.GetProcesses();  //进程集合
                foreach (Process p in Process.GetProcesses())
                {

                    if (p.ProcessName.IndexOf(strProcName) > -1)  //第一个字符匹配的话为0，这与VB不同
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        internal unsafe void PlanAdder(Plan pValue, PlanClassD @struct)
        {
            /*
             * 这个奇怪的函数真是令人费解
             * 已经传入了Plan了 您老是不会自己提提参数吗
             * 况且有地方有 有地方没有
             * 总言而之 屁用没有
             * 个人认为开发者脑子有病
             * 是的 是指我自己
             */

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
            //获取结构体
            //PlanClassD @struct = Pointer.Box((void*)pStruct, typeof(PlanClassD)) as PlanClassD;
            //设置任务标题
            pValue.capital = @struct.lpCapital;
            //内置编号
            pValue.Lnumber = thisNumber;
            //添加时间
            pValue.dwSeconds = @struct.iSeconds;
            //添加难度
            pValue.dwDifficulty = @struct.dwDifficulty;
            //添加耐力值
            pValue.dwLasting = @struct.iLasting;
            //添加爆发值
            pValue.dwExplosive = @struct.iExplosive;
            //添加智慧值
            pValue.dwWisdom = @struct.iWisdom;
            //添加开始时间
            pValue.dtStartTime = DateTime.FromBinary(@struct.dwStart);
            //添加到字典
            TasksDict[thisNumber] = pValue;
            panel_M.Controls.Add(pValue);
        }

        internal unsafe void PlanAdder(Plan pValue)
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
            //添加到字典
            TasksDict[thisNumber] = pValue;
            panel_M.Controls.Add(pValue);
        }

        private unsafe void timer_EventHandler_Tick(object sender, EventArgs e)
        {
            //傻逼东西 开发者倒拔几把插在代码里
            //查找进程
            label_XHDL.Text = "";
            foreach (var item in signQueue)
            {
                label_XHDL.Text += item;
            }
            if (SearchProcA("Sword"))
            {
                timer_EventHandler.Enabled = false;
                SQLConnect.SQLCommandExecution("INSERT INTO Users(UserName) Values('METHODBOX_BAN')",ref Main.odcConnection);
                MessageBox.Show("A debugger has been found running in your system.\n " +
                "Please, unload it from memory and restart your program.", "MethodBox's Inner Protector", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
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
            int Sign = 0;
            try
            {
                Sign = signQueue.Peek();
            }
            catch 
            {
                return; 
            }
            if (Sign == 1)
            {
                //链接数据库
                //有没有连续信号，让我看看！
                for (int i = 0; i < 2; i++)
                {
                    try
                    {
                        if (signQueue.Peek() == 1)
                        {
                            signQueue.Dequeue();
                        }
                    }
                    catch { break; }
                }
                string strConn = $" Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = {Application.StartupPath}\\data.mdb;Jet OLEDB:Database Password={Main.password}";
                OleDbConnection myConn = new OleDbConnection(strConn);
                myConn.Open();
                //先搜一下数据库
                //SELECT * FROM Persons WHERE City='Beijing'
                var hResult = SQLConnect.SQLCommandQuery($"SELECT * FROM Tasks WHERE UDID = {plan.UDID}");
                if (!hResult.HasRows) 
                {
                    string strInsert = " INSERT INTO Tasks ( TaskName , TaskIntro , TaskStatus , TaskTime , TaskDiff ,TaskLasting ,TaskExplosive , TaskWisdom , UDID , TaskParent) VALUES ( ";
                    strInsert += "'" + plan.capital + "', '";
                    strInsert += plan.dwIntro + "', '";
                    strInsert += plan.status + "', ";
                    strInsert += plan.dwSeconds + ", ";
                    strInsert += plan.dwDifficulty + ",";
                    strInsert += plan.dwLasting + ",";
                    strInsert += plan.dwExplosive + ",";
                    strInsert += plan.dwWisdom + ",";
                    strInsert += plan.UDID + ",";
                    strInsert += "'" + plan.lpParent + "'" + ")";
                    //执行插入
                    OleDbCommand inst = new OleDbCommand(strInsert, myConn);
                    inst.ExecuteNonQuery();
                }
                //删除
                int hNumber = plan.Lnumber;
                recycle_bin.Add(plan);
                panel_M.Controls.Remove(plan);
                TasksDict[hNumber] = null;
                plan = null;
                LengthCalculation();
                GC.Collect();
            }
            else if (Sign == 4)
            {
                //PlanAdder(new Plan(tName, tTime, tIntro, tDiff, tParent, tLasting, tExplosive, tWisdom), $"{tName}", tTime, tDiff, tLasting, tExplosive, tWisdom);
                //tName = string.Empty;
                PlanAdder(new Plan(planner));
                //添加并排序
                //if (InvokeRequired)
                //{
                //    this.Invoke(new Action(() => ListHolder()));
                //}
                //else
                //{
                //    ListHolder();
                //}
                LengthCalculation();
                signQueue.Dequeue();
            }
            else if (Sign == 6)
            {
                panel_TaskDetail.Controls.Remove(td);
                if (plan == null)
                {
                    //删除临近的两个错误信号
                    for (int i = 0; i < 2; i++)
                    {
                        try
                        {
                            if (signQueue.Peek() == 6)
                            {
                                signQueue.Dequeue();
                            }
                        }
                        catch { break; }
                    }
                    return;
                }
                td = new TaskDetails();
                td.Left = 16;
                td.Top = 15;
                td.Capital = plan.capital;
                td.Time = plan.dwSeconds.ToString();
                td.Intro = plan.dwIntro;
                td.StatusResult = plan.status;
                td.Difficulty = plan.dwDifficulty;
                td.Lasting = plan.dwLasting.ToString();
                td.Explosive = plan.dwExplosive.ToString();
                td.Wisdom = plan.dwWisdom.ToString();
                SoundPlayer sp = new SoundPlayer($@"{Application.StartupPath}\icon\Click.wav");
                sp.Play();
                panel_TaskDetail.Controls.Add(td);
                td.BringToFront();
                signQueue.Dequeue();
            }
            else if (Sign == 7)
            {
                panel_TaskDetail.Controls.Remove(td);
                signQueue.Dequeue();
                SoundPlayer sp = new SoundPlayer($@"{Application.StartupPath}\icon\Click.wav");
                sp.Play();
            }
            else if (Sign == 9)
            {
                pictureBox_Tip.Visible = false;
                signQueue.Dequeue();
            }
            else if (Sign == 10)
            {
                GetSchedule();
                signQueue.Dequeue();
            }
        }


        private void timer_PenalLengthController_Tick(object sender, EventArgs e)
        {
            int Sign;
            try
            {
                Sign = signQueue.Peek();
            }
            catch 
            { 
                return;
            }
            if (Sign == 2)
            {
                if (panel_L.Width >= 122)
                {
                    AddSign(3);
                    signQueue.Dequeue();
                }
                if (panel_L.Width <= 120)
                {
                    panel_L.Width += 2;
                }
                else
                {
                    signQueue.Dequeue();
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
                    signQueue.Dequeue();
                }
            }
            else if (Sign == 5)
            {
                ExportTodo et = new ExportTodo(panel_M.Controls);
                et.Show();
                signQueue.Dequeue();
            }
            else if (Sign == 12)
            {
                signQueue.Dequeue();
                if (Width >= 256)
                {
                    Width -= 2;
                    pictureBox_T_Exit.Left -= 2;
                    AddSign(12);
                }
            }
            else if (Sign == 13)
            {
                signQueue.Dequeue();
                if (Width <= 666)
                {
                    Width += 2;
                    pictureBox_T_Exit.Left += 2;
                    AddSign(13);
                }
            }
        }

        private void pictureBox_T_More_Click(object sender, EventArgs e)
        {
            if (panel_L.Width == 0)
            {
                AddSign(2);
            }
            else
            {
                AddSign(3);
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
            SQLConnect.SQLCommandExecution($"UPDATE Users SET Cmoney = {money} WHERE Username = '{Login.UserName}';",ref Main.odcConnection);
        }

        internal static void ValuesUpdate(uint type, int delta)
        {
            if (type == 1)
            {
                lasting += delta;
                SQLConnect.SQLCommandExecution($"UPDATE Users SET ABT_lasting = {lasting} WHERE Username = '{Login.UserName}';",ref Main.odcConnection);
            }
            else if (type == 2)
            {
                explosive += delta;
                SQLConnect.SQLCommandExecution($"UPDATE Users SET ABT_explosive = {explosive} WHERE Username = '{Login.UserName}';", ref Main.odcConnection);
            }
            else if (type == 3)
            {
                wisdom += delta;
                SQLConnect.SQLCommandExecution($"UPDATE Users SET ABT_wisdom = {wisdom} WHERE Username = '{Login.UserName}';", ref Main.odcConnection);
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

            SQLConnect.SQLCommandExecution($"UPDATE Users SET ABT_lasting = {Main.lasting} , ABT_explosive = {Main.explosive} , ABT_wisdom = {Main.wisdom} WHERE Username = '{Login.UserName}';", ref Main.odcConnection);
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
            //添加鼠标滚动事件
            MouseWheel += panel_L_MouseWheel;
            panel_L.Controls.Clear();
            //将做好的数据加入
            ListHolder();
        }

        /// <summary>
        /// 分类框鼠标中键滚动响应事件
        /// </summary>
        protected void panel_L_MouseWheel(object sender, MouseEventArgs e)
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
            foreach (var item in panel_L.Controls.Find("buttom", true))
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
                }
                catch { }
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
            panel_M.Top = 30 - vScrollBar_Main.Value;
            panel_L.Top = vScrollBar_Main.Value;
        }


        private void timer_Anti_Tick(object sender, EventArgs e)
        {
            if (Process.GetCurrentProcess().Parent().ProcessName != "explorer.exe" && Process.GetCurrentProcess().Parent().ProcessName != "msvsmon")
            {
                string p = "";
                try
                {
                   p =  Process.GetCurrentProcess().Parent().ProcessName.Split('.')[0];
                }
                catch 
                {
                    p = Process.GetCurrentProcess().Parent().ProcessName;
                }
                if (p == "explorer") return;
                MessageBox.Show($"您可能试图尝试在其它框架下运行Aim，例如{p}。请注意，这样的做法不是正确的。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SQLConnect.SQLCommandExecution("INSERT INTO Users(UserName) Values('METHODBOX_BAN')", ref Main.odcConnection);
                //反手关闭各线程
                label_Sentence.Text = "A Fetal Error Occured";
                timer_Conv.Enabled = false;
                timer_EventHandler.Enabled = false;
                timer_PenalLengthController.Enabled = false;
                timer_Ponv.Enabled = false;
                timer_Anti.Enabled = false;
                return;
            }
            nownn.Clear();
            string[] files;
            foreach (Control item in panel_M.Controls)
            {
                if (item.GetType() == typeof(Plan))
                {
                    nownn.Add((item as Plan).capital);
                }
            }
            try
            {
                 files = Directory.GetFiles(Application.StartupPath, "*.dll");
            }
            catch 
            {
                MessageBox.Show("您可能试图尝试在其它框架下运行Aim，例如BepInEx。请注意，这样的做法不是正确的。","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                SQLConnect.SQLCommandExecution("INSERT INTO Users(UserName) Values('METHODBOX_BAN')", ref Main.odcConnection);
                //反手关闭各线程
                label_Sentence.Text = "A Fetal Error Occured";
                timer_Conv.Enabled = false;
                timer_EventHandler.Enabled = false;
                timer_PenalLengthController.Enabled = false;
                timer_Ponv.Enabled = false;
                return;
            }
            if (files.Length != 0)
            {
                SQLConnect.SQLCommandExecution("INSERT INTO Users(UserName) Values('METHODBOX_BAN')", ref Main.odcConnection);
                //反手关闭各线程
                label_Sentence.Text = "A Fetal Error Occured";
                timer_Conv.Enabled = false;
                timer_EventHandler.Enabled = false;
                timer_PenalLengthController.Enabled = false;
                timer_Ponv.Enabled = false;
                //int isCritical = 1;  // we want this to be a Critical Process
                //int BreakOnTermination = 0x1D;  // value for BreakOnTermination (flag)
                //Process.EnterDebugMode();  //acquire Debug Privileges
                //// setting the BreakOnTermination = 1 for the current process
                //NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
                ////for (int i = 0; ; i++) { System.Console.WriteLine(i); }
            }
            try
            {
                var result = SQLConnect.SQLCommandQuery($"SELECT * FROM Users where Username='METHODBOX_BAN';");
                result.Read();
                if (result[0].ToString() != "" || result[0].ToString() != null)
                {
                    Ban ban = new Ban();
                    Opacity = 0;
                    int isCritical = 1;  // we want this to be a Critical Process
                    int BreakOnTermination = 0x1D;  // value for BreakOnTermination (flag)
                    Process.EnterDebugMode();  //acquire Debug Privileges
                                               // setting the BreakOnTermination = 1 for the current process
                    NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
                    //for (int i = 0; ; i++) { System.Console.WriteLine(i); }
                }
            }
            catch { }
        }

        /// <summary>
        /// 释放resx里面的普通类型文件
        /// </summary>
        /// <param name="resource">resx里面的资源</param>
        /// <param name="path">释放到的路径</param>
        private void ExtractNormalFileInResx(byte[] resource, String path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            file.Write(resource, 0, resource.Length);
            file.Flush();
            file.Close();
        }

        private void label_NeedTime_Click(object sender, EventArgs e)
        {
            TestTools tt = new TestTools();
            tt.Show();
        }

        private void pictureBox_Small_Click(object sender, EventArgs e)
        {
            AddSign(12);
           
        }

        private void label_Sentence_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCAPTION = 0x0002;
            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键   
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr) HTCAPTION, IntPtr.Zero);// 拖动窗体  
            }
        }

        private void label_Sentence_TextChanged(object sender, EventArgs e)
        {
            label_Sentence.Text = label_Sentence.Text.Replace("\n", "");
        }

        private void pictureBox_T_Float_Click(object sender, EventArgs e)
        {

        }
    }
}