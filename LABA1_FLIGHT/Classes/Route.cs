using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LABA1_FLIGHT.Classes
{
    public class Route
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string RouteNumber { get; set; }
        //todo: коллекция Destination +
        public virtual ICollection<Destination> Destinations { get; set; }
        public Route()
        {
            Destinations = new List<Destination>();
            Flights = new List<Flight>();
        }
        //todo: коллекция Flight +
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
