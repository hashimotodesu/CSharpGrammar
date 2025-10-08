using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS33AbstractClass
{
    public class Product : Database
    {
        protected override void Execute()
        {
            Console.WriteLine("商品マスタの保存");
        }
    }
}
