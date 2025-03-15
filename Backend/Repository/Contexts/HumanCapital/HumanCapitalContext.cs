using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts.HumanCapital.Config;

namespace Repository.Contexts.HumanCapitalContext
{
    public class HumanCapitalContext : DbContext
    {
        public HumanCapitalContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}
