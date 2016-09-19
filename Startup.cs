using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuadFace.Startup))]
namespace QuadFace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
