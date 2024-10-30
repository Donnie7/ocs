namespace ghost.Kafka;

using Commands;
using Commands.Browser;
using web_reach;

public class MessageProcessor : IMessageProcessor
{
    private readonly IOgame ogame;
    private readonly IResourcesCommands resourcesCommands;

    public MessageProcessor(IOgame ogame, IResourcesCommands resourcesCommands)
    {
        this.ogame = ogame;
        this.resourcesCommands = resourcesCommands;
    }

    public Task Process(ICommand command)
    {
        return command switch
        {
            OpenOGameCommand => ogame.OpenOgame(),
            LoginCommand => ogame.Login(),
            CloseOGameCommand => ogame.CloseOGame(),
            _ => Task.CompletedTask
        };
    }
}