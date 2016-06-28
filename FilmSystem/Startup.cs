using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmSystem.Startup))]
namespace FilmSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
