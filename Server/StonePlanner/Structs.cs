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

        //string lpCapital, int dwSeconds, string dwIntro, double dwDifficulty, int UDID,string lpParent, int dwLasting = 0, int dwExplosive = 0, int dwWisdom = 0
        [Serializable]
        internal struct PlanStruct
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
    }
}
