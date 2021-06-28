using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenVanLam_BigShool.Startup))]
namespace NguyenVanLam_BigShool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
