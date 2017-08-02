using Microsoft.Extensions.DependencyInjection;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Orleans.AspNetCore
{
    public static class OrleansServiceCollectionExtensions
    {
        public static IServiceCollection AddOrleansClient(this IServiceCollection services)
        {
            AddOrleansClientAsync().Wait();
            return services;
        }

        private static async Task AddOrleansClientAsync()
        {
            var config = new ClientConfiguration()
            {
                GatewayProvider = ClientConfiguration.GatewayProviderType.Config
            };

            var hostEntry = await Dns.GetHostEntryAsync("localhost");
            var address = hostEntry.AddressList.First(x => x.AddressFamily == AddressFamily.InterNetwork);
            config.Gateways.Add(new IPEndPoint(address, 30000));

            GrainClient.Initialize(config);
        }

        private static bool IsLinux()
        {
            // TODO: Improve. Stupid solution. Need to check if in container.
            return RuntimeInformation.OSDescription.Contains("Linux");
        }
    }
}
