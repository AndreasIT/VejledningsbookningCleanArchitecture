using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class GetAllBookingsQuery : IRequest<List<BookingViewModel>>
    {
    }
}
