using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS29Static
{
    internal class Counter
    {
        private static int _count = 0;
        private int _value = 0;

        internal static void Call()
        {
            _count++;
            //_value = 1   staticの変数以外はエラーになる

        }

        internal static int GetCount()
        {
            return _count;
        }
    }
}
