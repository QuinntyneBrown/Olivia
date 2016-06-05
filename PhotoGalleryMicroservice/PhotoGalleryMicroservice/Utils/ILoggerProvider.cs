namespace PhotoGalleryMicroservice.Utils
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
