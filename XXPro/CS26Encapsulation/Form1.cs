using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS26Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var counter = new Counter(100);
            counter.Call();
        }
    }
}
