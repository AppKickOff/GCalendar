using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR.Pipeline;

namespace GCalendar.Handlers.V1.InsertEvent
{
    public abstract class MediatrRequestValidator<T> : AbstractValidator<T>, IRequestPreProcessor<T>
    {
        bool validationConfigured = false;

        protected internal abstract void ConfigureValidation();        

        public Task Process(T request, CancellationToken cancellationToken)
        {
            if (!validationConfigured)
            {
                ConfigureValidation();
                validationConfigured = true;
            }

            return ValidateAsync(request, cancellationToken);
        }
    }
}