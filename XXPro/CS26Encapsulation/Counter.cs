using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS26Encapsulation
{
    public class Counter
    {
        private int _count = 0;
        private string unit = "回";

        public Counter(int count)
        {
            SetCount(count);
        }


        public void Call()
        {
            _count++;
        }

        public void SetCount(int value)
        {
            if (value >= 100)
            {
                _count = 100;
                return;
            }

            _count = value;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
