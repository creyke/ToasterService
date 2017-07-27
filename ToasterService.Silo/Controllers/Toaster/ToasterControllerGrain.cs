using Orleans;
using Orleans.Concurrency;
using System.Threading.Tasks;
using ToasterService.Interfaces.Controllers.Toaster;
using ToasterService.Silo.Grains.Toaster;

namespace ToasterService.Silo.Controllers.Toaster
{
    [StatelessWorker]
    public class ToasterControllerGrain : IToasterControllerGrain
    {
        public async Task<ToastMakingResult> MakeToast(int toasterId)
        {
            return await GrainClient.GrainFactory.GetGrain<IToasterGrain>(toasterId).MakeSomeToast(toasterId);
        }
    }
}
