using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(APFinal2202.Startup))]
namespace APFinal2202
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}