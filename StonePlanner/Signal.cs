using System;
using static StonePlanner.Interfaces;

namespace StonePlanner
{
    internal class Signal : ISignal
    { 
        public int Value
        {
            get => Value;
            set 
            {
                DataType.SignChangedEventArgs e = new DataType.SignChangedEventArgs();
                e.Sign = value;
                SignChanged?.Invoke(null,e);
            }
        }
        public bool AddSignal(int signal) 
        {
            Value = signal;
            return true;
        }
        public event Action<object,DataType.SignChangedEventArgs> SignChanged;
    }
}
