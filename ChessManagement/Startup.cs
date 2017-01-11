using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChessManagement.Startup))]
namespace ChessManagement
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
