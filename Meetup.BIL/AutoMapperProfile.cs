using AutoMapper;
using Meetup.BIL.ModellsDTO;
using Meetup.DAL.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetup.BIL
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Event, EventDTO>();
            CreateMap<EventDTO, Event>();
            CreateMap<CreateEventDTO, Event>();
            CreateMap<UpdateEventDTO, Event>();

        }
    }
}
