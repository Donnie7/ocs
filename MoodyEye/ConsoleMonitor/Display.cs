namespace MoodyEye.ConsoleMonitor;

using Microsoft.Extensions.Hosting;
using Spectre.Console;

public class Display : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        AnsiConsole.Write(new BarChart()
            .Width(60)
            .Label("[green bold underline]Number of fruits[/]")
            .CenterLabel()
            .AddItem("Apple", 12, Color.Yellow)
            .AddItem("Orange", 54, Color.Green)
            .AddItem("Banana", 33, Color.Red));
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}