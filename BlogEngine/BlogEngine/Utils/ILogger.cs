namespace BlogEngine.Utils
{
    public interface ILogger
    {
        void AddProvider(ILoggerProvider provider);
    }
}
