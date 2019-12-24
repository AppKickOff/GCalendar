using System;
using FluentValidation;

namespace GCalendar.Handlers.V1.InsertEvent
{
    public class InsertEventValidator : MediatrRequestValidator<InsertEventCommand>
    {
        protected internal override void ConfigureValidation()
        {
            RuleFor(r => r)
                .NotNull();
            
            RuleFor(r => r.Id)
                .NotNull()
                .NotEmpty();

            RuleFor(r => r.CalendarId)
                .NotNull()
                .NotEmpty();

            RuleFor(r => r.Title)
                .NotNull()
                .NotEmpty();
            
            RuleFor(r => r.Description)
                .NotNull()
                .NotEmpty();
            
            RuleFor(r => r.Start.ToUniversalTime())
                .GreaterThan(DateTime.UtcNow);
            
            RuleFor(r => r.End.ToUniversalTime())
                .GreaterThan(DateTime.UtcNow);
        }
    }
}