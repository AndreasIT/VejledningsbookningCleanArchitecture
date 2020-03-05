using System;
using System.Collections.Generic;
using System.Text;
using Application.ViewModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Application._Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Application.Queries
{
    public class CalendarQueryHandler : IRequestHandler<GetAllCalendarsQuery, List<CalendarViewModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CalendarQueryHandler(IApplicationDbContext context, IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<CalendarViewModel>> Handle(GetAllCalendarsQuery request, CancellationToken cancellationToken)
        {
            var calendars = await _context.Calendars.ToListAsync();
            var calendarsvm = _mapper.Map<List<CalendarViewModel>>(calendars);

            return calendarsvm;
        }
    }
}
