using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new MyStack<int>(10);

            /*
            for (int i=0; i<10; i++) 
            {
                //Console.WriteLine(q.IsEmpty());
                s.Push(i);
                q.Push(i);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(q.Pop());
            }
            for (int i = 10; i > 5; i--)
            {
                q.Push(i);
            }
            //q.Print();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(q.Pop());
            }
            Console.WriteLine();
            s.Clear();
            Console.WriteLine(s.Length);  
            */

            int[] CreateMas(int len)
            {
                var r = new Random(0);
                var mas = new int[len];
                for (int i = 0; i < len; i++)
                {
                    mas[i] = r.Next(-100, 100);
                }
                return mas;
            }
            void PrintMas(int[] mas)
            {
                for (int i = 0; i < mas.Length; i++)
                    Console.Write($"{mas[i]} ");
                Console.WriteLine();
            }



            //var q = new MyQueue<int>(10);
            //var rm = CreateMas(10);
            //PrintMas(rm);
            //Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    q.Push(rm[i]);
            //}
            //int fl = 0;
            //for(int i=0; i < q.Length; i++)
            //{
            //    int x = q.Pop();
            //    if (x > 0)
            //        q.Push(x);
            //    else
            //        Console.WriteLine(x);
            //}
            //while (!q.IsEmpty())
            //{
            //    int x = q.Pop();
            //    if (x > 0)
            //        Console.WriteLine(x);
            //}


            //string Check(string chars)
            //{
            //    MyStack<char> sc = new MyStack<char>(chars.Length);
            //    string open = "({[<";
            //    string close = ")}]>";
            //    for (int i = 0; i < chars.Length; i++)
            //    {
            //        var item= '0';
            //        if (!sc.IsEmpty())
            //        {
            //            item = sc.Pop();
            //            sc.Push(item);
            //        }
            //        if (open.Contains(chars[i]))
            //            sc.Push(chars[i]);
            //        else if (close.Contains(chars[i]) && chars[i] - item<=2 && chars[i] - item >= 1)
            //                sc.Pop();
            //    }
            //    if (sc.Length == 0) return "True";
            //    else return "False";
            //}
            //string str = "({][sht[<sgtdf>]})";
            //Console.WriteLine(Check(str));



            var mass=CreateMas(20);
            OrderedList ol = new OrderedList();
            OrderedList ol2 = new OrderedList();
            PrintMas(mass);
            for(int i=0; i<mass.Length/2; i++)
            {
                ol.Add(mass[i]);
            }
            foreach (var item in mass)
            {
                ol2.Add(item);
            }

            Console.WriteLine(ol);
            Console.WriteLine(ol2);

            ol.Delete(11);
            Console.WriteLine(ol);
            Console.WriteLine(ol2);
            ol.Merge(ol2);
            Console.WriteLine(ol);
            //Console.WriteLine(ol2);


            Console.ReadKey();
        }
    }
}
