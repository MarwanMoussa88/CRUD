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
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(new Company
            {
                Id = new Guid("aa329c6c-8bac-4ab7-b4a8-c78edf73ef46"),
                Name = "Deloitte",
                Address = "5th Settlement",
            }, new Company
            {
                Id = new Guid("66569d54-aa5a-45d1-8bb9-5ed060878141"),
                Name = "LuftBorn",
                Address = "Helioplios",
            });

        }
    }
}
