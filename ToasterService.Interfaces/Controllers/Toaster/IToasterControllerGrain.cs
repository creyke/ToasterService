using Orleans;
using System.Threading.Tasks;

namespace ToasterService.Interfaces.Controllers.Toaster
{
    public interface IToasterControllerGrain : IGrainWithGuidKey
    {
        Task<ToastMakingResult> MakeToast(int toasterId);
    }
}
