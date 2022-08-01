using System;
using System.ComponentModel.DataAnnotations;
namespace Asp_Dot_NetDemo.Areas.Demos.ViewModels
{
    public class EmployeeViewModel1
    {
       
        [Required]
        public int ID { get; set; }
        
        public string EmployeeName { get; set; }
       
        public DateTime DateofBirth { get; set; }
        public decimal Salary { get; set; }
       
    }
}
