using Microsoft.Extensions.DependencyInjection;
using Shiny;

namespace Lims.Phone
{
    public class ShinyAppStartup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.UseBleClient();
            services.UseBleHosting();
        }
    }
}
