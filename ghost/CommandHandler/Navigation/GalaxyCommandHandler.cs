namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class GalaxyCommandHandler : IRequestHandler<GalaxyCommand>
{
    private readonly INavigationCommands navigationCommands;

    public GalaxyCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(GalaxyCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Galaxy();
    }
}