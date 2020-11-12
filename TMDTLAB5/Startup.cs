using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDTLAB5.Startup))]
namespace TMDTLAB5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
