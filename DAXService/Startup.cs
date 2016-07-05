using Microsoft.Owin;
using Owin;

//[assembly: OwinStartupAttribute(typeof(DAXService.Startup))]
namespace DAXService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
