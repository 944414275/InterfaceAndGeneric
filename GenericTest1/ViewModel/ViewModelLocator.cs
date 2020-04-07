/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:GenericTest1"
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

namespace GenericTest1.ViewModel
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

            //SimpleIoc.Default.Register<MainViewModel>();

            SimpleIoc.Default.Register<Dog>();
            SimpleIoc.Default.Register<Cat>();
            SimpleIoc.Default.Register<Person>();
            SimpleIoc.Default.Register<Animal>();

        }

        //public MainViewModel Main
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<MainViewModel>();
        //    }
        //}

        public Dog DogProp
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Dog>();
            }
        }

        public Cat CatProp
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Cat>();
            }
        }

        public Person PersonProp
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Person>();
            }
        }

        //public Animal AniProp
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<Animal>();
        //    }
        //}

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}