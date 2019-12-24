using System;
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
            
            RuleFor(c => c.Start.ToUniversalTime())
                .GreaterThan(DateTime.UtcNow);
            
            // End Date
            RuleFor(c => c)
                .Must(c => c.End > c.Start);
        }
    }
}