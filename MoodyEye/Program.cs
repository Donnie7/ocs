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

        var display = host.Services.GetRequiredService<Display>();

        await display.RunAsync();
    }

    public static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<IMessageProcessor, MessageProcessor>();
                services.AddSingleton<Display>();
                services.AddHostedService<KafkaConsumerService>();
            });
}