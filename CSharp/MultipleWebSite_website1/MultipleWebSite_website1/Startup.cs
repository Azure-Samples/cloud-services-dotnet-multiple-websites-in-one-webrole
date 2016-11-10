using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultipleWebSite_website1.Startup))]
namespace MultipleWebSite_website1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
