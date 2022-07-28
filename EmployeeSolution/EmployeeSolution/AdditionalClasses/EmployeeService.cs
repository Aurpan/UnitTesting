using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeSolution.AdditionalClasses
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public double GetEmployeeSalary(int employeeId, double workHours)
        {
            double totalSalary = 0;
            
            double salaryPerHour = _employeeRepository.EmployeeSalaryPerHour(employeeId);

            totalSalary = workHours * salaryPerHour;

            return totalSalary;
        }

        public double GetEmployeeSalaryWithBonus(int employeeId, double workHours)
        {
            double salaryPerHour = 0, bonusAmount = 0, totalSalary;

            salaryPerHour = _employeeRepository.EmployeeSalaryPerHour(employeeId);
            bonusAmount = _employeeRepository.EmployeeBonusAmount(employeeId);

            totalSalary = (workHours * salaryPerHour) + bonusAmount;

            return totalSalary;
        }
    }
}