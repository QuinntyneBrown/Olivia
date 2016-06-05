namespace TvShowMicroservice.Utils
{
    public interface ILogger
    {
        void AddProvider(ILoggerProvider provider);
    }
}
