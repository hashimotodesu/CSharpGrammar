using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS24Field
{
    public partial class Form1 : Form
    {
        //フィールドにはアンダーバーをつける
        private int _value = 0;

        // フィールドで型推論は使えない

        public Form1()
        {
            InitializeComponent();
        }

        private void GetData()
        {

            var aaa = new List<int>(); //varは型推論（型推論はメソッド内のみ利用できる）
            var value = 0; //ローカル変数はアンダーバーつけない

            _value = 1;
        }
    }
}
