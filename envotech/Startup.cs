using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(envotech.Startup))]
namespace envotech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
