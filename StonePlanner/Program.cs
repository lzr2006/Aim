﻿using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StonePlanner
{
    internal static class Program
    {
        public static bool HIDEBUG = false;
        static bool EnableProgramTrusteeship = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try 
            {
                if (args[0] == "-itst")
                {
                    EnableProgramTrusteeship = false;
                }
            } 
            catch { }
            Application.EnableVisualStyles();
            AppCenter.Start("f60d699f-aa39-4089-aae5-5c3c76218ebb",
            typeof(Analytics), typeof(Crashes));

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
            if (HIDEBUG)
            {
                //处理UI线程异常
                if (EnableProgramTrusteeship) Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                //处理非UI线程异常
                if (EnableProgramTrusteeship) AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            }
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            /*!!!!!*/
            Application.Run(new Login());//!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            string strConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\data.mdb;Jet OLEDB:Database Password={StonePlanner.Main.password}";
            StonePlanner.Main.odcConnection = new OleDbConnection(strConn); //2、打开连接 C#操作Access之按列读取mdb   
            StonePlanner.Main.odcConnection.Open();
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
           ErrorCenter.AddError(DateTime.Now.ToString(), "Error", (Exception) e.ExceptionObject);
           new BugReporter(e.ExceptionObject.ToString()).Show();
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ErrorCenter.AddError(DateTime.Now.ToString(), "Error", e.Exception);
            new BugReporter(e.Exception.ToString()).Show();
        }
    }

}