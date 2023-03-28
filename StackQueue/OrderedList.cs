using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class Elem
    {
        public int Info { get; set; }
        public Elem Next { get; set; }

        public Elem(int info)
        {
            this.Info = info;
        }
    }


    public class OrderedList
    {
        private Elem First { get; set; }

        public int Count
        {
            get
            {
                int k = 0;
                var el = First;
                while (el != null)
                {
                    k++;
                    el = el.Next;
                }
                return k;
            }
        }

        public OrderedList(int first)
        {
            First = new Elem(first);
        }

        public OrderedList()
        {
            First = null;
        }

        void AddFirst(int info)
        {
            var el = new Elem(info);
            el.Next = First;
            First = el;
        }

        void AddLast(int info)
        {
            if (First == null)
            {
                AddFirst(info);
                return;
            }

            var el = First;
            while (el.Next != null)
            {
                el = el.Next;
            }
            el.Next = new Elem(info);
        }

        public void DeleteFirst()
        {
            if (First == null)
                return;

            First = First.Next;
        }

        public void DeleteLast()
        {
            if (First == null)
                return;
            if (First.Next == null)
            {
                DeleteFirst();
                return;
            }
            var el = First;
            while (el.Next.Next != null)
            {
                el = el.Next;
            }
            el.Next = null;
        }

        public void Delete(int info)
        {
            if (First.Info == info)
            { 
                DeleteFirst();
                return;
            }
            
            if (First != null)
                for(Elem el=First;el!=null;el=el.Next)
                {
                    if (el.Next != null)
                    {
                        if (el.Next.Info == info)
                        {
                            var el2 = el.Next.Next;
                            el.Next = el2;
                            return;
                        }
                    }
                    else
                    {
                        if (el.Info == info)
                        { 
                            DeleteLast();
                            return;
                        }
                    }
                }
        }

        public bool Find(int info)
        {
            if (First.Info == info)
            {
                return true;
            }

            if (First != null)
                for (Elem el = First; el != null; el = el.Next)
                {
                    if (el.Next != null)
                    {
                        if (el.Next.Info == info)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (el.Info == info)
                        {
                            return true;
                        }
                    }
                }
            return false;
        }



        public void Add(int info)
        {
            if (First == null) 
            { 
                AddFirst(info);
                return;
            }
            var el = First;
            if (info<el.Info)
            {
                First= new Elem(info);
                First.Next = el;
                return;
            }
            while (el != null)
            {
                if (el.Next != null)
                {
                    if (el.Info <= info && el.Next.Info >= info)
                    {
                        var el2 = new Elem(info);
                        el2.Next = el.Next;
                        el.Next = el2;
                        return;
                    }
                }
                else
                {
                    AddLast(info);
                    return;
                }
                el = el.Next;
            }

        }

        public void Merge(OrderedList ol)
        {
            var item1=First;
            var item2 = ol.First;
            bool end = true;
            Elem prev = item2;
            while (item2 != null)
            {
                Elem item3 = item2.Next;
                if (item1.Next == null)
                {
                    item1.Next = prev;
                }
                prev = item2;
                if (item1==First && item1.Info > item2.Info)
                {
                    item2.Next= First;
                    First = item2;
                }               
                else while (item1.Next!=null && item2.Info > item1.Next.Info)
                {
                    item1= item1.Next;
                }
                if (item1.Next != null && item2.Info < item1.Next.Info)
                {
                    item2.Next = item1.Next;
                    item1.Next = item2;
                }
                item2 = item3;
            }
            return;
        }

        /*
         public void Merge(MyOrderedList<T> list2)
        {
            var firstListNode = list.First;
            var secondListNode = list2.list.First;
            if (firstListNode.Next.Value.CompareTo(secondListNode.Value) > 0)
            {
                var tempNode = firstListNode;
                firstListNode = secondListNode;
                secondListNode = tempNode;
            }
            list.First = firstListNode;
            while (firstListNode.Next != null && secondListNode.Next != null)
            {
                if (firstListNode.Next.Value.CompareTo(secondListNode.Value) < 0)
                {
                    firstListNode = firstListNode.Next;
                }
                else
                {
                    var tempNode1 = firstListNode.Next;
                    var tempNode2 = secondListNode.Next;
                    firstListNode.Next = secondListNode;
                    firstListNode = firstListNode.Next;
                    secondListNode = tempNode2;
                }
            }
            firstListNode.Next = secondListNode;
        }
         */






        Elem Insert(Elem el1,Elem el2)
        {
            el2.Next = el1.Next;
            el1.Next = el2;
            return el1;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var el = First;
            while (el != null)
            {
                sb.Append($"{el.Info.ToString()} -> ");
                el = el.Next;
            }
            return sb.ToString();
        }

    }
}
