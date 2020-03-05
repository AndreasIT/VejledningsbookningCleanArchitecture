using Application._Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Bookings
{
    public class BookingCommandHandler : IRequestHandler<CreateBookingCommand>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;

        public BookingCommandHandler(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<Unit> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = new Booking { from = request.From, to = request.To };
            var calendar = _context.Calendars.Include(c => c.Bookings).FirstOrDefault(c => c.Id == request.CalendarId);
            calendar.Bookings.Add(booking);
            _context.SaveChanges();

            return await Task.FromResult(Unit.Value);
        }
    }
}
