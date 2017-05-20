using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TailorMaster.Startup))]
namespace TailorMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
