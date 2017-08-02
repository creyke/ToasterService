using Orleans.Runtime.Configuration;

namespace Orleans.AspNetCore
{
    public interface IOrleansStartup
    {
        void ConfigureOrleans(ClusterConfiguration configuration);
    }
}
