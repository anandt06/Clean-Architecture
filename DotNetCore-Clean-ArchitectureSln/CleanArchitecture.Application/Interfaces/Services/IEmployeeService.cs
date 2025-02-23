using CleanArchitecture.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Services
{
    public interface IEmployeeService
    {
        public Task<IList<Employee>> GetAllEmployees();

    }
}
