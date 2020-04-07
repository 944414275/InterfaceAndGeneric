using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISwitch control = new Light("CL0001");
            control.On();
            control.Off();

            control = new Tv("TV0002");
            control.On();
            control.Off();

            Console.ReadLine(); 
        }
    }

    public interface ISwitch
    {
        // public  void On();//接口不能有修饰符
        void On();
        void Off();
        int myint();
        //  public  int a;//接口不能包含方法（属性、索引）之外的成员
    }
    public class Light : ISwitch
    {
        private string id;
        public string Id { get { return id; } }
        public Light(string _id) { this.id = _id; }
        public void On()
        {
            Console.WriteLine("电灯开了");
        }
        public void Off()
        {
            Console.WriteLine("电灯关了");
        }
        public int myint()
        {
            return 0;
        }
    }
    public class Tv : ISwitch
    {
        private string type;
        public string Type { get { return type; } }
        public Tv(string _type) { this.type = _type; }
        public void On()
        {
            Console.WriteLine("电视开了");
        }
        public void Off()
        {
            Console.WriteLine("电视关了");
        }

        public int myint()
        {
            return 0;
        }
    }
//————————————————
//版权声明：本文为CSDN博主「ClementQL」的原创文章，遵循 CC 4.0 BY-NC-SA 版权协议，转载请附上原文出处链接及本声明。
//原文链接：https://blog.csdn.net/CQL_K21/article/details/87566771
}
