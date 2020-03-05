using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime to { get; set; }
        public DateTime from { get; set; }
    }
}
