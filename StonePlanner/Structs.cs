using System;
using System.Runtime.InteropServices;

namespace StonePlanner
{
    internal class Structs
    {
        [Serializable]
        internal struct UserStruct
        {
            internal string userName;
            internal int userMoney;
            internal int userExplosive;
            internal int userLasting;
            internal int userWisdom;
        }

        [Serializable]
        public struct PlanStruct
        {
            internal string Capital;
            internal int Seconds;
            internal string Intro;
            internal double Difficulty;
            internal int UDID;
            internal string Parent;
            internal int Lasting;
            internal int Wisdom;
            internal int Explosive;
        }

        [Serializable]
        [ComVisible(true)]
        [StructLayout(LayoutKind.Auto)]
        public abstract partial class PlanBase
        {
            internal string capital;
            internal int seconds;
            internal double difficulty;
            internal int lasting;
            internal int explosive;
            internal int wisdom;
            internal long startTime;
        }

        [Serializable]
        public class PlanClassA : PlanBase
        {
            internal string intro;
            internal string parent;
            internal Action<int> Addsignal;
        }

        [Serializable]
        public class PlanClassB : PlanBase
        {
            internal string intro;
            internal int UDID;
        }

        [Serializable]
        [ComVisible(true)]
        [StructLayout(LayoutKind.Auto)]
        public class PlanClassC : PlanBase
        {
            internal string intro;
            internal int UDID;
            internal string parent;
            internal Action<int> Addsignal;
        }

        public class PlanClassD : PlanBase { }



        [Serializable]
        public class ChatStruct
        {
            internal string req_Head;
            internal string Text;
        }
    }
}
