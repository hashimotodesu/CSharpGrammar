using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS20Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = "伸一";
            customer.LastName = "小野";
            MessageBox.Show(customer.GetFullName());

            Customer customer2 = new Customer();
            customer2.FirstName = "潤一郎";
            customer2.LastName = "稲本";
            MessageBox.Show(customer2.GetFullName());
        }
    }
}
