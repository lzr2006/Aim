using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePlanner
{
    internal class Interfaces
    {
        internal interface ISignal
        {
            int Value { get; set; }

            bool AddSignal(int Sign);
        }
    }
}
