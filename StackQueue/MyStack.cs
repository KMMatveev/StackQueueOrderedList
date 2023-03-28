using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StackQueue
{
    internal class MyStack<T>
    {
        int MaxSize { get; set; }
        T[] _Stack { get; set; }
        //public int[] Stack 
        //{
        //    get { return _Stack; } 
        //    set { _Stack = value; }
        //}
        int LastIndex { get; set; }
        T Max { get; set; } = default(T);
        public int Length
        {
            get { return LastIndex; }
        }


        public MyStack(int maxSize)
        {
            MaxSize = maxSize;
            _Stack = new T[maxSize];
            LastIndex = 0;
        }

        public void Push(T x)
        {
            if (LastIndex == MaxSize)
                throw new StackOverflowException();
            _Stack[LastIndex] = x;
            LastIndex++;
        }
        public T Pop()
        {
            if (LastIndex == 0)
                throw new IndexOutOfRangeException();
            T x = _Stack[LastIndex-1];
            LastIndex--;
            return x;
        }
        public bool IsEmpty()
        {
            return (LastIndex == 0);
        }
        public void Clear()
        {
            LastIndex = 0;
        }

         int FindMax()
        {
            T max = _Stack[0];
            for(int i=1; i < LastIndex;i++)
            {
                //if (_Stack[i]>max) max= _Stack[i];
            }



            return (0);
        }


    }
}
