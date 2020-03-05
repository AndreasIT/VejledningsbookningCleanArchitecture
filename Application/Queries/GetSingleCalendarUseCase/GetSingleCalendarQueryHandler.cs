using Application._Interfaces;
using Application.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries.GetSingleCalendarUseCase
{
    public class GetSingleCalendarQueryHandler : IRequestHandler<GetSingleCalendarQuery, CalendarViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;

        public GetSingleCalendarQueryHandler(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<CalendarViewModel> Handle(GetSingleCalendarQuery request, CancellationToken cancellationToken)
        {
            var calendar = await _context.Calendars.Include(c => c.Bookings).FirstOrDefaultAsync(c => c.Id == request.Id);
            var calendarvm = _mapper.Map<CalendarViewModel>(calendar);

            return calendarvm;
        }
    }
}
