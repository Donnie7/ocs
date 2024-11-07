namespace MoodyEye.ConsoleMonitor;

using common.Domain;
using Spectre.Console;

public class Table1
{
    private readonly Account account;
    private const int NumberOfRows = 10;
    private Timer timer;
    private Table table;

    public Table1(Account account)
    {
        this.account = account;
    }
    
    public async Task Draw()
    {
        table = new Table().BorderColor(Color.Grey);
        table.AddColumn("Planet");
        table.AddColumn("0");
        table.Columns[0].Width(10);
        table.Columns[1].Width(10);

        AnsiConsole.MarkupLine("Press [yellow]CTRL+C[/] to exit");
        DrawTable();

        await AnsiConsole.Live(table)
            .AutoClear(false)
            .Overflow(VerticalOverflow.Ellipsis)
            .Cropping(VerticalOverflowCropping.Bottom)
            .StartAsync(async ctx =>
            {
                //timer = new Timer(UpdateRows, ctx, TimeSpan.Zero, TimeSpan.FromMilliseconds(30000));
                while (true)
                {
                    table.UpdateCell(0, 1, account.Planets.Last().Name);
                    table.UpdateCell(1, 1, account.Planets.Last().Coordinates.ToString());
                    table.UpdateCell(2, 1, account.Planets.Last().MetalValue.ToString());
                    table.UpdateCell(3, 1, account.Planets.Last().CrystalValue.ToString());
                    table.UpdateCell(4, 1, account.Planets.Last().DeuteriumValue.ToString());
                    table.UpdateCell(5, 1, account.Planets.Last().EnergyValue.ToString());
                    table.UpdateCell(6, 1, account.Planets.Last().PopulationValue.ToString());
                    table.UpdateCell(7, 1, account.Planets.Last().FoodValue.ToString());
                    ctx.Refresh();
                    await Task.Delay(400);
                }
            });
    }

    private void DrawTable()
    {
        table.AddRow(
            "Name",
            account.Planets.First().Name);
        table.AddRow(
            "Coords",
            account.Planets.First().Coordinates.ToString());
        table.AddRow(
            "Metal",
            account.Planets.First().MetalValue.ToString());
        table.AddRow(
            "Crystal",
            account.Planets.First().CrystalValue.ToString());
        table.AddRow(
            "Deuterium",
            account.Planets.First().DeuteriumValue.ToString());
        table.AddRow(
            "Energy",
            account.Planets.First().EnergyValue.ToString());
        table.AddRow(
            "Population",
            account.Planets.First().PopulationValue.ToString());
        table.AddRow(
            "Food",
            account.Planets.First().FoodValue.ToString());
    }
    
    private void UpdateRows(object state)
    {
        table.UpdateCell(0, 1, account.Planets.Last().Name);
        table.UpdateCell(1, 1, account.Planets.Last().Coordinates.ToString());
        table.UpdateCell(2, 1, account.Planets.Last().MetalValue.ToString());
        table.UpdateCell(3, 1, account.Planets.Last().CrystalValue.ToString());
        table.UpdateCell(4, 1, account.Planets.Last().DeuteriumValue.ToString());
        table.UpdateCell(5, 1, account.Planets.Last().EnergyValue.ToString());
        table.UpdateCell(6, 1, account.Planets.Last().PopulationValue.ToString());
        table.UpdateCell(7, 1, account.Planets.Last().FoodValue.ToString());
    }
}