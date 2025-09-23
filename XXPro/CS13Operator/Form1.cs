using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS13Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            i += 2; //i = i + 2;

            i -= 1; //i = i - 1;

            int a = 10 % 4; //余り。aは2になる。

            if(a == 2)
            {

            }

            if(a != 2)
            {

            }

            if(a > 2)
            {

            }

            if(a >= 2)
            {

            }

            if(a == 2 && i == 3)
            {

            }

            if (a == 2 || i == 3)
            {

            }

            //if ((a == 2 || i == 3) && a > 1)
            //{

            //}
        }
    }
}
