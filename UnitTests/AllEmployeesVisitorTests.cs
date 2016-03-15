using NUnit.Framework;
using OrgChart;

namespace UnitTests
{
    [TestFixture]
    public class AllEmployeesVisitorTests
    {
        [Test]
        public void VisitorAddsCeosToTheEmployeeList()
        {
            // Arrange
            var ceo = new HeadOfOrg("Mr Ceo");
            var visitor = new AllEmployeesVisitor();

            // Act
            visitor.Visit(ceo);

            // Assert
            var employees = visitor.GetEmployees();
            Assert.AreEqual(1, employees.Count);
            Assert.AreEqual(ceo, employees[0]);
        }
    }
}

