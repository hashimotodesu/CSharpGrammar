using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS33AbstractClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Database product = new Product();
            Database order = new Order();

            List<Database> list = new List<Database>();
            list.Add(product);
            list.Add(order);

            foreach (var database in list)
            {
                database.Save();
            }
        }
    }
}
