using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS32Interface
{
    public class Product : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("商品マスタの保存");
        }
    }
}
