using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS30Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var a2 = new A2(10);
            a2.GetdData();
        }
    }
}
