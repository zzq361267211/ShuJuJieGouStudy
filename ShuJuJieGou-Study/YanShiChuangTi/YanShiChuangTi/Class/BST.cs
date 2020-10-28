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
        /// <summary>
        /// 最常用
        /// </summary>
        public void PreOrder()
        {
            PreOrder(root);
        }
        public void PreOrder(Node node)
        {
            if (node==null)
            {
                return;
            }

            Console.WriteLine(node.e.ToString());
            PreOrder(node.left);
            PreOrder(node.right);
        }
        /// <summary>
        /// 返回有序的结果
        /// </summary>
        public void InOrder()
        {
            InOrder(root);
        }
        public void InOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            InOrder(node.left);
            Console.WriteLine(node.e.ToString());
            InOrder(node.right);
        }
        /// <summary>
        /// 优先处理孩子节点
        /// </summary>
        public void PostOrder()
        {
            PostOrder(root);
        }
        public void PostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PostOrder(node.left);            
            PostOrder(node.right);
            Console.WriteLine(node.e.ToString());
        }
    }
}
