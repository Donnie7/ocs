namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class ShipyardCommandHandler : IRequestHandler<ShipyardCommand>
{
    private readonly INavigationCommands navigationCommands;

    public ShipyardCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(ShipyardCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Shipyard();
    }
}