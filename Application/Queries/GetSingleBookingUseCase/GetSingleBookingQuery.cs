using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.GetSingleBookingUseCase
{
    public class GetSingleBookingQuery : IRequest<BookingViewModel>
    {
        public Guid Id { get; set; }
        public GetSingleBookingQuery(Guid id)
        {
            Id = id;
        }
    }
}
