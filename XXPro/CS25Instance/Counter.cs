using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS25Instance
{
    internal class Counter
    {
        private int _count = 0;

        public Counter(int count)
        {
            _count = count;
        }

        public void Call()
        {
            _count++;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
