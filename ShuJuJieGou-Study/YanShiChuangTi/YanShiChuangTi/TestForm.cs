using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShuJuJieGouStudy;


namespace ShuJuJieGouStudy
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                linkedList.AddFirst(i);
                Console.WriteLine(linkedList.ToString());
            }
            linkedList.Add(555, 2);
            Console.WriteLine(linkedList.ToString());

            linkedList.Remove( 2);
            Console.WriteLine(linkedList.ToString());
        }

        private void btn_LinkedListStack_Click(object sender, EventArgs e)
        {
            LinkedListStack<int> linkedListStack = new LinkedListStack<int>();

            for (int i = 0; i < 5; i++)
            {
                linkedListStack.Push(i);
                Console.WriteLine(linkedListStack.ToString());
            }

            linkedListStack.Pop();
            Console.WriteLine(linkedListStack.ToString());
        }

        private void btn_Array_Click(object sender, EventArgs e)
        {
            Array<String> arr = new Array<String>(5);
            for (int i = 0; i < 10; i++)
            {
                arr.AddLast(i.ToString() + "个人");
                Console.WriteLine(arr.ToString());
            }


            arr.Add(1, 100.ToString() + "个人");
            Console.WriteLine(arr.ToString());



            for (int i = 0; i < 11; i++)
            {
                arr.RemoveLast();
                Console.WriteLine(arr.ToString());
            }
        }

        private void btn_ArrayQuene_Click(object sender, EventArgs e)
        {
            ArrayQuene<int> arrayQuene = new ArrayQuene<int>();
            for (int i = 0; i < 10; i++)
            {
                arrayQuene.Enquene(i + 1);
                Console.WriteLine(arrayQuene.ToString());
                if (i % 3 == 2)
                {
                    arrayQuene.Dequene();
                    Console.WriteLine(arrayQuene.ToString());
                }
            }

        }

        private void btn_ArrayStack_Click(object sender, EventArgs e)
        {
            ArryStack<int> arryStack = new ArryStack<int>();

            for (int i = 0; i < 5; i++)
            {
                arryStack.Push(i);
                Console.WriteLine(arryStack.ToString());
            }

            arryStack.Pop();
            Console.WriteLine(arryStack.ToString());
        }
        

        private void btn_KuoHaoPiPei_Click(object sender, EventArgs e)
        {
            bool b = IsVailed(textBox1.Text);
            if (!b)
            {
                MessageBox.Show("不匹配");
            }
        }

        private bool IsVailed(string str)
        {
            ArryStack<char> arryStack = new ArryStack<char>();
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '{' || str[i] == '[' || str[i] == '(')
                {
                    arryStack.Push(str[i]);
                }
                else if (str[i] == '}' || str[i] == ']' || str[i] == ')')
                {
                    if (arryStack.IsEmpty() == true)
                    {
                        return false;
                    }
                    else if (arryStack.Peek() == '{')
                    {
                        if (str[i] == '}')
                        {
                            arryStack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (arryStack.Peek() == '[')
                    {
                        if (str[i] == ']')
                        {
                            arryStack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (arryStack.Peek() == '(')
                    {
                        if (str[i] == ')')
                        {
                            arryStack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return arryStack.IsEmpty();

        }
    }
}
