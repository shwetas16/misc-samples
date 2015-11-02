using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SubGridModel.Startup))]
namespace SubGridModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
