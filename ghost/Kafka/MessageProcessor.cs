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
        return message switch
        {
            "Open OGame" => _ogame.OpenOgame(),
            "Login" => _ogame.Login(),
            "Upgrade Metal Mine" => _resourcesCommands.UpgradeMetalMine(),
            "Close Ogame" => _ogame.CloseOGame(),
            _ => Task.CompletedTask
        };
    }
}