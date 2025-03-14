using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Contexts.HumanCapital.Config
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(new Employee
            {
                Id = new Guid("b021659e-12c6-4b2c-aaa2-f73c355a6c59"),
                Name = "Marwan",
                Age = 25,
                CompanyId = new Guid("66569d54-aa5a-45d1-8bb9-5ed060878141")
            },
            new Employee
            {
                Id = new Guid("28266870-0b42-4c46-92a9-babb17905ecd"),
                Name = "Mohamed",
                Age = 31,
                CompanyId = new Guid("66569d54-aa5a-45d1-8bb9-5ed060878141")
            },
            new Employee
            {
                Id = new Guid("4ebfba95-2575-473d-9287-051a15ed45fd"),
                Name = "Rahaf",
                Age = 26,
                CompanyId = new Guid("aa329c6c-8bac-4ab7-b4a8-c78edf73ef46")
            });
        }
    }
}
