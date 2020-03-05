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

namespace Application.Queries.GetSingleBookingUseCase
{
    public class GetSingleBookingQueryHandler : IRequestHandler<GetSingleBookingQuery, BookingViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;

        public GetSingleBookingQueryHandler(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<BookingViewModel> Handle(GetSingleBookingQuery request, CancellationToken cancellationToken)
        {
            var booking = await _context.Bookings.FirstOrDefaultAsync(b => b.Id == request.Id);
            var bookingvm = _mapper.Map<BookingViewModel>(booking);

            return bookingvm;
        }
    }
}
