using System;
using System.Collections.Generic;
using System.Linq;
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
        public class PlanClassA
        {
            internal string lpCapital;
            internal int iSeconds;
            internal string dwIntro;
            internal double dwDifficulty;
            internal string lpParent;
            internal long dwStart;
            internal int iLasting;
            internal int iExplosive;
            internal int iWisdom;
        }

        [Serializable]
        public class PlanClassB
        {
            internal string lpCapital;
            internal int iSeconds;
            internal string dwIntro;
            internal double dwDifficulty;
            internal int UDID;
            internal long dwStart;
            internal int iLasting;
            internal int iExplosive;
            internal int iWisdom;
        }

        [Serializable]
        public class PlanClassC
        {
            internal string lpCapital;
            internal int iSeconds;
            internal string dwIntro;
            internal double dwDifficulty;
            internal int UDID;
            internal long dwStart;
            internal string lpParent;
            internal int iLasting;
            internal int iExplosive;
            internal int iWisdom;
        }
        
        public class PlanClassD
        {
            internal string lpCapital;
            internal int iSeconds;
            internal double dwDifficulty;
            internal long dwStart;
            internal int iLasting;
            internal int iExplosive;
            internal int iWisdom;
        }
    }
}
