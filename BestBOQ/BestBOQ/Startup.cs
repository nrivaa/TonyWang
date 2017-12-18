using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BestBOQ.Startup))]
namespace BestBOQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
