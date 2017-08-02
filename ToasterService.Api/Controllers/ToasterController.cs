using Microsoft.AspNetCore.Mvc;
using Orleans.AspNetCore;
using System.Threading.Tasks;
using ToasterService.Api.Interfaces;
using ToasterService.Api.Model;

namespace ToasterService.Api.Controllers
{
    [Route("api/[controller]")]
    public class ToasterController : OrleansController<IToasterControllerGrain>, IToasterControllerGrain
    {
        [HttpGet("{id}")]
        public async Task<Toaster> Get(int id)
        {
            return await ControllerGrain.Get(id);
        }
    }
}
