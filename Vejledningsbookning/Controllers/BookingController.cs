using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Bookings;
using Application.Queries;
using Application.Queries.GetSingleBookingUseCase;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Vejledningsbookning.Controllers
{
    public class BookingController : APIController
    {
        public BookingController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookings()
        {
            var bookings = await _mediator.Send(new GetAllBookingsQuery());
                return Ok(bookings);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBookingsById(Guid id)
        {
            var bookings = await _mediator.Send(new GetSingleBookingQuery(id));
            return Ok(bookings);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateBooking([FromBody]CreateBookingCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}