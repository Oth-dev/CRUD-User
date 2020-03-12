using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudUser.Startup))]
namespace CrudUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
