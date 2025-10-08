using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS32Interface
{
    public class Order : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("発注テーブルの保存");
        }
    }
}
