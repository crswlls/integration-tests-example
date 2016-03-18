namespace OrgChart
{
    internal interface IVisitor
    {
        void Visit(Organisation org);
        void Visit(HeadOfOrg org);
        void Visit(SeniorLeader org);
        void Visit(Employee org);
    }
}