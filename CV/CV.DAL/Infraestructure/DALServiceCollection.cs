using CV.DAL.EF;
using CV.DAL.Entities;
using CV.DAL.Interfaces;
using CV.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DALServiceCollection
    {
        public static void AddDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IGenericRepository<EmployeeEntity>, EmployeeRepository>();
            services.AddScoped<IGenericRepository<ProjectEntity>, ProjectRepository>();
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
