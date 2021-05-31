using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystem.Models
{
    public class Route
    {
        public int RouteNumber { get; set; }     
        public string VehicleNumber { get; set; }    
        public string Stop1 { get; set; }
        public string Stop2 { get; set; }
        public string Stop3 { get; set; }

    }
}
