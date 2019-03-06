using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Employee
    {
        [Key]
        //[DatabaseGenerated(DatabaseGenberatedOption.Identity)]
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfbirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}