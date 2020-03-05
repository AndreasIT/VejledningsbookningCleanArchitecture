using Application.Commands.Calendars;
using Application.Mappings;
using Application.Queries;
using Application.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapperSetup();

            services.AddScoped<IRequestHandler<GetAllCalendarsQuery, List<CalendarViewModel>>, CalendarQueryHandler>();
            services.AddScoped<IRequestHandler<CreateCalendarCommand>, CalendarCommandHandler>();

            services.AddScoped<IRequestHandler<GetAllBookingsQuery, List<BookingViewModel>>, BookingQueryHandler>();

                return services;
        }

        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(profile =>
            {
                profile.AddProfile(new DomainToViewModelMapping());
                profile.AddProfile(new ViewModelToDomainMapping());
            });
        }

        public static void AddAutoMapperSetup(this IServiceCollection services, params Assembly[] assemblies)
        {
            var config = RegisterMappings();
            var mapper = config.CreateMapper();

            IEnumerable<Profile> profiles = new List<Profile>() { new DomainToViewModelMapping(), new ViewModelToDomainMapping() };
            services.AddAutoMapper(config => config.AddProfiles(profiles), assemblies);
        }
    }
}
