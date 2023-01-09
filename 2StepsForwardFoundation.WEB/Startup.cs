using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2StepsForwardFoundation.Startup))]
namespace _2StepsForwardFoundation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
