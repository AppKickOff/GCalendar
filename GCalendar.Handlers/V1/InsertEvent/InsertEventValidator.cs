using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace GCalendar.Handlers.V1.InsertEvent
{
    public class InsertEventValidator : IPipelineBehavior<InsertEventCommand, InsertEventResult>
    {
        public Task<InsertEventResult> Handle(InsertEventCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<InsertEventResult> next)
        {
            throw new System.NotImplementedException();
        }
    }
}