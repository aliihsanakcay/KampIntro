using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated");
        }
    }
}
