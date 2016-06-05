using ComponentsMicroservice;
using Owin;
using System.Web.Http;
using Unity.WebApi;

namespace ComponentsMicroservice.Cli
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.DependencyResolver = new UnityDependencyResolver(UnityConfiguration.GetContainer());
            ApiConfiguration.Install(config, app);
            app.UseWebApi(config);
        }
    }
}
