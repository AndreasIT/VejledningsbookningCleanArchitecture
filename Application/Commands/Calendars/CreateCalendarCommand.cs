using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Calendars
{
    public class CreateCalendarCommand : IRequest
    {
        public string Name { get; set; }
        public CreateCalendarCommand(string name)
        {
            Name = name;
        }
        public CreateCalendarCommand()
        {

        }
    }
}
