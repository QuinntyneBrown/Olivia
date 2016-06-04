using Microsoft.Practices.Unity;

namespace BlogEngine
{
    public class UnityConfiguration
    {
        public static IUnityContainer GetContainer()
        {
            var container = new UnityContainer();

            return container;
        }
    }
}
