namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class FleetCommandHandler : IRequestHandler<FleetCommand>
{
    private readonly INavigationCommands navigationCommands;

    public FleetCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(FleetCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Fleet();
    }
}