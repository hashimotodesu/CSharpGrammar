using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS28Dispose
{
    public class Database:IDisposable
    {
        private SqlDataAdapter _adapter = new SqlDataAdapter();

        public void Dispose()
        {
            if (_adapter != null)
            {
                _adapter.Dispose();
            }
        }

        public void Insert()
        {
            //var connection = new SqlConnection();

            //try
            //{
            //    connection.Open();
            //    // 処理
            //}
            //finally
            //{
            //    connection.Dispose();
            //}


            using (var connection = new SqlConnection())
            using (var command = new SqlCommand())
            {
                //処理
            }
        }
    }
}
