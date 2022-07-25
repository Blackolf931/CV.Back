using CV.BLL.Interfaces;
using CV.BLL.Interfaces.ForeignLanguage;
using CV.BLL.Services;
using CV.BLL.Services.ForeignLanguage;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BllServiceCollection
    {
        public static void AddBllServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeServices, EmployeeServices>();
            services.AddScoped<IProjectServices, ProjectServices>();
            services.AddScoped<ISkillServices, SkillServices>();
            services.AddScoped<ISkillGroupServices, SkillGroupServices>();
            services.AddScoped<ISkillLevelServices, SkillLevelServices>();
            services.AddScoped<IForeignLanguageServices, ForeignLanguageServices>();
            services.AddScoped<ILanguageEverydayTopicServices, LanguageEverydayTopicServices>();
            services.AddScoped<ILanguageLevelServices, LanguageLevelServices>();
            services.AddScoped<ILanguageEverydayTopicServices, LanguageEverydayTopicServices>();
            services.AddDalServices(configuration);
        }
    }
}
