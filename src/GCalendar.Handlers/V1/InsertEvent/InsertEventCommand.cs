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
            string title,
            string? description = null)
        {
            CalendarId = calendarId;
            Id = id;
            Start = start;
            End = end;
            Title = title;
            Description = description;
        }

        public string CalendarId { get; }
        public string Id { get; }
        public DateTime Start { get; }
        public DateTime End { get; }
        public string Title { get; }
        public string? Description { get; }
    }
}