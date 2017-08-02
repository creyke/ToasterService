using Orleans;
using System.Threading.Tasks;
using ToasterService.Api.Model;

namespace ToasterService.Api.Interfaces
{
    public interface IToasterGrain : IGrainWithIntegerKey
    {
        Task<Toaster> Get();
    }
}
