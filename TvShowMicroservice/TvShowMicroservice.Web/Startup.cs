using Owin;
using System.Web.Http;
using Microsoft.Owin;
using Unity.WebApi;

[assembly: OwinStartup(typeof(TvShowMicroservice.Web.Startup))]

namespace TvShowMicroservice.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {            
            GlobalConfiguration.Configure(config =>
            {
                config.DependencyResolver = new UnityDependencyResolver(UnityConfiguration.GetContainer());
                TvShowMicroservice.ApiConfiguration.Install(config, app);
            });
        }
    }
}
