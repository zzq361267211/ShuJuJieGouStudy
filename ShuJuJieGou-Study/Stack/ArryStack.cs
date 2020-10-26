using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShuJuJieGouStudy
{
    class ArryStack<E> : IStack<E>
    {
        int size;
        int capacity;
        public int Size
        {
            get
            {
                return array.Size;
            }
        }
        public int Capacity
        {
            get
            {
                return array.Capacity;
            }
        }

        Array<E> array = new Array<E>();
        public ArryStack(int capacity)
        {
            array = new Array<E>(capacity);
        }
        public ArryStack()
        {
            array = new Array<E>(10);
        }

        public void Push(E e)
        {
            array.AddLast(e);
        }

        public E Pop()
        {
            return array.RemoveLast();
        }

        public E Peek()
        {
            return array.GetLast();
        }

        public bool IsEmpty()
        {
            return array.IsEmpty();
        }

        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("ArrayStack: size={0},capacity={1}\n", array.Size, array.Capacity));
            res.Append('[');
            for (int i = 0; i < array.Size; i++)
            {
                res.Append(array.Get(i));
                if (i!= array.Size - 1)
                {
                    res.Append(", ");
                }
            }
            res.Append("]  top");
            return res.ToString();
        }


    }
}
