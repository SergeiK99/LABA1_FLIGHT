namespace LABA1_FLIGHT
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Ticket
    {
        public int Id { get; set; } // свойство Id, представляющее первичный ключ таблицы
        public int FlightNumber { get; set; } // номер рейса
        public string Destination { get; set; } // пункт назначения
        public DateTime DepartureDate { get; set; } // дата отправления
        public bool DomesticFlight { get; set; } // признак внутреннего рейса (true - внутри страны, false - зарубежный)
        public int SeatId { get; set; } // ключ таблицы мест
        public Seat Seat { get; set; } // инф. из  Seat
    }
    public class Seat
    {
        public int Id { get; set; }
        //public int TicketId { get; set; }
        public int TotalSeats { get; set; } // общее кол-во мест
        public string SeatCategory { get; set; } // категория места (бизнес, эконом)
        public int SoldSeats { get; set; } // кол-во проданных мест
        public int ReservedSeats { get; set; } // кол-во забронированных мест
        public Ticket Ticket { get; set; }
        public int TicketId { get; set; }
    }

    public class FlightModel : DbContext
    {
        // Контекст настроен для использования строки подключения "FlightModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "LABA1_FLIGHT.FlightModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "FlightModel" 
        // в файле конфигурации приложения.
        public FlightModel()
            : base("name=FlightModel")
        {
        }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }



        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}