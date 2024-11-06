namespace ghost;

using common.Domain;
using common.Kafka;
using common.Kafka.Commands;
using Kafka.Consumer;
using Kafka.Producer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using web_reach.Commands;
using web_reach.DataCollector.Global;
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
                services.AddSingleton<IMessageProcessor, MessageProcessor>();
                services.AddHostedService<KafkaConsumerService>();
                var kafkaProducer = new KafkaJsonProducer("localhost:9092");
                services.AddSingleton(kafkaProducer);
                services.AddSingleton<IKafkaProducer, KafkaProducer>();
                services.AddSingleton<IMessageProducer, DataCollectorProducer>();
                services.AddSingleton<GlobalContextCollector>();
                services.AddSingleton<DataCollectorProducer>();
                services.AddSingleton<Account>();
                //web-reach
                services.AddSingleton<ISeleniumWebDriver, SeleniumWebDriver>();
                services.AddSingleton<IBrowserCommands, BrowserCommands>();
                services.AddSingleton<INavigationCommands, NavigationCommands>();
                
                services.AddMediatR(config =>
                {
                    config.RegisterServicesFromAssemblyContaining<Program>();
                    config.RegisterServicesFromAssemblyContaining<ICommand>();
                });
            });
}