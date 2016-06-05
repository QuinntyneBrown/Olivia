using Owin;
using System.Web.Http;
using Microsoft.Owin;
using Unity.WebApi;

[assembly: OwinStartup(typeof(ComponentsMicroservice.Web.Startup))]

namespace ComponentsMicroservice.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {            
            GlobalConfiguration.Configure(config =>
            {
                config.DependencyResolver = new UnityDependencyResolver(UnityConfiguration.GetContainer());
                ComponentsMicroservice.ApiConfiguration.Install(config, app);
            });
        }
    }
}
