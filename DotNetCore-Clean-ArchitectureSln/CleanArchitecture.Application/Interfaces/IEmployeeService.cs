using CleanArchitecture.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IList<Employee>> GetAllEmployees();

    }
}
