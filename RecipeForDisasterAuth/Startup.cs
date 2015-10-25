using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeForDisasterAuth.Startup))]
namespace RecipeForDisasterAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
