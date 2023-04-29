using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LABA1_FLIGHT.Classes
{
    public class Flight
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string FlightNumber { get; set; }
        [Required, Range(1, 900)]
        public int PurchasedSeats { get; set; }
        [Required, Range(1, 900)]
        public int ReservedSeats { get; set; }
        //вместо тотал ситс разбить на места по категориям +
        public DateTime DepatureDate { get; set; }
        public bool IsInnerFlight { get; set; } // признак внутреннего рейса (true - внутри страны, false - зарубежный)
        public int RouteId { get; set; }
        public Route Route { get; set; }
    }
}
