using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using WebApi.Boilerplate.Application;
using WebApi.Boilerplate.Application.Interfaces.Common;
using WebApi.Boilerplate.Domain;

namespace WebApi.Boilerplate.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            var assembliesToScan = (from t in new[] { typeof(DomainLayer), typeof(ApplicationLayer) } select t.Assembly).ToArray();
            var serviceInterfaceType = typeof(ITransientService);
            var singletonServiceInterfaceType = typeof(ISingletonService);
            var scopedServiceInterfaceType = typeof(IScopedService);
            var types = serviceInterfaceType
                .Assembly
                .GetExportedTypes()
                .Where(t => t.IsClass && !t.IsAbstract)
                .Select(t => new
                {
                    Service = t.GetInterface($"I{t.Name}"),
                    Implementation = t
                })
                .Where(t => t.Service != null);

            foreach (var type in types)
            {
                if (serviceInterfaceType.IsAssignableFrom(type.Service))
                {
                    services.AddTransient(type.Service, type.Implementation);
                }
                else if (singletonServiceInterfaceType.IsAssignableFrom(type.Service))
                {
                    services.AddSingleton(type.Service, type.Implementation);
                }
                else if (scopedServiceInterfaceType.IsAssignableFrom(type.Service))
                {
                    services.AddScoped(type.Service, type.Implementation);
                }
            }

            return services;
        }
    }
}