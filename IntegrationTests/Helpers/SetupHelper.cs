using System;
using GalaSoft.MvvmLight.Ioc;
using ViewModels;
using OrgChart;

namespace IntegrationTests
{
    public static class SetupHelper
    {
        private static ViewModelLocator _locator;
        private static readonly OrgRepositoryStub _orgRepositoryStub = new OrgRepositoryStub();

        public static OrgRepositoryStub OrgRepositoryStub
        {
            get
            {
                return SimpleIoc.Default.GetInstance<IOrgRepository>() as OrgRepositoryStub;
            }
        }

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator;
            }
        }

        public static void InitialiseApp()
        {
            SimpleIoc.Default.Reset();
            if (_locator != null)
            {
                ViewModelLocator.Reset();
            }

            SimpleIoc.Default.Register<IOrgRepository>(() => _orgRepositoryStub);
            _locator = new ViewModelLocator();
        }
    }
}