using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataFirstApproach.Models
{
    public partial class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Enter the Employee Name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name must consist of minimum 4 characters")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? EmpName { get; set; }
        [Required(ErrorMessage = "Enter the Employee Designation")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Designation must consist of minimum 2 characters")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? Designation { get; set; }
    }
}
