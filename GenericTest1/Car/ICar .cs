using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest1.Car
{
    public interface ICar
    {
        //int Speed { set; get; }

        void Engine(int value);
        void Run();
    }
}
