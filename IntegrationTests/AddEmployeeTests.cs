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
        } 

        [Test]
        public void WhenIAddAnEmployeeItIsAddedToTheListOfPossibleSuperiors()
        {
            // GIVEN I am on the Add Employee view
            var builder = new OrgBuilder();
            builder.Build();

            // WHEN I add a new employee
            var employeeName = "NewEmployee";
            var newEmployeesBoss = ViewModelLocator.AddEmployeeVm.PossibleSuperiors[0];
            ViewModelLocator.AddEmployeeVm.NewEmployeeName = employeeName;
            ViewModelLocator.AddEmployeeVm.AddEmployeeCommand.Execute(newEmployeesBoss);

            // THEN The new employee is added to the list of possible superiors
            Assert.IsTrue(ViewModelLocator.AddEmployeeVm.PossibleSuperiors.Any(x => x.Name.Equals(employeeName)), $"Expected {employeeName} in possible superiors");

        }
    }
}

