using System;
using MediatR;

namespace GCalendar.Handlers.V1.InsertEvent
{
    public class InsertEventCommand : IRequest<InsertEventResult>
    {
        public InsertEventCommand(
            string calendarId,
            string id,
            DateTime start,
            DateTime end,
            string title)
        {
            if (string.IsNullOrWhiteSpace(calendarId))
                throw new ArgumentException(nameof(calendarId));

            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException(nameof(id));

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException(nameof(title));     

            if (start == default)
                throw new ArgumentException(nameof(start));    

            if (end == default)
                throw new ArgumentException(nameof(end));   

            CalendarId = calendarId;
            Id = id;
            Start = start;
            End = end;
            Title = title;
        }

        public string CalendarId { get; }
        public string Id { get; }
        public DateTime Start { get; }
        public DateTime End { get; }
        public string Title { get; }
        public string? Description { get; }
    }
}