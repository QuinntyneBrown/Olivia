using Owin;
using System.Web.Http;
using Microsoft.Owin;
using Unity.WebApi;

[assembly: OwinStartup(typeof(BlogEngine.Web.Startup))]

namespace BlogEngine.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {            
            GlobalConfiguration.Configure(config =>
            {
                config.DependencyResolver = new UnityDependencyResolver(UnityConfiguration.GetContainer());
                BlogEngine.ApiConfiguration.Install(config, app);
            });
        }
    }
}
