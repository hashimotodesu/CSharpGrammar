using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS32Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IDatabase product = new Product();
            IDatabase order = new Order();

            List<IDatabase> list = new List<IDatabase>();
            list.Add(product);
            list.Add(order);

            foreach(var database in list)
            {
                database.Save();
            }
        }
    }
}
