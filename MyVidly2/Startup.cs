using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyVidly2.Startup))]
namespace MyVidly2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
