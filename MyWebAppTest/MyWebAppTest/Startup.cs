using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebAppTest.Startup))]
namespace MyWebAppTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
