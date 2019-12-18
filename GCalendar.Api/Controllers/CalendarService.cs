using System.Threading.Tasks;
using Grpc;
using Grpc.Core;

namespace GCalendar.Api.Controllers
{
    public class CalendarService : Calendar.CalendarBase
    {
        public override Task<Event> InsertEvent(Event request, ServerCallContext context)
        {
            return Task.FromResult(default(Event));
        }
    }
}