using System;
using System.Collections.Generic;
using System.Text;
using Application.ViewModels;
using AutoMapper;
using Domain;

namespace Application.Mappings
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<Calendar, CalendarViewModel>();
            CreateMap<Booking, BookingViewModel>();
        }
    }
}
