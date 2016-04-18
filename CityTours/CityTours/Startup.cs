using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CityTours.Startup))]
namespace CityTours
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
