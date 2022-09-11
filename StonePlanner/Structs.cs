using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
            internal string lpCapital;
            internal int iSeconds;
            internal double dwDifficulty;
            internal int iLasting;
            internal int iExplosive;
            internal int iWisdom;
            internal long dwStart;
        }

        [Serializable]
        public class PlanClassA : PlanBase
        {
            internal string dwIntro;
            internal string lpParent;
        }

        [Serializable]
        public class PlanClassB : PlanBase
        {
            internal string dwIntro;
            internal int UDID;
        }

        [Serializable]
        [ComVisible(true)]
        [StructLayout(LayoutKind.Auto)]
        public class PlanClassC : PlanBase
        {
            internal string dwIntro;
            internal int UDID;
            internal string lpParent;
        }
        
        public class PlanClassD : PlanBase{}
    }
}
