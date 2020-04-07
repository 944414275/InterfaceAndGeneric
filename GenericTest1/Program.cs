using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GenericTest1.ViewModel;
using CommonServiceLocator;
using System.Windows;
using Autofac;
using Autofac.Builder;
using GenericTest1.Car;

namespace GenericTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            driver.Drive(4);
            


            DB dB = new DB();
            dB.Insert();
            dB.Insert("mssql");

            Console.Read(); 
        }
    }

    class UseInterface
    {
        public void Use(Animal animal)
        {
            animal.Property();
        }
    }

    public class DB
    {
        public void Insert()
        {
            DBManager.InitDBManager();
            IDAL SQL= DBManager.GetFromFac<IDAL>();
            SQL.Insert(SQL.GetType().ToString());
        }
        public void Insert(string s)
        {
            DBManager.InitDBManager();
            IDAL SQL = DBManager.GetFromFacWithName<IDAL>(s);

        }
    }

    public class Driver
    {
        public void Drive(int value)
        {
            InitAutofac.InitAutofacs();
            ICar car = InitAutofac.GetFromFac<ICar>();
            car.Engine(value);
            car.Run();
        }
    }
}
