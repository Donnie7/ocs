namespace ghost;

using Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using web_reach;
using web_reach.Commands;

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
                    services.AddSingleton<IOgame, OGameCommands>();
                    services.AddSingleton<IResourcesCommands, ResourcesCommands>();
                    services.AddSingleton<IMessageProcessor, MessageProcessor>();
                    services.AddHostedService<KafkaConsumerService>();
                });
}
