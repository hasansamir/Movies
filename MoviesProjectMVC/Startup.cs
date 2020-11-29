using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesProjectMVC.Startup))]
namespace MoviesProjectMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
