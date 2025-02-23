using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces.Services;
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

        async Task<IList<Employee>> IEmployeeService.GetAllEmployees()
        {
            var employees = await _employeeRepository.GetAllEmployees();
            return employees;
        }
    }
}
