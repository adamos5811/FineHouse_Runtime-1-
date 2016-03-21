    using Microsoft.Owin;
    using Owin;

[assembly: OwinStartup(typeof(FineHouseService.Startup))]

namespace FineHouseService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}