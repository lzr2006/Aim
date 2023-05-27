using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static StonePlanner.Structs;
using static StonePlanner.Develop.Sign;
using static StonePlanner.Exceptions;

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
 * ********************         佛祖保佑 永无BUG           ********************
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
        public static DateTime tStart;
        #endregion
        #region 外部引用
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
        #endregion
        #region 主窗口及设置加载/退出
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

        /// <summary>
        /// 该函数处理用户退出事件，存入新的还未存储的数据。
        /// </summary>
        private void pictureBox_T_Exit_Click(object sender, EventArgs e)
        {
            //存入还未完成的任务
            foreach (var plan in TasksDict)
            {
                //先判断是否存在
                //Users可还行 表都他妈不分了吗你
                if (plan.Value != null)
                {
                    /*
                     * 此处的Bug：
                     * 关闭的时候，检查是否已经存在了相应任务
                     * 如果存在就不在添加
                     * 但是，如果已经更新了数据
                     * 也无法存储，导致了任务还原的Bug
                     * 做法：
                     * 仅对状态为待办的剩余时间和是否完成进行更新
                    */
                    string queryString = $"SELECT * FROM Tasks WHERE ID = {plan.Value.UDID}";
                    var sqlResult = SQLConnect.SQLCommandQuery(queryString, ref Main.odcConnection);
                    if (sqlResult.HasRows)
                    {
                        //已经存在相应任务，查询是否已完成，否则更新时间
                        sqlResult.Read();
                        //查询状态 不为待办
                        if (sqlResult["TaskStatus"].ToString() != "待办")
                        {
                            MessageBox.Show(sqlResult["TaskStatus"].ToString());
                            continue;
                        }
                        else
                        {
                            //更新时间和待办状态
                            //UPDATE 表名称 SET 列名称 = 新值 WHERE 列名称 = 某值
                            if (plan.Value.dwSeconds > 0)
                            {
                                string updateString = $"UPDATE Tasks SET TaskTime = {plan.Value.dwSeconds}" +
                                    $" WHERE ID = {plan.Value.UDID}";
                                SQLConnect.SQLCommandQuery(updateString, ref Main.odcConnection);
                                continue;
                            }
                            else
                            {
                                ErrorCenter.AddError(DataType.ExceptionsLevel.Warning
                                    ,new ObjectFreedException("已经被清除的任务再次添加。"));
                            }
                        }
                    }
                    //脑子是个好东西 下次带上
                    string strInsert = "INSERT INTO Tasks ( TaskName , TaskIntro , TaskStatus , TaskTime , TaskDiff ,TaskLasting ,TaskExplosive , TaskWisdom , TaskParent , StartTime) VALUES ( ";
                    strInsert += "'" + plan.Value.capital + "', '";
                    strInsert += plan.Value.dwIntro + "', '";
                    strInsert += plan.Value.status + "', ";
                    strInsert += plan.Value.dwSeconds + ", ";
                    strInsert += plan.Value.dwDifficulty + ",";
                    strInsert += plan.Value.dwLasting + ",";
                    strInsert += plan.Value.dwExplosive + ",";
                    strInsert += plan.Value.dwWisdom + ",";
                    strInsert += "'" + plan.Value.lpParent + "',";
                    strInsert += "'" + plan.Value.dtStartTime.ToBinary() + "')";
                    //执行插入
                    SQLConnect.SQLCommandExecution(strInsert, ref Main.odcConnection);
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
        private void Main_Load(object sender, EventArgs e)
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
                PlanClassA psa = new()
                {
                    capital = "NULL",
                    parent = null,
                    startTime = 0,
                    wisdom = 0,
                    lasting = 0,
                    explosive = 0,
                    intro = "NULL",
                    seconds = 0
                };
                Plan p = new(psa)
                {
                    Lnumber = -1
                };
                TasksDict.Add(i, null);
            }
            //加载日期时间
            label_Date.Text = DateTime.Now.ToString("dd");
            label_Month.Text = DateTime.Now.ToString("MM");
            #endregion
            Thread loaderThread = new Thread(new ThreadStart(FunctionLoader));
            loaderThread.Start();
            CheckForIllegalCrossThreadCalls = false;
            #region 未完成任务读取
            for (int i = 0; i < recy_bin.dataGridView1.Rows.Count - 1; i++)
            {
                if (recy_bin.dataGridView1.Rows[i].Cells[5].Value.ToString() == "0")
                {
                    continue;
                }
                //完了，他妈的，重载全几把乱了
                PlanClassB psb = new()
                {
                    capital = recy_bin.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    intro = recy_bin.dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    seconds = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[5].Value),
                    difficulty = Convert.ToDouble(recy_bin.dataGridView1.Rows[i].Cells[4].Value),
                    UDID = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[0].Value),
                    lasting = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[6].Value),
                    explosive = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[7].Value),
                    wisdom = Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[8].Value),
                    startTime = Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[10].Value)
                };
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
                AddPlan(new Plan(psb));
                LengthCalculation();
                plan = null;
            }
            #endregion
            // \Linq is Gooooood!/
            // \We Love Linq!/
            sentence.FindAll(sentence => sentence.Contains("\n")).ForEach(sentence => sentence.Replace("\n", ""));
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
            string alert = GetSchedule(true);
            ScanTaskTime(alert);
            contextMenuStrip.Enabled = false;
        }
        #endregion
        delegate void PlanAddInvoke(Plan pValue);
        #region 任务处理相关
        internal unsafe void AddPlan(Plan pValue)
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
            LengthCalculation();
            if (signQueue.Count != 0) signQueue.Dequeue();
        }

        protected void ScanTaskTime(string alert = "")
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
                new Alert(_tasks,alert).ShowDialog();
            }
            _tasks.Clear();
        }


        #endregion
        #region 加载器
        internal void HoldLanguage()
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
        protected void HoldList()
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
            var sResult = SQLConnect.SQLCommandQuery("SELECT * FROM Lists", ref Main.odcConnection);
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
                    PlanClassB psb = new()
                    {
                        capital = sResult[1].ToString(),
                        intro = sResult[2].ToString(),
                        seconds = Convert.ToInt32(sResult[5]),
                        difficulty = Convert.ToInt64(sResult[4]),
                        UDID = Convert.ToInt32(sResult[0]),
                        lasting = Convert.ToInt32(sResult[6]),
                        explosive = Convert.ToInt32(sResult[7]),
                        wisdom = Convert.ToInt32(sResult[8])
                    };
                    using Plan plan = new Plan
                    (
                          psb
                    );
                    Function sonMain = new Function(sResult[1].ToString(), item, 0); panel_L.Controls.Add(sonMain);
                }
            }
            panel_L.ControlAdded -= Another_OnControlAdded;
            return;
        }

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
                AddTodo.PlanAddInvoke officalInvoke = new AddTodo.PlanAddInvoke(AddPlan);
                Function newTodo = new Function($"{Application.StartupPath}\\icon\\new.png", 
                    $"新建任务", "__New__",officalInvoke)
                {
                    Top = 0
                };
                panel_L.Controls.Add(newTodo);
                //Function export = new Function($"{Application.StartupPath}\\icon\\export.png", $"{langInfo[49]}", "__Export__");
                //export.Top = 34;
                //panel_L.Controls.Add(export);
                Function recycle = new($"{Application.StartupPath}\\icon\\recycle.png", "任务回收", "__Recycle__")
                {
                    Top = i
                };
                panel_L.Controls.Add(recycle);
                Function debugger = new($"{Application.StartupPath}\\icon\\debug.png", $"调试工具", "__Debugger__")
                {
                    Top = 7 * i
                };
                panel_L.Controls.Add(debugger);
                Function info = new($"{Application.StartupPath}\\icon\\info.png", "关于软件", "__Infomation__")
                {
                    Top = 9 * i
                };
                panel_L.Controls.Add(info);
                Function console = new($"{Application.StartupPath}\\icon\\console.png", "主控制台", "__Console__")
                {
                    Top = 3 * i
                };
                panel_L.Controls.Add(console);
                Function IDE = new($"{Application.StartupPath}\\icon\\program.png", "事件编写", "__IDE__")
                {
                    Top = 4 * i
                };
                panel_L.Controls.Add(IDE);
                Function Online = new($"{Application.StartupPath}\\icon\\server.png", $"在线协作", "__Online__")
                {
                    Top = 5 * i
                };
                panel_L.Controls.Add(Online);
                Function Settings = new($"{Application.StartupPath}\\icon\\settings.png", $"软件设置", "__Settings__")
                {
                    Top = 6 * i
                };
                panel_L.Controls.Add(Settings);
                Function Shop = new($"{Application.StartupPath}\\icon\\shop.png", $"我的商城", "__Shop__") 
                {
                    Top = 2 * i
                };
                panel_L.Controls.Add(Shop);
                Function Schedule = new($"{Application.StartupPath}\\icon\\schedule.png", $"排班日历", "__Schedule__")
                {
                    Top = 8 * i
                };
                panel_L.Controls.Add(Schedule);
                //你猜猜点击函数在哪里？没想到吧，在这里！
                Bottom Function = new("功能")
                {
                    Top = 374,
                    Left = 1
                };
                Function.Click += label_L_Function_Click;
                Function.label_B.Click += label_L_Function_Click;
                panel_L.Controls.Add(Function);
                Bottom Type = new("分类")
                {
                    Top = 374,
                    Left = 60
                };
                Type.Click += label_L_Type_Click;
                Type.label_B.Click += label_L_Type_Click;
                panel_L.Controls.Add(Type);
                //正在休息状态
                label_Status.Text = "正在休息";
            }
            return;
        }
        #endregion
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
                    WebClient MyWebClient = new()
                    {
                        Credentials = CredentialCache.DefaultCredentials//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                    };
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
                            ErrorCenter.AddError(DataType.ExceptionsLevel.Warning, ex);
                        }
                        using StreamWriter sw = new StreamWriter($"{Application.StartupPath}\\language.mlu");//将获取的内容写入文本
                        sw.Write(pageHtml);
                        sw.Flush();
                        sw.Close();
                    }
                    Thread.Sleep(10000);
                }
                //检查语言包
            }

            catch (Exception e) 
            {
                ErrorCenter.AddError(DataType.ExceptionsLevel.Warning, e);
            }
        }

        private void timer_Anti_Tick(object sender, EventArgs e)
        {
            if (Process.GetCurrentProcess().Parent().ProcessName != "explorer.exe" && Process.GetCurrentProcess().Parent().ProcessName != "msvsmon")
            {
                string p = "";
                try
                {
                    p = Process.GetCurrentProcess().Parent().ProcessName.Split('.')[0];
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
                MessageBox.Show("您可能试图尝试在其它框架下运行Aim，例如BepInEx。请注意，这样的做法不是正确的。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #endregion
        #region 金钱操作
        internal void ChangeMoney(int value)
        {
            money += value;
            //向指定用户插入
            SQLConnect.SQLCommandExecution($"UPDATE Users SET Cmoney = {money} WHERE Username = {Login.UserName}",ref Main.odcConnection);
        }
        /// <summary>
        /// 更新用户金钱
        /// </summary>
        internal static void MoneyUpdate(int delta)
        {
            money += delta;
            SQLConnect.SQLCommandExecution($"UPDATE Users SET Cmoney = {money} WHERE Username = '{Login.UserName}';", ref Main.odcConnection);
        }

        internal static void ValuesUpdate(uint type, int delta)
        {
            if (type == 1)
            {
                lasting += delta;
                SQLConnect.SQLCommandExecution($"UPDATE Users SET ABT_lasting = {lasting} WHERE Username = '{Login.UserName}';", ref Main.odcConnection);
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
        #endregion
        #region 加载排班日历
        internal string GetSchedule(bool @out = false)
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
                        Plan plan1 = (item as Plan);
                        string sch = plan1.dtStartTime.Hour switch
                        {
                            > 6 and < 15 => " 白班",
                            _ => " 夜班",
                        };
                        returns.Add(d, sch);
                    }
                }
            }
            try
            {
                if (@out)
                {
                    string tql = "";
                    new SchedulingCalendar(returns,out tql, @out).Show();
                    return tql;
                }
                else
                {
                    string _ = null;
                    new SchedulingCalendar(returns,out _, @out).Show();
                    return null;
                }
            }
            catch (Exception ex)
            {
                ErrorCenter.AddError(DataType.ExceptionsLevel.Error, ex);
                return null;
            }
        }
        #endregion
        #region 信号系统
        internal static void AddSign(int sign)
        {
            if (signQueue.Count >= 36)
            {
                return;
            }
            signQueue.Enqueue(sign);
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
                var hResult = SQLConnect.SQLCommandQuery($"SELECT * FROM Tasks WHERE ID = {plan.UDID}");
                if (hResult.HasRows)
                {
                    /*
                     * 此处的Bug：
                     * 当任务完成后，会从列表中清理
                     * 向数据库中保存时应该在删除任务时保存
                     * 做法：
                     * 更改保存位置
                    */     
                    string updateString = $"UPDATE Tasks SET TaskTime = {plan.dwSeconds}" +
                                $" , TaskStatus = \"已办完\"" +
                                $" WHERE ID = {plan.UDID}";
                    SQLConnect.SQLCommandQuery(updateString, ref Main.odcConnection);
                }
                else
                {
                    string strInsert = " INSERT INTO Tasks ( TaskName , TaskIntro , TaskStatus , TaskTime , TaskDiff ,TaskLasting ,TaskExplosive , TaskWisdom , TaskParent) VALUES ( ";
                    strInsert += "'" + plan.capital + "', '";
                    strInsert += plan.dwIntro + "', '";
                    strInsert += plan.status + "', ";
                    strInsert += plan.dwSeconds + ", ";
                    strInsert += plan.dwDifficulty + ",";
                    strInsert += plan.dwLasting + ",";
                    strInsert += plan.dwExplosive + ",";
                    strInsert += plan.dwWisdom + ",";
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
            //else if (Sign == 4)
            //{
            //    PlanAdder(new Plan(planner));
            //    LengthCalculation();
            //    signQueue.Dequeue();
            //}
            else if (Sign == 6)
            {
                panel_TaskDetail.Controls.Remove(td);
                if (plan == null)
                {
                    //删除临近的两个错误信号
                    System.Console.WriteLine("OCCURED!");
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
                //怀疑出现的问题：重复执行
                signQueue.Dequeue();
                GetSchedule();
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
                if (Width <= 674)
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
        #endregion
        #region 每日一句/一图加载器
        public void SentenceGetter()
        {
            try
            {
                WebClient MyWebClient = new WebClient
                {
                    Credentials = CredentialCache.DefaultCredentials//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                };
                Byte[] pageData = MyWebClient.DownloadData("https://lzr2006.github.io/wkgd/Services/StonePlanner/sentence.txt"); //下载                                                                                            //string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            
                string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                foreach (var item in pageHtml.Split(';'))
                {
                    sentence.Add(item);
                }
            }
            catch (Exception ex)
            {
                ErrorCenter.AddError(DataType.ExceptionsLevel.Caution, ex);
                sentence.Add("浪费时间叫虚度，剥用时间叫生活。");
            }
            return;
        }

        public void PictureUriGetter()
        {
            try
            {
                //暂且禁用
                throw new Exception();
                WebClient MyWebClient = new()
                {
                    Credentials = CredentialCache.DefaultCredentials//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                };
                Byte[] pageData = MyWebClient.DownloadData("https://lzr2006.github.io/Services/StonePlanner/picture.txt"); //下载
                string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                foreach (var item in pageHtml.Split('\n'))
                {
                    pictures.Add(item.Replace('\r', ' ').Replace('\n', ' ').Replace('\t', ' '));
                }
            }
            catch (Exception ex)
            {
                ErrorCenter.AddError(DataType.ExceptionsLevel.Infomation, ex);
                pictures.Add("https://s1.328888.xyz/2022/05/15/qmuyT.jpg");
            }
            return;
        }
        #endregion
        #region 每日一句/一图执行器
        private void label_Sentence_TextChanged(object sender, EventArgs e)
        {
            label_Sentence.Text = label_Sentence.Text.Replace("\n", "");
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
                ErrorCenter.AddError(DataType.ExceptionsLevel.Infomation, ex);
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
            { ErrorCenter.AddError(DataType.ExceptionsLevel.Warning, ex); }
        }
        private void User_Piicture_Click(object sender, EventArgs e)
        {
            UserInfo _ = new UserInfo();
            _.Show();
        }
        #endregion
        #region 外观控制
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

        private void User_Piicture_DoubleClick(object sender, EventArgs e)
        {
            ErrorCenter _ = new ErrorCenter();
            _.Show();
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
            HoldList();
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
                    Bottom Type = new("分类")
                    {
                        Top = 374,
                        Left = 60
                    };
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
            int count = default;
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
        #endregion
        #region 右键菜单事件
        private void 最大化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSign(13);
        }

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSign(12);
        }

        private void 添加任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTodo _ = new AddTodo(AddPlan);
            _.Show();
        }

        private void 任务回收站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recycle _ = new Recycle();
            _.Show();
        }
        
        private void 新建清单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddList _ = new AddList();
            _.Show();
        }

        private void 控制台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console _ = new Console();
            _.Show();
        }

        private void 事件IDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InnerIDE _ = new InnerIDE();
            _.Show();
        }

        private void 登录服务器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebService _ = new WebService();
            _.Show();
        }

        private void 静态指示器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testify _ = new Testify();
            _.Show();
        }

        private void 信号控制器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignSettings _ = new SignSettings();
            _.Show();
        }

        private void 错误中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorCenter _ = new ErrorCenter();
            _.Show();
        }

        private void 引发崩溃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new Exception("用户引发崩溃");
        }

        private void 访问主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://space.bilibili.com/497309497?spm_id_from=333.1007.0.0");
        }

        private void 捐赠软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://afdian.net/a/MethodBox");
        }
        private void 堵塞执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signQueue.Enqueue(-1);
        }

        private void 恢复执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signQueue.Dequeue();
        }

        private void 停用商城ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shop _ = new Shop();
            _.Show();
        }

        private void 停用导入包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Importer _ = new Importer();
            _.Show();
        }

        private void 停用导出待办ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTodo _ = new ExportTodo(panel_M.Controls);
            _.Show();
        }
        #endregion

        private void pictureBox_T_Float_DoubleClick(object sender, EventArgs e)
        {
            contextMenuStrip.Enabled = !contextMenuStrip.Enabled;
        }
    }
}