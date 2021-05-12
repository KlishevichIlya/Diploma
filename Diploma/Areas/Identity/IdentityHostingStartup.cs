using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Diploma.Areas.Identity.IdentityHostingStartup))]
namespace Diploma.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}