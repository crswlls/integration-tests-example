using OrgChart;

namespace IntegrationTests
{
    public class OrgBuilder
    {
        public Organisation Org { get; set; }

        public void Build()
        {
            var boss = new HeadOfOrg("A");
            var b = new SeniorLeader("B");
            var c = new SeniorLeader("C");
            var d = new SeniorLeader("D");
            var e = new Employee("E");

            var f = new Employee("F");
            var g = new Employee("G");
            var h = new Employee("H");
            var i = new Employee("I");

            c.AddNewSubordinate(f);
            c.AddNewSubordinate(g);
            c.AddNewSubordinate(h);
            e.AddNewSubordinate(i);
            boss.AddNewSubordinate(b);
            boss.AddNewSubordinate(c);
            boss.AddNewSubordinate(d);
            boss.AddNewSubordinate(e);
            Org = new Organisation(boss);

            SetupHelper.OrgRepositoryStub.StoreOrganisation(Org);
        }
    }
}

