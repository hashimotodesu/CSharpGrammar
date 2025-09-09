using System;
using System.Collections.Generic; //必要
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS12List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> values = new List<int>();
            values.Add(10);
            values.Add(20);
            values.Add(50);
            values.Add(51);
            values.Add(52);

            MessageBox.Show(values.Count.ToString());
            MessageBox.Show(values[2].ToString());

            values.RemoveAt(3);

            values.Remove(20);

            values.Clear();
        }
    }
}
