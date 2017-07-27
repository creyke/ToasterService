using System.Threading.Tasks;
using ToasterService.Interfaces.Controllers.Toaster;

namespace ToasterService.Api.Controllers
{
    public class ToasterController : OrleansController<IToasterControllerGrain>, IToasterControllerGrain
    {
        public async Task<ToastMakingResult> MakeToast(int toasterId)
        {
            return await ControllerGrain.MakeToast(toasterId);
        }
    }
}
