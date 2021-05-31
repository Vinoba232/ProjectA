using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string VehicleNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

    }
}
