using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectAriel.Startup))]
namespace ProjectAriel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
