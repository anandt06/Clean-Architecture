using CleanArchitecture.Application.Interfaces.Services;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer 
            services.AddScoped<IEmployeeService, EmployeeService>();

            //Infra.Data Layer
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
