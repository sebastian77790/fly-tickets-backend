using System;
using System.Collections.Generic;

namespace FlyTickets.Models
{
    public partial class User
    {
        public string UserId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int PhoneNumber { get; set; }
        public string Email { get; set; } = null!;
        public byte Age { get; set; }
    }
}
