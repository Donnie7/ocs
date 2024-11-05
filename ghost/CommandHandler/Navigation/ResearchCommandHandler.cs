namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class ResearchCommandHandler : IRequestHandler<ResearchCommand>
{
    private readonly INavigationCommands navigationCommands;

    public ResearchCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(ResearchCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Research();
    }
}