using GalaSoft.MvvmLight.Ioc;
using OrgChart;
using ViewModels;

namespace IntegrationTests
{
    public static class SetupHelper
    {
        private static readonly OrgRepositoryStub _orgRepositoryStub = new OrgRepositoryStub();

        public static OrgRepositoryStub OrgRepositoryStub
        {
            get
            {
                return SimpleIoc.Default.GetInstance<IOrgRepository>() as OrgRepositoryStub;
            }
        }

        public static void InitialiseApp()
        {
            SimpleIoc.Default.Reset();
            ViewModelLocator.Reset();
            SimpleIoc.Default.Register<IOrgRepository>(() => _orgRepositoryStub);
        }
    }
}