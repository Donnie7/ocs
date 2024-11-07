namespace MoodyEye.ConsoleMonitor;

using common.Domain;
using Spectre.Console;

public class Table1
{
    private readonly Account account;
    private const int NumberOfRows = 10;

    private static readonly Random _random = new();
    private static readonly string[] _exchanges = new string[]
    {
        "SGD", "SEK", "PLN",
        "MYR", "EUR", "USD",
        "AUD", "JPY", "CNH",
        "HKD", "CAD", "INR",
        "DKK", "GBP", "RUB",
        "NZD", "MXN", "IDR",
        "TWD", "THB", "VND",
    };

    public Table1(Account account)
    {
        this.account = account;
    }
    
    public async Task DrawTable()
    {
        var table = new Table().BorderColor(Color.Grey);
        table.AddColumn("Planet");
        table.AddColumn("0");
        table.Columns[0].Width(10);
        table.Columns[1].Width(10);

        AnsiConsole.MarkupLine("Press [yellow]CTRL+C[/] to exit");

        await AnsiConsole.Live(table)
            .AutoClear(false)
            .Overflow(VerticalOverflow.Ellipsis)
            .Cropping(VerticalOverflowCropping.Bottom)
            .StartAsync(async ctx =>
            {
                // Add some initial rows
                foreach (var _ in Enumerable.Range(0, NumberOfRows))
                {
                    AddExchangeRateRow(table);
                }

                // Continously update the table
                while (true)
                {
                    // More rows than we want?
                    if (table.Rows.Count > NumberOfRows)
                    {
                        // Remove the first one
                        table.Rows.RemoveAt(0);
                    }

                    // Add a new row
                    AddExchangeRateRow(table);

                    // Refresh and wait for a while
                    ctx.Refresh();
                    await Task.Delay(400);
                }
            });
    }
    
    private void AddExchangeRateRow(Table table)
    {
        if (!account.Planets.Any()) return;
        if (table.Rows.Count != 0)
        {
            table.UpdateCell(0, 1, account.Planets.First().MetalValue.ToString());
        }
        else
        {
            table.AddRow(
                "MetalMine",
                account.Planets.First().MetalValue.ToString());
        }
    }
}