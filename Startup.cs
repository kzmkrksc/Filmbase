using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmBase.Startup))]
namespace FilmBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
