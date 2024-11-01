namespace control_station.ConsoleMenu;

using Interfaces;
using ConsoleMenu = ConsoleTools.ConsoleMenu;

public class StartMenu
{
    private readonly INavigationCommands navigationCommands;
    private readonly IOgameCommands ogameCommands;
    
    public StartMenu(INavigationCommands navigationCommands, IOgameCommands ogameCommands)
    {
        this.navigationCommands = navigationCommands;
        this.ogameCommands = ogameCommands;
    }
    
    public Task RunAsync()
    {
        var browserMenu = new ConsoleMenu()
            .Add("Go back", ConsoleMenu.Close)
            .Add("Open Ogame", () => ogameCommands.OpenOGame())
            .Add("Login", () => ogameCommands.Login())
            .Add("Close Ogame", () => ogameCommands.CloseOGame());

        var navigationMenu = new ConsoleMenu()
            .Add("Go back", ConsoleMenu.Close)
            .Add("Overview", () => navigationCommands.Overview())
            .Add("Resources", () => navigationCommands.Resources())
            .Add("Lifeform", () => navigationCommands.Lifeform())
            .Add("Facilities", () => navigationCommands.Facilities())
            .Add("Merchant", () => navigationCommands.Merchant())
            .Add("Research", () => navigationCommands.Research())
            .Add("Shipyard", () => navigationCommands.Shipyard())
            .Add("Defense", () => navigationCommands.Defense())
            .Add("Fleet", () => navigationCommands.Fleet())
            .Add("Galaxy", () => navigationCommands.Galaxy())
            .Add("Empire", () => navigationCommands.Empire())
            .Add("Alliance", () => navigationCommands.Alliance());
        
        var mainMenu = new ConsoleMenu()
            .Add("Browser", browserMenu.Show)
            .Add("Navigation", navigationMenu.Show);


        mainMenu.Show();
        return Task.CompletedTask;
    }
}