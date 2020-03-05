using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.GetSingleCalendarUseCase
{
    public class GetSingleCalendarQuery : IRequest<CalendarViewModel>
    {
        public Guid Id { get; set; }
        public GetSingleCalendarQuery(Guid id)
        {
            Id = id;
        }
    }
}
