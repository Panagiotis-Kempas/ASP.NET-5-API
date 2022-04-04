using EmployeeApi.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [MinLength(2,ErrorMessage ="First name must contain at least 2 characters")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender{ get; set; }
        public int DepartmentId { get; set; }
      
        public Department Department { get; set; }

    }
}
