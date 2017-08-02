using Orleans.Runtime.Configuration;
using System;
using System.Linq;
using System.Net;

namespace Orleans.AspNetCore
{
    public class OrleansHostBuilder : IOrleansHostBuilder
    {
        private Type startupType;

        public IOrleansHost Build()
        {
            var host = new OrleansHost();

            var config = host.Config;
            DefaultConfig(config);

            if (startupType == null)
                throw new NullReferenceException("Startup undefined.");

            var startup = (IOrleansStartup)Activator.CreateInstance(startupType);
            startup.ConfigureOrleans(config);

            return host;
        }

        private static void DefaultConfig(ClusterConfiguration config)
        {
            config.Defaults.SiloName = "default";
            config.Globals.LivenessType = GlobalConfiguration.LivenessProviderType.MembershipTableGrain;
            config.Globals.ReminderServiceType = GlobalConfiguration.ReminderServiceProviderType.ReminderTableGrain;
            config.Defaults.ProxyGatewayEndpoint = new IPEndPoint(IPAddress.Any, 30000);
            config.Defaults.Port = 11111;
            config.Globals.RegisterStorageProvider("Orleans.Storage.MemoryStorage", "Default");
            config.Defaults.HostNameOrIPAddress = "localhost";
            config.Globals.SeedNodes.Add(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11111));
            config.PrimaryNode = config.Globals.SeedNodes.First();
        }

        public IOrleansHostBuilder UseStartup<TStartup>() where TStartup : IOrleansStartup
        {
            startupType = typeof(TStartup);
            return this;
        }
    }
}
