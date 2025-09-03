using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS10DataConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d1 = 1.9d;
            int aaa = (int)d1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = "10";
            int intValue = int.Parse(value);

            //例外
            //string value = "aaa";
            //int intValue = int.Parse(value);

            //例外
            //string value = "10.4";
            //int intValue = int.Parse(value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = "10";
            int intValue;
            bool result = int.TryParse(value, out intValue);

            string value2 = "10";
            int intValue2;
            bool result2 = int.TryParse(value2, out intValue2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string value = "10";
            int intValue = Convert.ToInt32(value);

            //例外
            //string value = "10.4";
            //int intValue = Convert.ToInt32(value);

            string valueNull = null;
            int intValueNull = Convert.ToInt32(valueNull);
        }
    }
}
