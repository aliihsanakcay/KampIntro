using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL deleted");
        }

        public void Update()
        {
            Console.WriteLine("SQL updated");
        }
    }
}
