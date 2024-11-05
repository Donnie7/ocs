namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class OverviewCommandHandler : IRequestHandler<OverviewCommand>
{
    private readonly INavigationCommands navigationCommands;

    public OverviewCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(OverviewCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Overview();
    }
}