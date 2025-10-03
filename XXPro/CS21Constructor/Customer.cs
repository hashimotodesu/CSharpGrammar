using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS21Constructor
{
    internal class Customer
    {
        // データ
        public string FirstName;
        public string LastName;

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //コンストラクタイニシャライザー
        public Customer(string lastName) : this("--", lastName)
        {
        }

        // 処理
        public string GetFullName()
        {
            return LastName + FirstName;
        }
    }
}
