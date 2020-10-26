using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShuJuJieGouStudy
{
    /// <summary>
    /// front==tail 时，为队列空
    /// （tail+1）/8==front 时队列满
    /// </summary>
    /// <typeparam name="E"></typeparam>
    class LoopQuene<E> : IQuene<E>
    {
        private E[] data;
        private int front, tail;
        private int size;

        public LoopQuene(int capacity)
        {
            data = new E[capacity];
            front = 0;
            tail = 0;
            size = 0;
        }

        public LoopQuene()
        {   
            data = new E[10];
            front = 0;
            tail = 0;
            size = 0;
        }

        public int GetCapacity()
        {
            return data.Length-1;
        }

        public bool IsEmpty()
        {
            return front == tail;
        }

        public int GetSize()
        {
            return size;
        }

        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("LoopQuene: size={0},capacity={1}\n", size, GetCapacity()));
            res.Append(" Front[");
            for (int i = front; i !=tail; i=(i+1)%data.Length)
            {
                res.Append(data[i]);
                if ((i + 1) % data.Length!=tail)
                {
                    res.Append(", ");
                }
            }
            res.Append("]  Tail");
            return res.ToString();
        }

        public void Enquene(E e)
        {
            if (front==(tail+1)%data.Length)
            {
                ReSize(GetCapacity() * 2);
                data[tail] = e;
                tail = (tail + 1) % data.Length;
                size++;
            }
            
        }

        private void ReSize(int capacity)
        {
            E[] newData = new E[capacity];
            for (int i = 0; i < size; i++)
            {
                newData[i] = data[(front + i) % data.Length];
                data = newData;
                front = 0;
                tail = size;
            }
        }
        public E Dequene()
        {
            if (IsEmpty())
            {
                throw new Exception("wei kong");
            }
            E ret = data[front];
            data[front] = default;
            front = (front + 1) % data.Length;
            size--;
            if (size==GetCapacity()/4&&GetCapacity()/2!=0)
            {
                ReSize(GetCapacity() / 2);
            }
            return ret;
        }

        public E GetFront()
        {
            if (IsEmpty()==null)
            {
                throw new Exception("wei kong");
            }
            return data[front];
        }
    }
}
