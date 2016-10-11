using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeBloodedFinal.Startup))]
namespace CodeBloodedFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
