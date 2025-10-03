using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS21Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer("小野");
            MessageBox.Show(customer.GetFullName());

            Customer customer2 = new Customer("潤一郎", "稲本");
            MessageBox.Show(customer2.GetFullName());
        }
    }
}
