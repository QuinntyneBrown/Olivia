using System.Collections.Generic;

namespace TvShowMicroservice.Utils
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(string categoryName);

        List<ILoggerProvider> GetProviders();
    }
}
