using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Word.Startup))]
namespace Word
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
