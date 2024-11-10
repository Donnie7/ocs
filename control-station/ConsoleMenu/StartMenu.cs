namespace control_station.ConsoleMenu;

using Interfaces;
using ConsoleMenu = ConsoleTools.ConsoleMenu;

public class StartMenu
{
    private readonly INavigationCommands navigationCommands;
    private readonly IBrowserCommands browserCommands;
    
    public StartMenu(INavigationCommands navigationCommands, IBrowserCommands browserCommands)
    {
        this.navigationCommands = navigationCommands;
        this.browserCommands = browserCommands;
    }
    
    public Task RunAsync()
    {
        var browserMenu = CreateBrowserMenu();
        var navigationMenu = CreateNavigationMenu();
        var mainMenu = CreateMainMenu(browserMenu, navigationMenu);
        mainMenu.Show();
        return Task.CompletedTask;
    }

    private static ConsoleMenu CreateMainMenu(ConsoleMenu browserMenu, ConsoleMenu navigationMenu)
    {
        var mainMenu = new ConsoleMenu()
            .Add("Browser", browserMenu.Show)
            .Add("Navigation", navigationMenu.Show);
        return mainMenu;
    }

    private ConsoleMenu CreateNavigationMenu()
    {
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
        return navigationMenu;
    }

    private ConsoleMenu CreateBrowserMenu()
    {
        var browserMenu = new ConsoleMenu()
            .Add("Go back", ConsoleMenu.Close)
            .Add("Open Ogame", () => browserCommands.OpenOGame())
            .Add("Login", () => browserCommands.Login())
            .Add("Close Ogame", () => browserCommands.CloseOGame());
        return browserMenu;
    }
}