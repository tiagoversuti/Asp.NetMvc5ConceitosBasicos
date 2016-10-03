using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp.NetMvc5ConceitosBasicos.Startup))]
namespace Asp.NetMvc5ConceitosBasicos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
