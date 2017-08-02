using Orleans.AspNetCore;
using System.Threading.Tasks;
using ToasterService.Api.Interfaces;
using ToasterService.Api.Model;

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
