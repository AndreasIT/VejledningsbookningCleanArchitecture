using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application._Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        int SaveChanges();

    }
}
