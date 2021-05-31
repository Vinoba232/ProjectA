using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystem.Models
{
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public int Capacity { get; set; }
        public bool IsAC { get; set; }
        public bool IsOperational { get; set; }
        public int AvailableSeats { get; set; }
    }
}
