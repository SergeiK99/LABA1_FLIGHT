using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LABA1_FLIGHT.Classes
{
    public class Destination
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string CityName { get; set; }
        public virtual Route Route { get; set; }
    }
}
