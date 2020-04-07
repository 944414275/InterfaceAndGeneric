using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest1.Car
{
    public class FordCar : ICar
    {
        private static int Speed;
        public void Engine(int value)
        {
            int Row = value * 300;
            Speed = Row / 15;
        }

        public void Run()
        {
            Console.WriteLine("福特车正以{0}码的速度行驶！", Speed);
        }
    }
}
