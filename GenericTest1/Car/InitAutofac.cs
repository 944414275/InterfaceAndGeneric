using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace GenericTest1.Car
{
    public static class InitAutofac
    {
        static ContainerBuilder _builder;//声明容器
        public static void InitAutofacs()
        {
            //如果一个类型被多次注册,以最后注册的为准。通过使用PreserveExistingDefaults() 修饰符，可以指定某个注册为非默认值。
            _builder = new ContainerBuilder();//实例化
            _builder.RegisterType<AudiCar>().As<ICar>();//将需要用到的奥迪车注册到容器中
            //_builder.RegisterType<BenzCar>().As<ICar>().PreserveExistingDefaults();//将需要用到的奔驰车注册到容器中
            _builder.RegisterType<BenzCar>().As<ICar>();

            
        }

        static IContainer _container;//声明一个字段这个字段用来对接容器
        static IContainer Container
        {
            get
            {
                if (_container == null)
                    _container = _builder.Build();
                return _container;
            }
        }

        public static T GetFromFac<T>()
        {
            T t = Container.Resolve<T>();
            return t;
        }
    }
}
