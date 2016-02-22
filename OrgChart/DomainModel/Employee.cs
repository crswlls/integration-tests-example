using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OrgChart
{
    public class Employee
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

        public void AddNewSubordinate(string name)
        {
            _subordinates.Add(new Employee(name));
        }
    }
}