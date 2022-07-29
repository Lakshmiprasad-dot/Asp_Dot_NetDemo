using System;
using System.ComponentModel.DataAnnotations;
namespace Asp_Dot_NetDemo.Areas.Demos.ViewModels
{
    public class EmployeeViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty" )]
        [MaxLength(80)]
        [MinLength(2)]
        public string EmployeeName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Range(minimum:0, maximum:200000,ErrorMessage ="{0} has to be between {1} and {2}")]
        public decimal Salary { get; set; }
        public bool IsEnabled { get; set; }
    }
}
