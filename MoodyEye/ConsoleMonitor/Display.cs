namespace MoodyEye.ConsoleMonitor;

using common.Domain;
using Microsoft.Extensions.Hosting;
using Spectre.Console;

public class Display : BackgroundService
{
    private readonly Account account;
    private Timer timer;

    public Display(Account account)
    {
        this.account = account;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var table = new Table1(account);
        await table.Draw();
    }

    public override void Dispose()
    {
        timer?.Dispose();
        base.Dispose();
    }
}