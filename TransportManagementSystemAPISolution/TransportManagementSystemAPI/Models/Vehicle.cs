using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystemAPI.Models
{
    public class Vehicle
    {
        [Key]
       
        [Required(ErrorMessage = "Enter the Vehicle Number")]
        [RegularExpression(@"^[T][N][0-9]{2}[A-Z]{2}[0-9]{4}$",
         ErrorMessage = "The Vehicle Number should be in TN format. For Eg.TN59BA4345")]
        
        public string VehicleNumber { get; set; }
        [Required(ErrorMessage = "Enter the Vehicle Capacity")]
        [Range(5, 60,
        ErrorMessage = "The Capacity of the vehicle must be between {1} and {2}.")]
        public int Capacity { get; set; }
        public bool IsAC { get; set; }
        public bool IsOperational { get; set; }
        [Required(ErrorMessage = "Enter the Available seats")]
        [Range(5, 60,
        ErrorMessage = "The Available Seats in the vehicle must be between {1} and {2}.")]
        public int AvailableSeats { get; set; }
    }
}
