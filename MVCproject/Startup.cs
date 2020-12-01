using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCproject.Startup))]
namespace MVCproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
