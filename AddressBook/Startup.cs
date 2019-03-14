using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddressBook.Startup))]
namespace AddressBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
