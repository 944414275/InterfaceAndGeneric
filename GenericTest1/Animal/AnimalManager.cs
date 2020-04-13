using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace GenericTest1.Animal
{
    public class AnimalManager
    {
        ContainerBuilder _builder = new ContainerBuilder();

        public void InitialAuto()
        {
            _builder.RegisterType<Cat>();
            _builder.RegisterType<Dog>();
            _builder.RegisterType<Person>();


        }

        IContainer container;
        IContainer Container
        {
            get
            {
                if(container==null)
                {
                    container = _builder.Build();
                }
                return container;
            }
        }

        public T GetT<T>()
        {
            T t = Container.Resolve<T>();
            return t;

        }


    }
}
