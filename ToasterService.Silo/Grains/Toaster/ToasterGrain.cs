using System.Threading.Tasks;
using ToasterService.Interfaces.Controllers.Toaster;

namespace ToasterService.Silo.Grains.Toaster
{
    public class ToasterGrain : IToasterGrain
    {
        public Task<ToastMakingResult> MakeSomeToast(int toasterId)
        {
            return Task.FromResult(new ToastMakingResult());
        }
    }
}
