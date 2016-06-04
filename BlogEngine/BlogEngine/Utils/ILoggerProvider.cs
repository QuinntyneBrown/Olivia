namespace BlogEngine.Utils
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
