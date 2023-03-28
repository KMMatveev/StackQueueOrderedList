using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class MyQueue<T>
    {
        int MaxSize { get; set; }
        T[] _Queue { get; set; }
        int LastIndex { get; set; } = 0;
        int FirstIndex { get; set; } = 0;
        int len { get; set; } = 0;
        public int Length
        {
            get { return len; }
        }

        public MyQueue(int maxSize)
        {
            MaxSize = maxSize;
            _Queue = new T[maxSize];
            LastIndex = 0;
            FirstIndex = 0;
        }

        public void Push(T x)
        {
            if (Length == MaxSize)
                throw new StackOverflowException();
            if (LastIndex == MaxSize)
                LastIndex = 0;
            _Queue[LastIndex] = x;
            LastIndex++;
            len++;
        }
        public T Pop()
        {
            if (FirstIndex == MaxSize)
                FirstIndex = 0;
            if (Length == 0)
                throw new Exception();
            T x = _Queue[FirstIndex];
            FirstIndex++;
            len--;
            //for(int i=1;i<LastIndex;i++)
            //    _Queue[i-1] = _Queue[i];
            return x;
        }
        public bool IsEmpty()
        {
            return Length == 0;
        }
        public void Clear()
        {
            LastIndex = 0;
            FirstIndex = 0;
            len=0;
        }
        public void Print()
        {
            if (len == 0)
                Console.WriteLine(0);
            else
                if (LastIndex + len < MaxSize)
                for (int i = LastIndex; i < LastIndex + len; i++)
                    Console.Write($"{_Queue[i]} ");
            else
            {
                for (int i = LastIndex; i < MaxSize; i++)
                    Console.Write($"{_Queue[i]} ");
                for (int i = 0; i < LastIndex + len - MaxSize; i++)
                    Console.Write($"{_Queue[i]} ");
            }
            Console.WriteLine();
        }
    }
}
