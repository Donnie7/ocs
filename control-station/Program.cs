using control_station.Commands;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace control_station;

using common.Kafka;
using ConsoleMenu;
using Interfaces;

public class Program
{
    private static async Task Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        
        var startMenu = host.Services.GetRequiredService<StartMenu>();
        await startMenu.RunAsync();

        //await host.RunAsync();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                var kafkaProducer = new KafkaJsonProducer("localhost:9092");
                services.AddSingleton(kafkaProducer);
                services.AddSingleton<IKafkaCommandProducer, KafkaCommandProducer>();
                services.AddSingleton<INavigationCommands, NavigationCommandsProducer>();
                services.AddSingleton<IBrowserCommands, BrowserCommandsProducer>();
                services.AddSingleton<StartMenu>();
            });
}