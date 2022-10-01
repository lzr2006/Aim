using System;
using System.Runtime.InteropServices;

namespace StonePlanner
{
    internal static class Develop
    {
        internal static class Sign
        {
            /// <summary>
            /// 该消息用于命令AimPlanner退出，注意：直接退出会导致用户数据丢失，如非必须，请勿使用。
            /// </summary>
            internal const int AM_EXIT = 0x2cbb;
            /// <summary>
            /// 该消息用于给用户加额定数量的货币，数量请包括在wParam参数内，类型为INT。
            /// </summary>
            internal const int AM_ADDMONEY = 0x2cbc;
        }
    }
    public class HWND
    {
        int ihWnd;
        public HWND(int hWnd)
        {
            this.hWnd = hWnd;
        }
        public int hWnd { get => ihWnd; set => ihWnd = value; }
    }

    public class AimInstance
    {
        public HWND hWndInstance;
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        public static AimInstance AutoCreate()
        {
            //测试警告框
            IntPtr maindHwnd = FindWindow(null, "AimPlanner");//主窗口标题
            if (maindHwnd != IntPtr.Zero)
            {
                return new AimInstance { hWndInstance = new HWND((int) maindHwnd) };
            }
            else
            {
                return null;
            }
        }
    }

    public static class Aim
    {
        [DllImport("User32.dll")]
        private static extern int SendMessage(int hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        public static void Exit(AimInstance hInstance)
        {
            SendMessage(hInstance.hWndInstance.hWnd, Develop.Sign.AM_EXIT, new IntPtr(0), new IntPtr(0));
        }
        public static void AddMoney(AimInstance hInstance, int money)
        {
            IntPtr ptr = new IntPtr(money);
            SendMessage(hInstance.hWndInstance.hWnd, 11452, ptr, new IntPtr(0));
        }
    }
}
