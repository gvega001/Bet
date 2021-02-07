using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bet.Startup))]
namespace Bet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
