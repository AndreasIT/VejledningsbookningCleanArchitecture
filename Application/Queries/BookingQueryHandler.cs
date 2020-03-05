using Application._Interfaces;
using Application.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class BookingQueryHandler : IRequestHandler<GetAllBookingsQuery, List<BookingViewModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BookingQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BookingViewModel>> Handle(GetAllBookingsQuery request, CancellationToken cancellationToken)
        {
            var bookings = await _context.Bookings.ToListAsync();
            var bookingsvm = _mapper.Map < List<BookingViewModel>>(bookings);

            return bookingsvm;
        }
    }
}
