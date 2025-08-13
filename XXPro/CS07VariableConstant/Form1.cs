using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07VariableConstant
{
    public partial class Form1 : Form
    {
        //変数
        private int _count = 0;

        //定数
        private const int AAA = 10;
        private const string key = "SJUOWOIJDIJWOJOI";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _count = _count + 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_count.ToString());
        }
    }
}
