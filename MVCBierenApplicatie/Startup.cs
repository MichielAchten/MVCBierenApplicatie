using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBierenApplicatie.Startup))]
namespace MVCBierenApplicatie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
