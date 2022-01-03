using System;
using System.Collections.Generic;

namespace FlyTickets.Models
{
    public partial class FlightsInfo
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinishDate { get; set; }
        public byte OriginCityId { get; set; }
        public byte DestinationCityId { get; set; }
    }
}
