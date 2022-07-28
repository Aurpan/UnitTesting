using System.Reflection;
using EmployeeSolution.AdditionalClasses;
using Microsoft.Owin;
using Owin;
using Ninject;
using Ninject.Modules;

[assembly: OwinStartupAttribute(typeof(EmployeeSolution.Startup))]
namespace EmployeeSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
