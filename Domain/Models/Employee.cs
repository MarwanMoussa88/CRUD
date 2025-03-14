using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }
        [MaxLength(60, ErrorMessage = "Age must be less than 60")]
        [Required(ErrorMessage = "Age is required")]
        public required int Age { get; set; }
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
