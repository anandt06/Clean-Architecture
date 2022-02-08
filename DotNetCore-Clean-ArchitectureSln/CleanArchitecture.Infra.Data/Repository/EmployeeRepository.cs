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
        private EmployeeDbContext dbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            dbContext = employeeDbContext;
        }
        public async Task DeleteEmployee(int id)
        {
            Employee employee = await dbContext.Employees.SingleOrDefaultAsync(x => x.Id == id);
            dbContext.Employees.Remove(employee);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task SaveEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            await dbContext.SaveChangesAsync();
        }
    }
}
