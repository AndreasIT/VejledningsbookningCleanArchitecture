using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class BookingViewModel
    {
        public Guid Id { get; set; }
        public DateTime To { get; set; }
        public DateTime From { get; set; }
    }
}
