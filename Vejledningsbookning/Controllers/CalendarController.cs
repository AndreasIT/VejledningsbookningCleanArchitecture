using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Calendars;
using Application.Queries;
using Application.Queries.GetSingleCalendarUseCase;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Vejledningsbookning.Controllers
{
    public class CalendarController : APIController
    {
        public CalendarController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet()]
        public async Task<IActionResult> GetAllCalendars()
        {
            var calendars = await _mediator.Send(new GetAllCalendarsQuery());
            return Ok(calendars);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCalendarById(Guid id)
        {
            var calendar = await _mediator.Send(new GetSingleCalendarQuery(id));
            return Ok(calendar);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCalendar([FromBody]CreateCalendarCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}