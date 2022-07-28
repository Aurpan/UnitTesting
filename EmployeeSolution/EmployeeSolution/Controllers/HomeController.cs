using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeSolution.AdditionalClasses;

namespace EmployeeSolution.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IEmployeeService _employeeService;

        //public HomeController(IEmployeeService employeeService)
        //{
        //    _employeeService = employeeService;
        //}

        public ActionResult Index()
        {
            //var salary = _employeeService.GetEmployeeSalary(1, 40);

            //EmployeeService employeeService = new EmployeeService();
            //var salary = employeeService.GetEmployeeSalary(1, 40);

            return View();
        }

    }
}