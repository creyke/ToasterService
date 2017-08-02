using Microsoft.Extensions.DependencyInjection;

namespace Orleans.AspNetCore.Extensions
{
    public static class MvcBuilderExtensions
    {
        public static IServiceCollection AddOrleans(this IServiceCollection services)
        {
            // TODO: Start orleans silo and connect to it locally.
            return services;
        }
    }
}
