using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OrgChart
{
    public class Employee : IVisitable
    {
        private readonly List<Employee> _subordinates;

        public string Name { get; }

        public IEnumerable<Employee> Subordinates
        {
            get
            {
                return new ReadOnlyCollection<Employee>(_subordinates);
            }
        }

        public Employee(string name)
        {
            Name = name;
            _subordinates = new List<Employee>();
        }

        public void AddNewSubordinate(Employee employee)
        {
            _subordinates.Add(employee);
        }

        void IVisitable.Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var employee in Subordinates)
            {
                ((IVisitable)employee).Accept(visitor);
            }
        }
    }
}