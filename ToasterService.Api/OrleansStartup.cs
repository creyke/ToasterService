using Orleans.AspNetCore;
using Orleans.Runtime.Configuration;

namespace ToasterService.Api
{
    public class OrleansStartup : IOrleansStartup
    {
        public void ConfigureOrleans(ClusterConfiguration configuration)
        {
        }
    }
}
