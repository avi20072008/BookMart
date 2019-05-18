using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookmart.Startup))]
namespace Bookmart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
