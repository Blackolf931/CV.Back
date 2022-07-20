using CV.BLL.Interfaces;
using CV.BLL.Models;
using CV.BLL.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CV.BLL.Infraestructure
{
    public static class BLLServiceCollection
    {
        public static void AddBLLServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IGenericServices<EmployeeModel>, EmployeeServices>();
            services.AddScoped<IGenericServices<ProjectModel>, ProjectServices>();
            services.AddDALServices(configuration);
        }
    }
}
