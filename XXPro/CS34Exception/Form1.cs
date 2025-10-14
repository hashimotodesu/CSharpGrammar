using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS34Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = new Counter();
            c.GetData(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var c = new Counter();
                c.GetData(1);
            }
            catch (ArgumentOutOfRangeException aex)
            {
                MessageBox.Show("AAA!" + aex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ボタン２を押してエラー！！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var c = new Counter();
                c.GetData2(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}
