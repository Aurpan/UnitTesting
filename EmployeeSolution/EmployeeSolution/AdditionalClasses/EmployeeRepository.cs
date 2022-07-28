using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeSolution.AdditionalClasses
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public double EmployeeSalaryPerHour(int employeeId)
        {
            double salaryPerHour = 0;

            if (employeeId == 1)
                salaryPerHour = 550.5;

            else if (employeeId == 2)
                salaryPerHour = 1050;

            return salaryPerHour;
        }

        public double EmployeeBonusAmount(int employeeId)
        {
            double bonusAmount = 0;

            if (employeeId == 1)
                bonusAmount = 5000;

            else if (employeeId == 2)
                bonusAmount = 1000;

            return bonusAmount;
        }
    }
}