using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CI_Sample.Startup))]
namespace CI_Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
