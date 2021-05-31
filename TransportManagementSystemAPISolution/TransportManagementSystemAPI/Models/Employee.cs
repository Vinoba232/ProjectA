using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystemAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Please enter the First Name")]
        [RegularExpression(@"^[a-zA-Z]{1,40}$",
        ErrorMessage = "Please Enter the name only with Alphabets.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter the Last Name")]
        [RegularExpression(@"^[a-zA-Z]{1,40}$",
        ErrorMessage = "Please Enter the name only with Alphabets.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter the Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter the Age")]
        [Range(5, 60,
        ErrorMessage = "The Capacity of the vehicle must be between {1} and {2}.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter the Date")]
        [Range(typeof(DateTime), "1/1/1900", "12/12/2021",
         ErrorMessage = "The Date of birth must be between {1} and {2}")]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Please enter the Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter the Location")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please enter the Phone Number")]
        [RegularExpression(@"^[0-9]{10}$",
        ErrorMessage = "Please Enter a 10 digit Phone Number")]
        public string Phone { get; set; }

    }
}
