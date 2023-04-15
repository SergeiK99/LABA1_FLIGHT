namespace LABA1_FLIGHT
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using LABA1_FLIGHT.Classes;



    public class FlightModel : DbContext
    {
        public FlightModel()
            : base("name=FlightModel")
        {
        }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<SeatCategory> SeatCategories { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
    }
}