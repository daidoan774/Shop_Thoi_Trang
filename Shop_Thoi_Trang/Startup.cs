using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shop_Thoi_Trang.Startup))]
namespace Shop_Thoi_Trang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
