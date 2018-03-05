using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingCodePush.Startup))]
namespace TestingCodePush
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
