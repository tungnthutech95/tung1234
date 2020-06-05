using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenThanhTung_Lab456.Startup))]
namespace NguyenThanhTung_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
