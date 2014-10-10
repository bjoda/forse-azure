using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureDojo.Startup))]
namespace AzureDojo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
