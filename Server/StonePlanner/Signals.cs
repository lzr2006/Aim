using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePlanner
{
    internal class Signals
    {
        internal enum Signal
        {
            SN_CLEAR = 0x00,
            SN_ADDSERVERSETTINGS = 0x01,
            SN_REMOVESERVERSETTINGS = 0x02,
            SN_ADDSERVERINFO = 0x03,
            SN_REMOVESERVERINFO = 0x04,
            SN_ADDABOUTWE = 0x05,
            SN_REMOVEABOUTWE = 0x06,
            SN_ADDMOREABOUT = 0x07,
            SN_REMOVEMOREABOUT = 0x08,
            SN_ADDTASKSETTINGS = 0x09,
            SN_REMOVETASKSETTINGS = 0x10
        }
    }
}
