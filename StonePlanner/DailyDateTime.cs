using System;
using System.Runtime.InteropServices;

namespace StonePlanner
{
    internal class DateTimeBase
    {
        internal int hh;
        internal int mm;
        internal int ss;

    }

    //我认为这个类狗都能看懂，所以我tm一句注释也不写
    internal class DailyDateTime : DateTimeBase
    {
        public DailyDateTime(int hh, int mm, int ss)
        {
            this.hh = hh;
            this.mm = mm;
            this.ss = ss;
        }

        public DailyDateTime(string time)
        {
            ConvertStringToDailyDateTimeA(time);
        }

        public DailyDateTime(DateTime dt)
        {
            hh = dt.Hour;
            mm = dt.Minute;
            ss = dt.Second;
        }

        public DailyDateTime()
        {
            DateTime dt = DateTime.Now;
            hh = dt.Hour;
            mm = dt.Minute;
            ss = dt.Second;
        }

        ~DailyDateTime()
        {
            hh = 0;
            mm = 0;
            ss = 0;
        }

        public override string ToString()
        {
            return $"{hh}:{mm}:{ss}";
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.hh == (obj as DateTimeBase).hh && this.mm == (obj as DateTimeBase).mm && this.ss == (obj as DateTimeBase).ss)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return hh ^ mm ^ ss;
        }

        public static DailyDateTime operator +(DailyDateTime ddt_1, DailyDateTime ddt_2) 
        {
            int hh = ddt_1.hh + ddt_2.hh;
            int mm = ddt_1.mm + ddt_2.mm;
            int ss = ddt_1.ss + ddt_2.ss;
            string cresult = FormatTimeA(hh * 3600 + mm * 60 + ss);
            return ConvertStringToDailyDateTimeA(cresult);
        }

        public static DailyDateTime operator -(DailyDateTime ddt_1, DailyDateTime ddt_2)
        {
            int hh = ddt_1.hh - ddt_2.hh;
            int mm = ddt_1.mm - ddt_2.mm;
            int ss = ddt_1.ss - ddt_2.ss;
            string cresult = FormatTimeA(hh * 3600 + mm * 60 + ss);
            return ConvertStringToDailyDateTimeA(cresult);
        }

        public static DailyDateTime operator *(DailyDateTime ddt, int multiple)
        {
            int hh = ddt.hh * multiple;
            int mm = ddt.mm * multiple;
            int ss = ddt.ss * multiple;
            string cresult = FormatTimeA(hh * 3600 + mm * 60 + ss);
            return ConvertStringToDailyDateTimeA(cresult);
        }

        public static DailyDateTime operator /(DailyDateTime ddt, int multiple)
        {
            int hh = ddt.hh / multiple;
            int mm = ddt.mm / multiple;
            int ss = ddt.ss / multiple;
            string cresult = FormatTimeA(hh * 3600 + mm * 60 + ss);
            return ConvertStringToDailyDateTimeA(cresult);
        }

        public static string FormatTimeA(int T)
        {
            if (T < 60)
            {

                return T.ToString().Length switch
                {
                    1 => $"00:00:0{T}",
                    2 => $"00:00:{T}",
                    _ => $"00:00:00"
                };
            }
            else if (T < 3600)
            {
                int i = 0;
                for (; T >= 60; i++)
                {
                    T -= 60;
                }
                var mm = i.ToString().Length == 1 ? $"0{i}" : $"{i}";
                var ss = T.ToString().Length == 1 ? $"0{T}" : $"{T}";
                return $"00:{mm}:{ss}";
            }
            else
            {
                int j = 0;
                for (; T >= 3600; j++)
                {
                    T -= 3600;
                }
                int i = 0;
                for (; T >= 60; i++)
                {
                    T -= 60;
                }
                var hh = j.ToString().Length == 1 ? $"0{j}" : $"{j }";
                var mm = i.ToString().Length == 1 ? $"0{i}" : $"{i }";
                var ss = T.ToString().Length == 1 ? $"0{T}" : $"{T }";
                return $"{hh}:{mm}:{ss}";
            }
        }

        public static DailyDateTime ConvertStringToDailyDateTimeA(string res)
        {
            try
            {
                int hh = Convert.ToInt32(res.Split(':')[0]);
                int mm = Convert.ToInt32(res.Split(':')[1]);
                int ss = Convert.ToInt32(res.Split(':')[2]);
                DailyDateTime ddt = new DailyDateTime(hh, mm, ss);
                return ddt;
            }
            catch
            {
                throw new StringFormatException($"输入字符串\"{res}\"的格式不正确。");
            }
        }

        public DateTime ToDateTime() 
        {
            DateTime dt = new DateTime
            (
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                hh,
                mm,
                ss
            );
            return dt;
        }

        public DailyDateTime DeepCopy(DailyDateTime dt)
        {
            return new DailyDateTime(hh, mm, ss);
        }

        public unsafe int* ShallowCopy(DailyDateTime dt)
        {
            IntPtr ptr = new IntPtr(0);
            Marshal.StructureToPtr(dt, ptr, false);
            int* address = (int*) ptr;
            return address;
        }

        [Serializable]
        public class StringFormatException : Exception
        {
            public StringFormatException() { }
            public StringFormatException(string message) : base(message) { }
            public StringFormatException(string message, Exception inner) : base(message, inner) { }
            protected StringFormatException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

    }
}
