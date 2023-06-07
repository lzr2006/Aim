using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePlanner
{
    static internal class CommonSettings
    {
        /// <summary>
        /// 是否打开轮播图功能
        /// </summary>
        internal static bool YesNoSwitchPictures = true;
        /// <summary>
        /// 轮播图切换时间
        /// </summary>
        internal static int SwitchPicturesTime = 5;
        /// <summary>
        /// 是否轮换句子
        /// </summary>
        internal static bool YesNoSwitchSentence = true;
        /// <summary>
        /// 轮换句子时间
        /// </summary>
        internal static int SwitchSentenceTime = 5;
    }
    internal static class BASE_DATA
    {
        internal const string VERSION_NAME = "Aim Dev.23060702_1105";
        internal const int VRESION_COUNT = 85;
    }
}
