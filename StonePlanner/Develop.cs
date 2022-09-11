using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePlanner
{
    internal static class Develop
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
