using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bjornebo.Startup))]
namespace Bjornebo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
