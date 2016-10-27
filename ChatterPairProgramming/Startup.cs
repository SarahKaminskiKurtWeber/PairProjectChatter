using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatterPairProgramming.Startup))]
namespace ChatterPairProgramming
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
