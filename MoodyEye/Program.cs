using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoodyEye.Kafka;

namespace MoodyEye;

using ConsoleMonitor;

public class Program
{
    static async Task Main()
    {
        var host = CreateHostBuilder().Build();
        await host.StartAsync();
    }

    public static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<IMessageProcessor, MessageProcessor>();
                services.AddHostedService<Display>();
                services.AddHostedService<KafkaConsumerService>();
            });
}