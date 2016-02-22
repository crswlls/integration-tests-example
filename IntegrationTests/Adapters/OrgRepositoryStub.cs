using OrgChart;

namespace IntegrationTests
{
    public class OrgRepositoryStub : IOrgRepository
    {
        public Organisation GetOrganisation()
        {
            return null;
        }

        public void StoreOrganisation(Organisation org)
        {
        }
    }
}

