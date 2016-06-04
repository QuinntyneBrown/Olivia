using BlogEngine.Config;
using BlogEngine.Data;
using BlogEngine.Services;
using BlogEngine.Utils;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace BlogEngine
{
    public class UnityConfiguration
    {
        public static IUnityContainer GetContainer()
        {
            var container = new UnityContainer().AddNewExtension<Interception>();
            container.RegisterType<IDbContext, DataContext>();
            container.RegisterType<IUow, Uow>();
            container.RegisterType<IRepositoryProvider, RepositoryProvider>();
            container.RegisterType<IIdentityService, IdentityService>();
            container.RegisterType<ILoggerFactory, LoggerFactory>();
            container.RegisterType<ICacheProvider, CacheProvider>();
            container.RegisterType<IEncryptionService, EncryptionService>();
            container.RegisterType<ILogger, Logger>();
            container.RegisterType<IBlogService, BlogService>();
            container.RegisterInstance(AuthConfiguration.LazyConfig);            
            return container;
        }
    }
}
