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
            .Add("Open Ogame", () => ogameCommands.OpenOGame())
            .Add("Login", () => ogameCommands.Login())
            .Add("Close Ogame", () => ogameCommands.CloseOGame())
            .Add("Go back", ConsoleMenu.Close);
        
        var navigationMenu = new ConsoleMenu()
            .Add("Overview", () => navigationCommands.Overview())
            .Add("Alliance", () => navigationCommands.Alliance())
            .Add("Go back", ConsoleMenu.Close);
        
        var mainMenu = new ConsoleMenu()
            .Add("Browser", browserMenu.Show)
            .Add("Navigation", navigationMenu.Show);


        mainMenu.Show();
        return Task.CompletedTask;
    }
}