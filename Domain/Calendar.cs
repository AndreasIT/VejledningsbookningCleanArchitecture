using System;
using System.Collections.Generic;

namespace Domain
{
    public class Calendar
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual List<Booking> Bookings { get; set; }

        public static Calendar Create(Guid id, string name)
        {
            var calendar = new Calendar() { Id = id, Name = name };
            return calendar;
        }
    }
}
