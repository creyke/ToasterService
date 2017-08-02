using Orleans;
using System.Threading.Tasks;
using ToasterService.Api.Interfaces;
using ToasterService.Api.Model;

namespace ToasterService.Grains.Interfaces
{
    public class ToasterGrain : Grain<Toaster>, IToasterGrain
    {
        public Task<Toaster> Get()
        {
            return Task.FromResult(State);
        }
    }
}
