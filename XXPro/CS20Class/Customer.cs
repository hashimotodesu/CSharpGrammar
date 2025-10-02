using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20Class
{
    internal class Customer
    {
        // データ
        public string FirstName;
        public string LastName;

        // 処理
        public string GetFullName()
        {
            return LastName + FirstName;
        }
    }
}
