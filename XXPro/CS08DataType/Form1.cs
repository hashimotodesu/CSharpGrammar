using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //値型
            //https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/value-types

            //整数数値型
            //https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
            byte byteValue = 255; // 0 ～ 255
            short shortValue = 32767; // -32,768 ～ 32,767
            int intValue = 2147483647; // -2,147,483,648 ～ 2,147,483,647
            long longValue = 9223372036854775807;　// -9,223,372,036,854,775,808 ～ 9,223,372,036,854,775,807
            // その他の整数数値型はリンクを参照

            //浮動小数点数値型
            //https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            float floatValue = 1.2345f; // 最大 6 ～ 9 桁
            double doubleValue = 1.2345d; // 最大 15 ～ 17 桁
            decimal decimalValue = 1.2345m; // 28 ～ 29 桁の数字

            //その他の値型は以下を参照
            //https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/built-in-types

            //参照型
            //https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/reference-types
            string stringValue = "hello";

            //その他の参照型は以下を参照
            //https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/built-in-types
        }
    }
}
