namespace ComponentsMicroservice.Utils
{
    public interface ILogger
    {
        void AddProvider(ILoggerProvider provider);
    }
}
