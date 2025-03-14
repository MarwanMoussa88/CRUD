using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(60, ErrorMessage = "Name Must be less than 60 characters")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Address is Required")]
        [MaxLength(60, ErrorMessage = "Address Must be less than 60 characters")]
        public string Address { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
