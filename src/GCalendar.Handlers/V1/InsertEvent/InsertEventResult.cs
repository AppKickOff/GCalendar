using Handlers.Codes;
using NodaTime;

namespace GCalendar.Handlers.V1.InsertEvent
{
    public class InsertEventResult
    {
        public InsertEventResult(
            string calendarId, 
            string id, 
            string eventId, 
            ZonedDateTime start,
            ZonedDateTime end, 
            string title,  
            StatusCode statusCode,
            string? description = null)
        {
            this.CalendarId = calendarId;
            this.Id = id;
            this.EventId = eventId;
            this.Start = start;
            this.End = end;
            this.Title = title;
            this.StatusCode = statusCode;

        }
        public string CalendarId { get; }
        public string Id { get; }
        public string EventId { get; }
        public ZonedDateTime Start { get; }
        public ZonedDateTime End { get; }
        public string Title { get; }
        public string? Description { get; }
        public StatusCode StatusCode { get; }
    }
}