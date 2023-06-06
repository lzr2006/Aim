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
        public class ObjectFreedException : Exception
        {
            public ObjectFreedException() { }
            public ObjectFreedException(string message) : base(message) { }
            public ObjectFreedException(string message, Exception inner) : base(message, inner) { }
            protected ObjectFreedException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }


        [Serializable]
        public class ValueNotAllowedException : Exception
        {
            public ValueNotAllowedException() { }
            public ValueNotAllowedException(string message) : base(message) { }
            public ValueNotAllowedException(string message, Exception inner) : base(message, inner) { }
            protected ValueNotAllowedException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        [Serializable]
        public class UnknownException : Exception
        {
            public UnknownException() { }
            public UnknownException(string message) : base(message) { }
            public UnknownException(string message, Exception inner) : base(message, inner) { }
            protected UnknownException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
