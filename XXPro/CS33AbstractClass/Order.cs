using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS33AbstractClass
{
    public class Order : Database
    {
        protected override void Execute()
        {
            Console.WriteLine("発注テーブルの保存");
        }
    }
}
