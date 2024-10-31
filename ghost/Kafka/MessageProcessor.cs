namespace ghost.Kafka;

using Commands;
using Commands.Browser;
using Commands.Navigation;
using web_reach.Interfaces;

public class MessageProcessor : IMessageProcessor
{
    private readonly IOgameCommands ogameCommands;
    private readonly INavigationCommands navigationCommands;

    public MessageProcessor(IOgameCommands ogameCommands, INavigationCommands navigationCommands)
    {
        this.ogameCommands = ogameCommands;
        this.navigationCommands = navigationCommands;
    }

    public Task Process(ICommand command)
    {
        return command switch
        {
            OpenOGameCommand => ogameCommands.OpenOgame(),
            LoginCommand => ogameCommands.Login(),
            CloseOGameCommand => ogameCommands.CloseOGame(),
            AllianceCommand => navigationCommands.Alliance(),
            OverviewCommand => navigationCommands.Overview(),
            _ => Task.CompletedTask
        };
    }
}