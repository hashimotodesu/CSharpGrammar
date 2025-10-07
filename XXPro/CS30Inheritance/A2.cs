using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS30Inheritance
{
    internal class A2 : A1
    {
        // コンストラクタ
        public A2(int value) : base(value) //baseが先に動く
        {
            base.ProtectedValue = value;
        }
    }
}
