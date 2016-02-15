using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PassProject.Startup))]
namespace PassProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
