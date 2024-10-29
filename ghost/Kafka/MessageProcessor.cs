namespace ghost.Kafka;

using web_reach;

public class MessageProcessor : IMessageProcessor
{
    private readonly IOgame _ogame;
    private readonly IResourcesCommands _resourcesCommands;

    public MessageProcessor(IOgame ogame, IResourcesCommands resourcesCommands)
    {
        _ogame = ogame;
        _resourcesCommands = resourcesCommands;
    }

    public Task Process(string message)
    {
        switch (message)
        {
            case "Open OGame":
                return _ogame.OpenOgame();
            case "Login":
                return _ogame.Login();
            case "Upgrade Metal Mine":
                return _resourcesCommands.UpgradeMetalMine();
            case "Close":
                return _ogame.CloseOGame();
            default:
                return Task.CompletedTask;
        }
    }
}