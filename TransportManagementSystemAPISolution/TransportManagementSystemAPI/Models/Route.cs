using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystemAPI.Models
{
    public class Route
    {
        [Key]
        public int RouteNumber { get; set; }
        [Required(ErrorMessage = "Please enter the Vehicle Number")]
        [ForeignKey("Vehicles")]
        public string VehicleNumber { get; set; }
        public Vehicle Vehicles { get; set; }
        [Required(ErrorMessage = "Please enter the Stop1")]
        public string Stop1 { get; set; }
        [Required(ErrorMessage = "Please enter the Stop2")]
        public string Stop2 { get; set; }
        [Required(ErrorMessage = "Please enter the Stop3")]
        public string Stop3 { get; set; }
    }
}
