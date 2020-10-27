using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShuJuJieGouStudy
{
    public class LinkedListStack<E> : IStack<E>
    {
        public int Size
        {
            get
            {
                return LinkedList.GetSize();
            }
        }

        private LinkedList<E> LinkedList;
        public LinkedListStack()
        {
            LinkedList = new LinkedList<E>();
        }


        public void Push(E e)
        {
             LinkedList.AddFirst(e);
        }

        public E Pop()
        {
            return LinkedList.RemoveFirst();
        }

        public E Peek()
        {
            return LinkedList.GetFirst();
        }

        public bool IsEmpty()
        {
            return LinkedList.IsEmpty();
        }

        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("LinkedListStack: top "));
            res.Append(LinkedList.ToString());          
            return res.ToString();
        }
    }
}
