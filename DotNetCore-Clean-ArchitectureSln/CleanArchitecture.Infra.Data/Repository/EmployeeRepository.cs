using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDbContext _dbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _dbContext = employeeDbContext;
        }
        public async Task DeleteEmployee(int id)
        {
            Employee employee = await _dbContext.Employees.SingleOrDefaultAsync(x => x.Id == id);
            _dbContext.Employees.Remove(employee);
        }

        public async Task<IList<Employee>> GetAllEmployees()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task SaveEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            await _dbContext.SaveChangesAsync();
        }
    }
}
