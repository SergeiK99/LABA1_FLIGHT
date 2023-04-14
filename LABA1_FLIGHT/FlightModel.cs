namespace LABA1_FLIGHT
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;



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

    public class Destination
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string CityName { get; set; }
        public virtual Route Route { get; set; }
    }
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
    public class Flight
    {
        public int Id { get; set; }
        [Required, Range(1,900)]
        public int PurchasedSeats { get; set; }
        [Required, Range(1, 900)]
        public int ReservedSeats { get; set; }
        //вместо тотал ситс разбить на места по категориям +
        public DateTime DepatureDate { get; set; }
        public bool IsInnerFlight { get; set; } // признак внутреннего рейса (true - внутри страны, false - зарубежный)
        public int RouteId { get; set; }
        public Route Route { get; set; }
    }
    public class SeatCategory
    {
        public int Id { get; set; }
        public bool Category { get; set; } // эконом t или бизнес f
    }
    public class Ticket
    {
        public int Id { get; set; }
        public int SeatCategoryId { get; set; }
        public SeatCategory SeatCategory { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public bool IsReserved { get; set; }

    }
}