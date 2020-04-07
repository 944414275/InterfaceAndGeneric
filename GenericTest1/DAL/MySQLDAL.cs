using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest1.DAL
{
    public class MySQLDAL : IDAL
    {
        public void Insert(string commandText)
        {
            Console.WriteLine("use {0} insert text", commandText);
        }
    }
}
