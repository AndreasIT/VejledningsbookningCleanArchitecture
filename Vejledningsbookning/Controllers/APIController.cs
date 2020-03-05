using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Vejledningsbookning.Controllers
{
    [Route("api/[controller]/")]
    public class APIController : ControllerBase
    {
        public readonly IMediator _mediator;

        public APIController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}