using System;
using System.Collections.Generic;

namespace FlyTickets.Models
{
    public partial class City
    {
        public byte Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
