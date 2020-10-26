using System;
using System.Collections.Generic;
using System.Text;

namespace ShuJuJieGouStudy
{
  public  class LinkedList<E>
    {
        public class Node
        {
            public E e;
            public Node next;

            public Node(E e,Node next)
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

       // public Node head;
        public Node dummyHead;//虚拟头结点
        int size;
        public LinkedList()
        {
            dummyHead =new Node(default,null);
            size = 0;
        }
        
        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void AddFirst(E e)
        {
            Add(e, 0);

        }
        public void Add(E e,int index)
        {
            if (index<0||index>size)
            {
                throw new Exception("chao fanwei");
            }
            
            Node prev = dummyHead;
            for (int i = 0; i < index; i++)
            {
                prev = prev.next;

            }

            Node node = new Node(e);
            node.next = prev.next;
            prev.next = node;

            size++;

        }
        public void AddLast(E e)
        {
            Add(e, size);
        }

        public E Get(int index)
        {
            if (index<0||index>=size)
            {
                throw new Exception("suo yin chao fan wei");
            }
            Node cur = dummyHead.next;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            return cur.e;
        }
        public E GetFirst()
        {
            return Get(0);
        }
        public E GetLast()
        {
            return Get(size-1);
        }

        public void Set(E e,int index)
        {
            if (index < 0 || index >= size)
            {
                throw new Exception("suo yin chao fan wei");
            }      
            Node cur = dummyHead.next;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }       
            cur.e = e;
        }

        public bool Cotains(E e)
        {
            Node cur = dummyHead.next;
            while (cur!=null)
            {
                if (cur.e.Equals(e))
                {
                    return true;
                }
                cur = cur.next;               
            }
            return false;
        }

        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = dummyHead.next;
            while (cur != null)
            {
                res.Append(cur.ToString()+"->");
                cur = cur.next;
            }
            res.Append("NULL");
            return res.ToString();
        }

        public E Remove(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new Exception("suo yin chao fan wei");
            }
            Node prev = dummyHead;
            for (int i = 0; i < index; i++)
            {
                prev = prev.next;
            }
            
            Node ret = prev.next;
            prev.next = ret.next;
            ret.next = null;//断开了与下一节点的联系，也可以不断开
            size--;
            return ret.e;
        }

        public E RemoveFirst()
        {
            return Remove(0);
        }

        public E RemoveLast()
        {
            return Remove(size-1);
        }
    }
}
