using System.Collections.Generic;

namespace PhotoGalleryMicroservice.Utils
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(string categoryName);

        List<ILoggerProvider> GetProviders();
    }
}
