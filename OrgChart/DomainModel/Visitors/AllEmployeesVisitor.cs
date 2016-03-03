using System.Collections.Generic;

namespace OrgChart
{
    public class AllEmployeesVisitor : IVisitor
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Visit (Organisation org)
        {
            // Nothing to do
        }

        public void Visit(HeadOfOrg ceo)
        {
            _employees.Add(ceo);
        }

        public void Visit(SeniorLeader leader)
        {
            _employees.Add(leader);
        }

        public void Visit(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}