namespace ghost;

using Kafka;
using Kafka.Consumer;
using Kafka.Producer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using web_reach.Commands;
using web_reach.Interfaces;
using web_reach.Selenium;

public class Program
{
    static async Task Main()
    {
        var host = CreateHostBuilder().Build();

        await host.RunAsync();
    }

    public static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
                services.AddSingleton<IMessageProcessor, MessageProcessor>();
                services.AddHostedService<KafkaConsumerService>();
                var kafkaProducer = new KafkaJsonProducer("localhost:9092");
                //web-reach
                services.AddSingleton<ISeleniumWebDriver, SeleniumWebDriver>();
                services.AddSingleton<IOgameCommands, OGameCommands>();
                services.AddSingleton<INavigationCommands, NavigationCommands>();
            });
}