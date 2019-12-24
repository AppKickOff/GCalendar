using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR.Pipeline;

namespace GCalendar.Handlers.V1.InsertEvent
{
    public abstract class MediatrRequestValidator<T> : AbstractValidator<T>, IRequestPreProcessor<T>
    {
        public Task Process(T request, CancellationToken token)
        {
            return this.ValidateAndThrowAsync(request, cancellationToken: token);			
        }
    }
}