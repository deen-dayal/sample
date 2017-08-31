using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsProj.Startup))]
namespace JenkinsProj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
