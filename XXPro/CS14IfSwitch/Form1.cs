using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS14IfSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            
            if (value == 10)
            {
                MessageBox.Show("10です");
            }
            else if (value == 20)
            {
                MessageBox.Show("20です");
            }
            else if (value == 21)
            {
                MessageBox.Show("21です");
            }
            else
            {
                MessageBox.Show("どれでもない");
            }

            switch (value)
            {
                case 10:
                    MessageBox.Show("10です");
                    break;
                case 11:
                    MessageBox.Show("11です");
                    break;
                case 20:
                    MessageBox.Show("20です");
                    break;
                case 21:
                    MessageBox.Show("21です");
                    break;
                default:
                    MessageBox.Show("どれでもない");
                    break;
            }
        }
    }
}
