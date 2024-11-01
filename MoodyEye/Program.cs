using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoodyEye.Kafka;

namespace MoodyEye;

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
            });
}