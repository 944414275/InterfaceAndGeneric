/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:WpfApp1"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;

namespace WpfApp1.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<Dog>(()=>new Dog());
            SimpleIoc.Default.Register<Cat>();
            SimpleIoc.Default.Register<Person>();
            //SimpleIoc.Default.Register<IAnimal>();
        }

        //public MainViewModel Main
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<MainViewModel>();
        //    }
        //}

        public Dog Dog => ServiceLocator.Current.GetInstance<Dog>();
        public Cat Cat => ServiceLocator.Current.GetInstance<Cat>();
        public Person Person => ServiceLocator.Current.GetInstance<Person>();

        //public IAnimal Animal => ServiceLocator.Current.GetInstance<IAnimal>();
        ////public Dog Dog
        ////{
        ////    get
        ////    {
        ////        return ServiceLocator.Current.GetInstance<Dog>();
        ////    }
        ////}

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}