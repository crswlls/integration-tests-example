using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using OrgChart;

namespace ViewModels
{
    public class AddEmployeeViewModel
    {
        private readonly IOrgRepository _orgRepo;
        private RelayCommand<Employee> _addEmployeeCommand;
        private Organisation _org;

        public ObservableCollection<Employee> PossibleSuperiors
        {
            get
            {
                return new ObservableCollection<Employee>(Org.GetAllEmployees());
            }
        }

        public string NewEmployeeName { get; set; }

        public AddEmployeeViewModel(IOrgRepository orgRepo)
        {
            _orgRepo = orgRepo;
        }

        private Organisation Org
        {
            get
            {
                _org = _org ?? _orgRepo.GetOrganisation();
                return _org;
            }
        }

        public RelayCommand<Employee> AddEmployeeCommand
        {
            get
            {
                return _addEmployeeCommand ?? (_addEmployeeCommand = new RelayCommand<Employee>(OnAddEmployee));
            }
        }

        private void OnAddEmployee(Employee manager)
        {
            manager.AddNewSubordinate(new Employee(NewEmployeeName));
        }
    }
}