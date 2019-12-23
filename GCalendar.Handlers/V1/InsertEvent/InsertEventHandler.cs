using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace GCalendar.Handlers.V1.InsertEvent
{
    public class InsertEventHandler : IRequestHandler<InsertEventCommand, InsertEventResult>
    {
        public Task<InsertEventResult> Handle(InsertEventCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}