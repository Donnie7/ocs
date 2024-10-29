using control_station;

public class StartMenu
{
    private readonly IResourcesCommands _commands;
    
    public StartMenu(IResourcesCommands commands)
    {
        _commands = commands;
    }
    
    public async Task RunAsync()
    {
        while (true)
        {
            Console.WriteLine("Introduza um comando ('exit' para sair):");
            var command = Console.ReadLine();
            if (command == "exit") break;
            if (command == "1")
            {
                await _commands.UpgradeMetalMine(); continue;
            }

            Console.WriteLine($"Comando '{command}' não reconhecido.");
        }
    }
}