using Owin;
using System.Web.Http;
using Microsoft.Owin;
using Unity.WebApi;

[assembly: OwinStartup(typeof(SecurityMicroservice.Web.Startup))]

namespace SecurityMicroservice.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {            
            GlobalConfiguration.Configure(config =>
            {
                config.DependencyResolver = new UnityDependencyResolver(UnityConfiguration.GetContainer());
                SecurityMicroservice.ApiConfiguration.Install(config, app);
            });
        }
    }
}
