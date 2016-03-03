using NUnit.Framework;
using OrgChart;
using ViewModels;
using System.Linq;

namespace IntegrationTests
{
    [TestFixture]
    public class AddEmployeeTests
    {
        [SetUp]
        public void Setup()
        {
            SetupHelper.InitialiseApp();
            new OrgBuilder().Build();
        } 

        [Test]
        public void WhenIAddAnEmployeeItIsAddedToTheListOfPossibleSuperiors()
        {
            // GIVEN I am on the Add Employee view
            // WHEN I enter a new employee name
            var employeeName = "NewEmployee";
            ViewModelLocator.AddEmployeeVm.NewEmployeeName = employeeName;

            // AND I choose the employee's line manager
            var newEmployeesBoss = ViewModelLocator.AddEmployeeVm.PossibleSuperiors[0];

            // AND I add the employee to the organisation
            ViewModelLocator.AddEmployeeVm.AddEmployeeCommand.Execute(newEmployeesBoss);

            // THEN The new employee is added to the list of possible superiors
            Assert.IsTrue(ViewModelLocator.AddEmployeeVm.PossibleSuperiors.Any(x => x.Name.Equals(employeeName)), $"Expected {employeeName} in possible superiors");
        }
    }
}

