using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS27Property
{
    public class Counter
    {
        //private int _count = 0;

        public Counter(int count)
        {
            //SetCount(count);
            Count = count;
        }

        //public int Count
        //{
        //    get
        //    {
        //        return _count;
        //    }

        //    set
        //    {
        //        if (value >= 100)
        //        {
        //            _count = 100;
        //            return;
        //        }

        //        _count = value;
        //    }
        //}

        public int Count { get; private set; }

        public void Call()
        {
            Count++;
        }

    //    public void SetCount(int value)
    //    {
    //        if (value >= 100)
    //        {
    //            _count = 100;
    //            return;
    //        }

    //        _count = value;
    //    }

    //    public int GetCount()
    //    {
    //        return _count;
    //    }
    }
}
