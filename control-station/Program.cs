using control_station;
using control_station.Commands;
using control_station.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
                services.AddSingleton<IResourcesCommands>(new ResourcesCommand(kafkaProducer));
                services.AddSingleton<INavigationCommands>(new NavigationCommands(kafkaProducer));
                services.AddSingleton<IOgameCommands>(new BrowserCommands(kafkaProducer));
                services.AddSingleton<StartMenu>();
            });
}