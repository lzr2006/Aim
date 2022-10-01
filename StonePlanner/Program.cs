using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StonePlanner
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //AppCenter.Start("47eacc02-c48d-43a7-9295-aded8581daba",
            //typeof(Analytics), typeof(Crashes));
            AppCenter.Start("f60d699f-aa39-4089-aae5-5c3c76218ebb",
            typeof(Analytics), typeof(Crashes));
            //Application.Run(new Main());
            //先检查封禁
            //才怪
            //args[]参数功能

            try
            {
                var result = SQLConnect.SQLCommandQuery($"SELECT * FROM Users where Username='METHODBOX_BAN';");
                result.Read();
                if (result[0].ToString() != "" || result[0].ToString() != null)
                {
                    Application.Run(new Ban());
                    return;
                }
            }
            catch {  }
            //处理UI线程异常
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //处理非UI线程异常
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            /*!!!!!*/Application.Run(new Welcome());//!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            string strConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\data.mdb;Jet OLEDB:Database Password={StonePlanner.Main.password}";
            StonePlanner.Main.odcConnection = new OleDbConnection(strConn); //2、打开连接 C#操作Access之按列读取mdb   
            StonePlanner.Main.odcConnection.Open();
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
           new BugReporter(e.ExceptionObject.ToString()).Show();
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            new BugReporter(e.Exception.ToString()).Show();
        }
    }

}
