using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSolution.AdditionalClasses
{
    public interface IEmployeeRepository
    {

        double EmployeeSalaryPerHour(int employeeId);
        double EmployeeBonusAmount(int employeeId);
    }
}
