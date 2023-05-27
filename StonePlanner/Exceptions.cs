using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePlanner
{
    internal class Exceptions
    {
        internal class MethodNotExistException : Exception
        {
             internal MethodNotExistException(string message) : base(message) { } //指定错误消息
        }
        internal class MemoryNotFoundError : Exception
        {
            internal MemoryNotFoundError(string message) : base(message) { } //指定错误消息
        }

        [Serializable]
        public class WeatherNotExistException : Exception
        {
            public WeatherNotExistException() { }
            public WeatherNotExistException(string message) : base(message) { message = "不存在此天气"; }
            public WeatherNotExistException(string message, Exception inner) : base(message, inner) { }
            protected WeatherNotExistException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }


        [Serializable]
        public class PressureShouldNotExistException : Exception
        {
            public PressureShouldNotExistException() { }
            public PressureShouldNotExistException(string message) : base(message) { message = "气压值错误"; }
            public PressureShouldNotExistException(string message, Exception inner) : base(message, inner) { }
            protected PressureShouldNotExistException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
