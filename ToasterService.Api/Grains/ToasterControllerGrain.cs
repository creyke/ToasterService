using Orleans;
using Orleans.Concurrency;
using System.Threading.Tasks;
using ToasterService.Api.Interfaces;
using ToasterService.Api.Model;

namespace ToasterService.Api.Grains
{
    [StatelessWorker]
    public class ToasterControllerGrain : Grain, IToasterControllerGrain
    {
        public async Task<Toaster> Get(int toasterId)
        {
            return await GrainClient.GrainFactory.GetGrain<IToasterGrain>(toasterId).Get();
        }
    }
}
