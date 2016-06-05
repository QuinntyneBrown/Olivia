namespace PhotoGalleryMicroservice.Utils
{
    public interface ILogger
    {
        void AddProvider(ILoggerProvider provider);
    }
}
