namespace ghost;

using common.Kafka;
using common.Kafka.Commands;
using Interfaces;
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
                services.AddMediatR(config =>
                {
                    config.RegisterServicesFromAssemblyContaining<Program>();
                    config.RegisterServicesFromAssemblyContaining<ICommand>();
                });
                services.AddSingleton<IMessageProcessor, MessageProcessor>();
                services.AddHostedService<KafkaConsumerService>();
                var kafkaProducer = new KafkaJsonProducer("localhost:9092");
                services.AddSingleton(kafkaProducer);
                services.AddSingleton<IKafkaProducer, KafkaProducer>();
                services.AddSingleton<ITestDataMessage, TestDataMessageProducer>();
                //web-reach
                services.AddSingleton<ISeleniumWebDriver, SeleniumWebDriver>();
                services.AddSingleton<IOgameCommands, OGameCommands>();
                services.AddSingleton<INavigationCommands, NavigationCommands>();
            });
}