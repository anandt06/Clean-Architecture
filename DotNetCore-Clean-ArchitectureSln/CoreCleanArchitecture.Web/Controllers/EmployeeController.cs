using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CoreCleanArchitecture.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        // GET: /<controller>/
        public IActionResult Index()
        {
            //Task<EmployeeViewModel> model = _employeeService.GetAllEmployees();

            EmployeeViewModel model = _employeeService.GetAllEmployees();

            return View(model);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
