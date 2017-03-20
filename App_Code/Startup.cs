using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Excel_Data_Processor.Startup))]
namespace Excel_Data_Processor
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
