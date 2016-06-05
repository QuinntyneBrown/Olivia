namespace SearchMicroservice.Utils
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
