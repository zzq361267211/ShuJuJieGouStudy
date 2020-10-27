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
    }
}
