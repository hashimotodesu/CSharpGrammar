using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS30Inheritance
{
    internal class A1
    {
        private int _privateValue;
        protected int ProtectedValue;

        public A1(int value)
        {
            _privateValue = value;
        }

        public int GetdData()
        {
            return 100;
        }
    }
}
