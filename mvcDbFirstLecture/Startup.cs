using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcDbFirstLecture.Startup))]
namespace mvcDbFirstLecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
