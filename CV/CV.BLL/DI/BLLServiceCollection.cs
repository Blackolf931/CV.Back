using CV.BLL.Interfaces;
using CV.BLL.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CV.BLL.Infraestructure
{
    public static class BLLServiceCollection
    {
        public static void AddBLLServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeServices, EmployeeServices>();
            services.AddScoped<IProjectServices, ProjectServices>();
            services.AddDALServices(configuration);
        }
    }
}
