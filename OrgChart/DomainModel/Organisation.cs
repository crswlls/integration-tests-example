using System.Collections.Generic;

namespace OrgChart
{
    public class Organisation : IVisitable
    {
        public HeadOfOrg Ceo { get; }

        public Organisation(HeadOfOrg ceo)
        {
            Ceo = ceo;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var employeeVisitor = new AllEmployeesVisitor();
            ((IVisitable)this).Accept(employeeVisitor);
            return employeeVisitor.GetEmployees();
        }

        void IVisitable.Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            ((IVisitable)Ceo).Accept(visitor);
        }
    }
}