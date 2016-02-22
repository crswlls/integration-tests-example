namespace OrgChart
{
    public interface IOrgRepository
    {
        Organisation GetOrganisation();

        void StoreOrganisation(Organisation headOfOrg);
    }
}

