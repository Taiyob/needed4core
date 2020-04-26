using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }
        [StringLength(150)]
        [Display(Name = "Employee Designation")]
        public string Designation { get; set; }

        [MinLength(3)]
        [StringLength(100)]
        [Display(Name = "Department")]
        public string Department { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Range(18,30)]
        [Display(Name = "Age")]
        public string Age { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Birth Of Date")]
        public DateTime BirthDate { get; set; }
    }
}
