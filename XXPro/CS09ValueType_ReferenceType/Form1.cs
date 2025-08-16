using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS09ValueType_ReferenceType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }


        // 値型
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            MessageBox.Show("a=" + a);
            MessageBox.Show("b=" + b);

            a = b;
            MessageBox.Show("a=" + a);
            MessageBox.Show("b=" + b);

            b = 30;
            MessageBox.Show("a=" + a);
            MessageBox.Show("b=" + b);
        }

        //参照型
        private void button2_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            Other b = new Other();

            a.Value = 10;
            b.Value = 20;
            MessageBox.Show("a=" + a.Value);
            MessageBox.Show("b=" + b.Value);

            a = b; //aのアドレスをbのアドレスに変更
            MessageBox.Show("a=" + a.Value);
            MessageBox.Show("b=" + b.Value);

            b.Value = 30;
            MessageBox.Show("a=" + a.Value);　//bのアドレスを参照するので30になる
            MessageBox.Show("b=" + b.Value);
        }

        public class Other
        {
            public int Value;
        }

        //参照型 引数
        private void button3_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            a.Value = 10;
            OtherMethod(a);
            MessageBox.Show("a=" + a.Value);
        }

        private void OtherMethod(Other other)
        {
            other.Value = 55;
        }

        // 値型 引数
        private void button4_Click(object sender, EventArgs e)
        {
            int a = 10;
            ValueMethod(a);
            MessageBox.Show("a=" + a);
        }

        private void ValueMethod(int other)
        {
            other = 55;
        }
    }
}
