using System.Threading.Tasks;
using Contracts.Calendar;
using Grpc.Core;

namespace GCalendar.Api.V1.Services
{
    public class CalendarService : Calendar.CalendarBase
    {
        public override Task<Event> InsertEvent(Event request, ServerCallContext context)
        {
            return Task.FromResult(default(Event));
        }
    }
}