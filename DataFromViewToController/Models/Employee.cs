using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //for validations

namespace DataFromViewToController.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please enter your first name")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email{ get; set; }
        [Required]
        [Range(0,10)]
        public int Age { get; set; }
    }
}