using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace GCalendar.Handlers
{
    public static class IocExtensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddTransient<ServiceFactory>(p => p.GetService);
            services.AddSingleton<IMediator, Mediator>();

            services.Scan(a => a.FromExecutingAssembly()
                .AddClasses(c => c.AssignableTo(typeof(IRequestHandler<>)))
                .AsMatchingInterface((t, f) => f.AssignableTo(typeof(IRequestHandler<>)))
                .WithSingletonLifetime()
                .AddClasses(c => c.AssignableTo(typeof(IPipelineBehavior<,>)))
                .AsMatchingInterface((t, f) => f.AssignableTo(typeof(IPipelineBehavior<,>)))
                .WithSingletonLifetime());

            return services;
        }
    }

    public class MediatrAssemblyMarker
    {
    }
}