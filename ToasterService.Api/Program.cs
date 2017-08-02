using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Orleans.AspNetCore;

namespace ToasterService.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orleansHost = new OrleansHostBuilder()
                .UseStartup<OrleansStartup>()
                .Build();

            orleansHost.Run();
            
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
