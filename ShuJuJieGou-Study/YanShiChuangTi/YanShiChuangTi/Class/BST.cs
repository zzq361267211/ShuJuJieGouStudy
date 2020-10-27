using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace ShuJuJieGouStudy
{
    class BST<E> where E : IComparable
    {
        public class Node
        {

            public E e;
            public Node left, right;
            public Node(E e)
            {
                this.e = e;
                left = null;
                right = null;
            }
        }

        private Node root;
        private int size;
        public BST()
        {
            root = null;
            size = 0;
        }
        public int GetSize()
        {
            return size;
        }
        public void Add(E e)
        {
            root = Add(root, e);
        }
        private Node Add(Node node,E e)
        {
             if (node==null)
            {
               Node ret= new Node(e);
                size++;
                return ret;
            }
            

            if (e.CompareTo(node.e)<0)
            {
               node.left= Add(node.left, e);
                
            }
           else if (e.CompareTo(node.e) > 0 )
            {
                node.right = Add(node.right, e);
            }
           
                return node;
           
        }

        public bool Contains(E e)
        {
            bool isContains=false;
           return Contains(root, e);
        }
        public bool Contains(Node node,E e)
        {
            if (node==null)
            {
                return false;
            }
            if (e.CompareTo(node.e)==0)
            {
                return true;
            }
            else if(e.CompareTo(node.e) < 0)
            {
                return Contains(node.left, e);
            }
            else 
            {
                return Contains(node.right, e);
            }

        }
    }
}
