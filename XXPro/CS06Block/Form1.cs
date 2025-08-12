using System.Windows.Forms;

// namespaceブロック
namespace CS06Block
{
    //classブロック
    public partial class Form1 : Form
    {
        private int _value = 0; //ブロックの外に定義した変数

        // コンストラクタブロック
        public Form1()
        {
            InitializeComponent();

            //valueM = 1;　//別ブロックの内に定義した変数-NG
        }

        // メソッドブロック
        private int GetValue()
        {
            int valueM = 111;　//ブロックの内に定義した変数
            valueM = 123;　//ブロックの内に定義した変数-OK
            _value = 2;　//ブロックの外に定義した変数-OK
            return 1;
        }

        // メソッドブロック
        private void SetValue()
        {
            MessageBox.Show("AAA");
        }
    }
}
