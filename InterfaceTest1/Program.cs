using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Person person = new Person();

            UseInterface useInterface = new UseInterface();
            useInterface.Use(dog);
            useInterface.Use(cat);
            useInterface.Use(person);
            Console.ReadLine(); 
        }
    }

    class UseInterface
    {
        public void Use(Animal animal)
        {
            animal.Property();
        }
    }

    public interface Animal
    {
        void Property();
    }

    class Dog : Animal
    {
        public void Property()
        {
            Console.WriteLine("i am a dog!");
        }
    }

    class Cat : Animal
    {
        public void Property()
        {
            Console.WriteLine("i am a cat!");
        }
    }

    class Person : Animal
    {
        public void Property()
        {
            Console.WriteLine("i am a person!");
        }
    }
}
