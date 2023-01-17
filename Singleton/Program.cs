using Singleton;

var config1 = Configuration.GetInstance();
var config2 = Configuration.GetInstance();

if (ReferenceEquals(config1, config2))
{
    Console.WriteLine("Configuration is a singleton");
}