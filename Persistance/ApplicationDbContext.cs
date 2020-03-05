using Application._Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }

        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public new int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
