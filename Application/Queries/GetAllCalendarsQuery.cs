using System;
using System.Collections.Generic;
using System.Text;
using Application.ViewModels;
using MediatR;

namespace Application.Queries
{
    public class GetAllCalendarsQuery : IRequest<List<CalendarViewModel>>
    {
    }
}
