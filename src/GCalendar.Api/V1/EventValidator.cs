using Contracts.Calendar;
using FluentValidation;

namespace GCalendar.Api.V1
{
    public class EventValidator : AbstractValidator<Event>
    {
        public EventValidator()
        {
            RuleFor(e => e)
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
                .NotNull();
                
            RuleFor(c => c.End)
                .NotNull();
        }
    }
}