using Application._Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Calendars
{
    public class CalendarCommandHandler : IRequestHandler<CreateCalendarCommand>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;

        public CalendarCommandHandler(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public Task<Unit> Handle(CreateCalendarCommand request, CancellationToken cancellationToken)
        {
            var calendar = _mapper.Map<Calendar>(request);
            _context.Calendars.Add(calendar);
            _context.SaveChanges();

            return Task.FromResult(Unit.Value);
        }
    }
}
