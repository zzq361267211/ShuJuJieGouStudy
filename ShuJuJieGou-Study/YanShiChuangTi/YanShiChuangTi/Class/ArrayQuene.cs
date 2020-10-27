using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShuJuJieGouStudy
{
    class ArrayQuene<E> : IQuene<E>
    {
        Array<E> array=new Array<E>();


        public ArrayQuene() {
       
    }
        public E Dequene()
        {
          return  array.RemoveFirst();
        }

        public void Enquene(E e)
        {
            array.AddLast(e);
        }

        public E GetFront()
        {
            return array.GetFirst();
        }

        public int GetSize()
        {
            return array.Size;
        }
        public int GetCapacity()
        {
            return array.Capacity;
        }

        public bool IsEmpty()
        {
            return array.IsEmpty();
        }

        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("ArrayQuene: size={0},capacity={1}\n", array.Size, array.Capacity));
            res.Append(" Front[");
            for (int i = 0; i < array.Size; i++)
            {
                res.Append(array.Get(i));
                if (i != array.Size - 1)
                {
                    res.Append(", ");
                }
            }
            res.Append("]  Tail");
            return res.ToString();
        }

    }
}
