using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS11Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] values = new int[3];
            values[0] = 10;
            values[1] = 20;
            values[2] = 50;
            //values[3] = 1; エラー

            int[] values2 = { 1, 2, 4 };
            MessageBox.Show(values2.Length.ToString());
        }
    }
}
