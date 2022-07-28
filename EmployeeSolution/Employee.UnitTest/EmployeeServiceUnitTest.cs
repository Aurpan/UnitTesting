using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using EmployeeSolution.AdditionalClasses;
using NMock;

namespace Employee.UnitTest
{
    [TestFixture]
    public class EmployeeServiceUnitTest
    {
        private MockFactory mocksFactory;
        private Mock<IEmployeeRepository> mockEmployeeRepository;
        private EmployeeService employeeService;

        [SetUp]
        public void Setup()
        {
            mocksFactory = new MockFactory();
            mockEmployeeRepository = mocksFactory.CreateMock<IEmployeeRepository>();
            employeeService = new EmployeeService(mockEmployeeRepository.MockObject);
        }

        [Test]
        public void GetEmployeeSalary_GivenWorkingHourAndId_ShouldReturnSalary()
        {
            // Arrange
            double workingHour = 10;
            int employeeId = 0;
            double expectedSalaryPerHour = 3;

            mockEmployeeRepository.Expects.One.MethodWith(x => x.EmployeeSalaryPerHour(employeeId))
                .WillReturn(expectedSalaryPerHour);
            
            // Act
            var result = employeeService.GetEmployeeSalary(employeeId, workingHour);
            
            // Assert
            Assert.AreEqual(30, result);
            mocksFactory.VerifyAllExpectationsHaveBeenMet();
        }

        [Test]
        public void GetEmployeeSalaryWithBonus_GivenWorkingHourAndId_ShouldReturnSalaryWithBonus()
        {
            // Arrange
            int employeeId = 1;
            double workingHour = 10, expectedBonusAmount = 5000, expectedSalaryPerHour = 550;

            mockEmployeeRepository.Expects.One.Method(x => x.EmployeeBonusAmount(employeeId)).With(employeeId)
                .WillReturn(expectedBonusAmount);

            mockEmployeeRepository.Expects.One.MethodWith(x => x.EmployeeSalaryPerHour(employeeId))
                .WillReturn(expectedSalaryPerHour);
            

            // Act
            var result = employeeService.GetEmployeeSalaryWithBonus(employeeId, workingHour);


            // Assert
            Assert.AreEqual(10500, result);
            mocksFactory.VerifyAllExpectationsHaveBeenMet();

        }

        [Test]
        public void TestMethod_ShouldThrowException()
        {
            mockEmployeeRepository.Expects.One.Method(x => x.EmployeeSalaryPerHour(1))
                .Will(Throw.Exception(new Exception("Invalid Employee")));

            //mockEmployeeRepository.Expects.One.SetProperty(x => ).To(true);
        }
    }
}
