using AutoMapper;
using Contracts.Calendar;
using GCalendar.Handlers.V1.InsertEvent;
using NodaTime;

namespace GCalendar.Api.V1
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateStartMaps();
            CreateEndMaps();

            CreateMap<InsertEventRequest, InsertEventCommand>();
            CreateMap<InsertEventResult, Event>();
        }

        void CreateStartMaps()
        {
            CreateMap<Start, ZonedDateTime>()
                .ConvertUsing((start, time) => 
                {
                    var instant = Instant.FromUnixTimeTicks(start.Ticks);
                    var zone = DateTimeZoneProviders.Tzdb[start.TimeZone];
                    return new ZonedDateTime(instant, zone);
                });

            CreateMap<ZonedDateTime, Start>()
                .ForMember(m => m.Ticks, opt => opt.MapFrom(src => src.ToInstant().ToUnixTimeTicks()))
                .ForMember(m => m.TimeZone, opt => opt.MapFrom(src => src.Zone));    
        }
        
        void CreateEndMaps()
        {
            CreateMap<End, ZonedDateTime>()
                .ConvertUsing((end, time) => 
                {
                    var instant = Instant.FromUnixTimeTicks(end.Ticks);
                    var zone = DateTimeZoneProviders.Tzdb[end.TimeZone];
                    return new ZonedDateTime(instant, zone);
                });

            CreateMap<ZonedDateTime, End>()
                .ForMember(m => m.Ticks, opt => opt.MapFrom(src => src.ToInstant().ToUnixTimeTicks()))
                .ForMember(m => m.TimeZone, opt => opt.MapFrom(src => src.Zone));            
        }
    }
}