using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFunction3D.Startup))]
namespace WebFunction3D
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
