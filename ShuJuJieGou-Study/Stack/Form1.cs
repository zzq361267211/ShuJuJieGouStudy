using ShuJuJieGouStudy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void KuoHaoPiPei_Click(object sender, EventArgs e)
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
