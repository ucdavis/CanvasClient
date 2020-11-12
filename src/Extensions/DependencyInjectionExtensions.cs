using System;
using CanvasClient;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddCanvasServices(this IServiceCollection services)
        {
            services.AddScoped<CanvasApi>();

            return services;
        }
    }
}
