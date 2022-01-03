using System;
using System.Collections.Generic;

namespace FlyTickets.Models
{
    public partial class FlightUserDatum
    {
        public Guid Id { get; set; }
        public string CityId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime FlightDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
