using Microsoft.AspNetCore.Mvc;
using Orleans;
using System;

namespace ToasterService.Api.Controllers
{
    public abstract class OrleansController<TStatelessWorkerController> : Controller where TStatelessWorkerController : IGrainWithGuidKey
    {
        protected TStatelessWorkerController ControllerGrain { get; private set; }

        public OrleansController()
        {
            ControllerGrain = GrainClient.GrainFactory.GetGrain<TStatelessWorkerController>(Guid.Empty);
        }
    }
}
