using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vote.Startup))]
namespace Vote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
