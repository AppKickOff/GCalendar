using System;
using ApiPackages.Handlers;
using FluentValidation;

namespace GCalendar.Handlers.V1.InsertEvent
{
    class InsertEventValidator : MediatrRequestValidator<InsertEventCommand>
    {
        public InsertEventValidator()
        {
            RuleFor(c => c)
                .NotNull();
            
            RuleFor(c => c.Id)
                .NotNull()
                .NotEmpty();

            RuleFor(c => c.CalendarId)
                .NotNull()
                .NotEmpty();

            RuleFor(c => c.Title)
                .NotNull()
                .NotEmpty();
            
            RuleFor(c => c.Start)
                .NotNull()
                .Must(t => t.ToDateTimeUtc() > DateTime.UtcNow);
            
            RuleFor(c => c.End)
                .NotNull()
                .Must(t => t.ToDateTimeUtc() > DateTime.UtcNow);
            
            // End Date
            RuleFor(c => c)
                .Must(c => c.Start.Zone == c.End.Zone)
                .Must(c => c.End.LocalDateTime > c.Start.LocalDateTime);
        }
    }
}