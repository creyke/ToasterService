using Orleans;
using System.Threading.Tasks;
using ToasterService.Api.Model;

namespace ToasterService.Api.Interfaces
{
    public interface IToasterControllerGrain : IGrainWithGuidKey
    {
        Task<ToastMakingResult> MakeToast(int toasterId);
    }
}
