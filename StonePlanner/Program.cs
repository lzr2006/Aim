using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Windows.Forms;

namespace StonePlanner
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //AppCenter.Start("47eacc02-c48d-43a7-9295-aded8581daba",
            //typeof(Analytics), typeof(Crashes));
            AppCenter.Start("c5286b81-ac87-4531-8c6f-32106a9fabc6",
            typeof(Analytics), typeof(Crashes));
            Application.Run(new Main());
            //Application.Run(new InnerIDE());
        }
    }
}
