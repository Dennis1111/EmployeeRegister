using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeRegister.Models
{
    public class Employee
    {   
        public int Id { get; set; }
        [Required]
        [Display(Name="First Name")]
        [DisplayFormat(NullDisplayText ="anonymous")]
        [StringLength(30,ErrorMessage="First Name can only be 30 characters")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        [StringLength(30, ErrorMessage = "Last Name can only be 30 characters")]
        public string LastName { get; set; }
        [Range(0,1000000)]
        public int Salary { get; set; }
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string Position { get; set; }
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string Department { get; set; }
    }   
}