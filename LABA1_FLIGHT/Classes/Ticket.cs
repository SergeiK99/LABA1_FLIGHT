using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA1_FLIGHT.Classes
{
    public class Ticket
    {
        public Ticket(SeatCategory seatCategory, Flight flight, bool isreserved)
        {
            SeatCategory = seatCategory;
            Flight = flight;
            IsReserved = isreserved;
        }
        public int Id { get; set; }
        public int SeatCategoryId { get; set; }
        public SeatCategory SeatCategory { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public bool IsReserved { get; set; }
    }
}
