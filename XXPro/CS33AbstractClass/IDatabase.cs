using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS33AbstractClass
{
    public abstract class Database
    {
        public void Save()
        {
            Before();

            Execute();

            After();
        }

        protected abstract void Execute();

        private void Before()
        {

        }

        private void After()
        {

        }
    }
}
