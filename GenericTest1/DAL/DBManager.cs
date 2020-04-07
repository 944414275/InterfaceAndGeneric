using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GenericTest1.DAL;

namespace GenericTest1
{
    public static class DBManager
    {
        static ContainerBuilder _builder;
        public static void InitDBManager()
        {
            _builder = new ContainerBuilder();

            _builder.RegisterType<OracleDAL>().As<IDAL>();
            _builder.RegisterType<SqlDAL>().As<IDAL>();

            _builder.RegisterType<MSDAL>().Named<IDAL>("msdal");
            _builder.RegisterType<MySQLDAL>().Named<IDAL>("mysqldal");
            //_builder.RegisterType<OracleDAL>();
            //_builder.RegisterType<SqlDAL>();
            //_builder.Register<OracleDAL>(10);
            //_builder.Register<SqlDAL>(); 
        }

        static IContainer container;
        static IContainer Container
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

        public static T GetFromFac<T>()
        {
            T t = Container.Resolve<T>();
            return t;
        }

        public static T GetFromFacWithName<T>(string strName)
        {
            T t = Container.ResolveNamed<T>(strName);
            return t;
        }
    }



}
