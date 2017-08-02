using Microsoft.Extensions.DependencyInjection;

namespace Orleans.AspNetCore
{
    public static class OrleansServiceCollectionExtensions
    {
        public static IServiceCollection AddOrleans(this IServiceCollection services)
        {
            // TODO: Start orleans silo and connect to it locally.
            return services;
        }
    }
}
