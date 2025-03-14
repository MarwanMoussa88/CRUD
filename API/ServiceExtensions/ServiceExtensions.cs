using Contracts.Interfaces;
using Repository.Contexts.HumanCapitalContext;
using Repository.Repositories;
using Service.Contracts;
using Service.Contracts.Interfaces;
using Service.Services;

namespace API.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
        }

        public static void ConfigureHumanCapitalContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlServer<HumanCapitalContext>(
                configuration.GetConnectionString("HumanCapital"));
        }


    }
}
