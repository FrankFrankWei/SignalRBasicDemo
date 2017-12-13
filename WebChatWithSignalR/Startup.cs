using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebChatWithSignalR.Startup))]
namespace WebChatWithSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
