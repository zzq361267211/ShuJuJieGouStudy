using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShuJuJieGouStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Array<String> arr = new Array<String>(5);
            for (int i = 0; i < 10; i++)
            {
                arr.AddLast(i.ToString()+"个人");
                Console.WriteLine(arr.ToString());
            }


            arr.Add(1, 100.ToString()+"个人");
            Console.WriteLine(arr.ToString());



            for (int i = 0; i < 11; i++)
            {
                arr.RemoveLast();
                Console.WriteLine(arr.ToString());
            }

        }
    }
}
