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
            ArrayQuene<int> arrayQuene = new ArrayQuene<int>();
            for (int i = 0; i < 10; i++)
            {
                arrayQuene.Enquene(i+1);
                Console.WriteLine(arrayQuene.ToString());
                if (i % 3 == 2)
                {
                    arrayQuene.Dequene();
                    Console.WriteLine(arrayQuene.ToString());
                }
            }

            
            
        }
    }
}
