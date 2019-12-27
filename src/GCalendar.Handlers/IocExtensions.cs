using Microsoft.Extensions.DependencyInjection;

namespace GCalendar.Handlers
{
    public static class IocExtensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            ApiPackages.Handlers.IocExtensions.AddHandlers<AssemblyInfo>(services);
            return services;
        }
    }
}