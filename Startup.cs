using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(U_Government.Startup))]
namespace U_Government
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
