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
        await table.DrawTable();
    }

    public override void Dispose()
    {
        timer?.Dispose();
        base.Dispose();
    }

    private void UpdateTable(object state)
    {
        AnsiConsole.Clear();
        var table = new Table();
        table.AddColumn("Metal");
        table.AddColumn("Crystal");
        
        
        if (account.Planets.Any())
            table.AddRow(account.Planets.First().MetalValue.ToString(), account.Planets.First().CrystalValue.ToString());
        
        
        AnsiConsole.Live(table)
            .AutoClear(false)
            .Overflow(VerticalOverflow.Ellipsis)
            .Cropping(VerticalOverflowCropping.Bottom)
            .StartAsync(async ctx =>
            {
                ctx.Refresh();
            });
    }
}