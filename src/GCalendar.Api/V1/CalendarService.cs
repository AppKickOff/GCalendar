using System;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.Calendar;
using GCalendar.Handlers.V1.InsertEvent;
using Grpc.Core;
using MediatR;

namespace GCalendar.Api.V1
{
    public class CalendarService : Calendar.CalendarBase
    {
        readonly IMediator mediator;
        readonly IMapper mapper;

        public CalendarService(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public override async Task<Event> InsertEvent(InsertEventRequest request, ServerCallContext context)
        {             
            var command = mapper.Map<InsertEventCommand>(request);
            var result = await mediator.Send(command);
            mapper.Map<Event>(result);
            return null;
        }
    }
}