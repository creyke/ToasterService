using Orleans;
using System.Threading.Tasks;
using ToasterService.Interfaces.Controllers.Toaster;

namespace ToasterService.Silo.Grains.Toaster
{
    public interface IToasterGrain : IGrainWithIntegerKey
    {
        Task<ToastMakingResult> MakeSomeToast(int toasterId);
    }
}
