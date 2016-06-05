namespace TvShowMicroservice.Utils
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
