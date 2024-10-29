using ConsoleTools;
using control_station;

public class StartMenu
{
    private readonly IResourcesCommands resourcesCommands;
    private readonly IOgameCommands ogameCommands;
    
    public StartMenu(IResourcesCommands resourcesCommands, IOgameCommands ogameCommands)
    {
        this.resourcesCommands = resourcesCommands;
        this.ogameCommands = ogameCommands;
    }
    
    public Task RunAsync()
    {
        var browserMenu = new ConsoleMenu()
            .Add("Open Ogame", () => ogameCommands.OpenOGame())
            .Add("Login", () => ogameCommands.Login())
            .Add("Close Ogame", () => ogameCommands.CloseOGame())
            .Add("Go back", ConsoleMenu.Close);
        
        var mainMenu = new ConsoleMenu()
            .Add("Browser", browserMenu.Show);

        mainMenu.Show();
        return Task.CompletedTask;
    }
}