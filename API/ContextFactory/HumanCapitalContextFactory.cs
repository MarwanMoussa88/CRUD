using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Repository.Contexts.HumanCapitalContext;

namespace API.ContextFactory
{
    public class HumanCapitalContextFactory : IDesignTimeDbContextFactory<HumanCapitalContext>
    {
        public HumanCapitalContextFactory()
        {
        }

        public HumanCapitalContext CreateDbContext(string[] args)
        {
            //can't dependency inject because it needs the constructor to be parameterless 
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

            var dbContextOptions = new DbContextOptionsBuilder<HumanCapitalContext>()
                .UseSqlServer(configuration.GetConnectionString("HumanCapital"),
                assembly => assembly.MigrationsAssembly("API"));

            return new HumanCapitalContext(dbContextOptions.Options);
        }
    }
}
