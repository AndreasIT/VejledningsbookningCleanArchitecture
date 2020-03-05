using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Bookings
{
    public class CreateBookingCommand : IRequest
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Guid CalendarId { get; set; }
    }
}
