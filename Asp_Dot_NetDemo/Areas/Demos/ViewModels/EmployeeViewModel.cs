using System;
using System.ComponentModel.DataAnnotations;
namespace Asp_Dot_NetDemo.Areas.Demos.ViewModels
{
    public class EmployeeViewModel
    {
        [Display(Name = "Employee ID:")]
        [Required]
        public int ID { get; set; }
        [Display(Name = "Employee Name:")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [MaxLength(80, ErrorMessage = "{0} cannot be more than 80")]
        [MinLength(2, ErrorMessage = "{0} cannot be less than 2")]
        public string EmployeeName { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        public decimal Salary { get; set; }
        public bool IsEnabled { get; set; }
    }
}