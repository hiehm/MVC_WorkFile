using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_HomeWork.Startup))]
namespace MVC_HomeWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
