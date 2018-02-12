using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterChallengeSolution.Startup))]
namespace TwitterChallengeSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
