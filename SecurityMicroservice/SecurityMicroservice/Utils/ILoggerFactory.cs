using System.Collections.Generic;

namespace SecurityMicroservice.Utils
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(string categoryName);

        List<ILoggerProvider> GetProviders();
    }
}
