using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShuJuJieGouStudy
{
   public class Array<E>
    {
        private E[] data;
        private int size;
        public Array(int capacity)
        {
            data = new E[capacity];
            size = 0;
        }
        public Array()
        {
            data = new E[10];
            size = 0;
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public int Capacity
        {
            get
            {
                return data.Length;
            }
            
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void AddLast(E e)
        {
            Add(size, e);
        }

        public void AddFirst(E e)
        {
            Add(0, e);
        }

        public void Add(int index, E e)
        {
            if (size == data.Length)
            {
                // throw new Exception("超出数组范围");

                ReSize();
            }
            if (index < 0 || index > size)
            {
                throw new Exception("超出数组范围");
            }
            for (int i = size - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = e;
            size++;
        }

        public String ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(String.Format("Array: size={0},capacity={1}\n", size.ToString(), data.Length.ToString()));
            res.Append('[');
            for (int i = 0; i < size; i++)
            {
                res.Append(data[i]);
                if (i != size - 1)
                {
                    res.Append(", ");
                }

            }
            res.Append(']');
            return res.ToString();
        }

       public E Get(int index)
        {
            if (index >= size)
            {
                throw new Exception("Get failed. Index is illeagal.");
            }
            return data[index];
        }

       public E GetLast()
        {
            return Get(size - 1);
        }

        public E GetFirst()
        {
            return Get(0);
        }

        void Set(int index, E e)
        {
            if (index >= size)
            {
                throw new Exception("Get failed. Index is illeagal.");
            }
            data[index] = e;
        }

        public bool Contains(E e)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].Equals(e))
                {
                    return true;
                }
            }
            return false;
        }
        public int Find(E e)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].Equals(e))
                {
                    return i;
                }
            }
            return -1;
        }

        public E Remove(int index)
        {
            if (index < 0 || index > size)
            {
                throw new Exception("超出数组范围");
            }
            E ret = data[index];
            for (int i = index+1; i < size; i++)
            {
                data[i-1] = data[i];
            }
            size--;
            if (size<=Capacity/4)
            {
                RemoveSize();
            }
            return ret;
        }

        public E RemoveFirst()
        {
            return Remove(0);        
        }

        public E RemoveLast()
        {
            return Remove(size-1);
        }

        public void RemoveElement(E e)
        {
            int index = Find(e);
            if (index!=-1)
            {
                Remove(index);
            }             
        }

        public void ReSize()
        {
            E[] newdata= new E[Capacity*2];
            for (int i = 0; i < data.Length; i++)
            {
                newdata[i] = data[i];
            }
            data = newdata;
        }

        public void RemoveSize()
        {
            E[] newdata = new E[Capacity /2];
            for (int i = 0; i < size; i++)
            {
                newdata[i] = data[i];
            }
            data = newdata;
        }
    }
}
