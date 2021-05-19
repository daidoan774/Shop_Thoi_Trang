using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(re.Startup))]
namespace re
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
