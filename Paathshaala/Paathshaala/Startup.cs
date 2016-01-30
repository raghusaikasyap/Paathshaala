using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Paathshaala.Startup))]
namespace Paathshaala
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
