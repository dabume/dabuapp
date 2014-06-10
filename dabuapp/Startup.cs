using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dabuapp.Startup))]
namespace dabuapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
