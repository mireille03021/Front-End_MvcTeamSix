using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ANVI_Mvc.Startup))]
namespace ANVI_Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
