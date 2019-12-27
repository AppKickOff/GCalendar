using System.Threading;
using System.Threading.Tasks;
using GCalendar.Calendar.Contracts;
using MediatR;

namespace GCalendar.Handlers.V1.InsertEvent
{
    public class InsertEventHandler : IRequestHandler<InsertEventCommand, InsertEventResult>
    {
        private readonly ICalendarService service;

        public InsertEventHandler(ICalendarService service)
        {
            this.service = service;
        }

        public Task<InsertEventResult> Handle(InsertEventCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}