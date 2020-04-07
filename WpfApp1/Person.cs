using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Person : IAnimal
    {
        public void Property()
        {
            Console.WriteLine("I am a person!");
        }
    }
}
