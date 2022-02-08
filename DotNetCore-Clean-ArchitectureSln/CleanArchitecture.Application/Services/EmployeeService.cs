using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        EmployeeViewModel IEmployeeService.GetAllEmployees()
        {
            Task<IEnumerable<Employee>> empTask = Task.Run(() => _employeeRepository.GetAllEmployees());
            EmployeeViewModel employeeViewModel = new EmployeeViewModel() { Employees =empTask.Result };
            return employeeViewModel ?? null;
        }
    }
}
