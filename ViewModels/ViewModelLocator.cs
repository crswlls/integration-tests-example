using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Ioc;

namespace ViewModels
{
    public class ViewModelLocator
    {
        public static AddEmployeeViewModel AddEmployeeVm
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddEmployeeViewModel>();
            }
        }

        static ViewModelLocator()
        {
            Reset();
        }

        public static void Reset()
        {
            ServiceLocator.SetLocatorProvider (() => SimpleIoc.Default);
            SimpleIoc.Default.Register<AddEmployeeViewModel> ();
        }
    }
}

