using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSeries.Startup))]
namespace WSeries
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
