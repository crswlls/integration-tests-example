using OrgChart;

namespace IntegrationTests
{
    public class OrgRepositoryStub : IOrgRepository
    {
        private Organisation _orgRepositroy;

        public Organisation GetOrganisation()
        {
            return _orgRepositroy;
        }

        public void StoreOrganisation(Organisation org)
        {
            _orgRepositroy = org;
        }
    }
}

