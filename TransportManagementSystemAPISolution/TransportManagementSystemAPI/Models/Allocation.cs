using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystemAPI.Models
{
    public class Allocation
    {
        [Key]
        public int AllocationId { get; set; }
        [Required(ErrorMessage = "Please enter the Employee Id")]
        [ForeignKey("employee")]
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
        [Required(ErrorMessage = "Please enter the Location")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please enter the Route Number")]
        [ForeignKey("routes")]
        public int RouteNumber { get; set; }
        public Route routes { get; set; }
        [Required(ErrorMessage = "Please enter the Vehicle Number")]
        [ForeignKey("Vehicles")]
        public string VehicleNumber { get; set; }
        public Vehicle Vehicles { get; set; }

    }


}
