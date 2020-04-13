using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest1
{
    public class Dog : IAnimal
    {
        public void Property()
        {
            Console.WriteLine("I am a dog");
        }
    }
}
