using System.Threading.Tasks;
using ToasterService.Api.Interfaces;
using ToasterService.Api.Model;

namespace ToasterService.Grains.Interfaces
{
    public class ToasterGrain : IToasterGrain
    {
        public Task<ToastMakingResult> MakeSomeToast(int toasterId)
        {
            return Task.FromResult(new ToastMakingResult());
        }
    }
}
