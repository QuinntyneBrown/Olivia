namespace ComponentsMicroservice.Utils
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
