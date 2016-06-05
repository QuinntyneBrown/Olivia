using CommandLine;

namespace ComponentsMicroservice.Cli
{
    public class SelfHostOptions
    {
        [Option("host", Required = false, HelpText = "Host")]
        public string Host { get; set; }

        [Option("port", Required = false, HelpText = "Port")]
        public string Port { get; set; }
    }
}
