namespace SecurityMicroservice.Utils
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
