using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystem.Models
{
    public class Allocation
    {
        public int AllocationId { get; set; }
        public int EmployeeId { get; set; }        
        public string Location { get; set; }        
        public int RouteNumber { get; set; }        
        public string VehicleNumber { get; set; }       
    }
}
