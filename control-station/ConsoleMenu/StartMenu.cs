using control_station;

public class StartMenu
{
    private readonly IResourcesCommands _resourcesCommands;
    private readonly IOgameCommands _ogameCommands;
    
    public StartMenu(IResourcesCommands resourcesCommands, IOgameCommands ogameCommands)
    {
        _resourcesCommands = resourcesCommands;
        _ogameCommands = ogameCommands;
    }
    
    public async Task RunAsync()
    {
        while (true)
        {
            Console.WriteLine("Introduce command ('exit' to leave):");
            var command = Console.ReadLine();
            if (command == "exit") break;
            switch (command)
            {
               case "1": await _ogameCommands.OpenOGame(); continue;
               case "2": await _ogameCommands.Login(); continue;
               case "3": await _resourcesCommands.UpgradeMetalMine(); continue;
               case "4": await _ogameCommands.CloseOGame(); continue;
                   
            }
            Console.WriteLine($"Command '{command}' not recognized.");
        }
    }
}