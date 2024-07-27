using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreCleanArchitecture.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<IActionResult> Index()
        {
            IList<Employee> employees = await _employeeService.GetAllEmployees();

            return View(employees);
        }
    }
}
