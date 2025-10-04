using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS23MethodOverload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CheckData(int value, string value2)
        {
            // 処理
        }

        // オーバーロード
        public void CheckData(string value, string value2)
        {
            // 処理
        }

        public int GetData()
        {
            return 1;
        }
    }
}
