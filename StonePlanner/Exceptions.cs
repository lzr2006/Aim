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
    }
}
