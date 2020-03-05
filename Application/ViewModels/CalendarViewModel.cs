using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class CalendarViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<BookingViewModel> Bookings { get; set; }
    }
}
