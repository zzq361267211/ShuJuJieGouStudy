using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ShuJuJieGouStudy
{
    class LinkedListQuene<E> : IQuene<E>
    {
        public class Node
        {
            public E e;
            public Node next;

            public Node(E e, Node next)
            {
                this.e = e;
                this.next = next;
            }
            public Node(E e)
            {
                this.e = e;
                this.next = null;
            }
            public Node()
            {
                this.e = default(E);
                this.next = null;
            }
            public string ToString()
            {
                return e.ToString();
            }
        }

        private Node head, tail;
        private int size;
        public LinkedListQuene()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public E Dequene()
        {
            if (IsEmpty())
            {
                throw new Exception("weikong");
            }
            Node ret = head;
            head = head.next;
            ret.next = null;
            
            if (head==null)
            {
                tail = null;
            }
            size--;
            return ret.e;

        }

        public void Enquene(E e)
        {
            if (tail==null)
            {
                tail= new Node(e);
                head = tail;
            }
            else
            {
                tail.next = new Node(e);
                tail = tail.next;
            }
            size++;
        }

        public E GetFront()
        {
            if (IsEmpty())
            {
                throw new Exception("weikong");
            }
            return head.e;
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("LinkedListQuene: front ");
            Node cur=head;
            while (cur!=null)
            {
                
                res.Append(cur.e.ToString()+"->");
                cur = cur.next;
            }
            res.Append("NULL tail");
            return res.ToString();
        }
    }
}
