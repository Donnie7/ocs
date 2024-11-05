namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class AllianceCommandHandler : IRequestHandler<AllianceCommand>
{
    private readonly INavigationCommands navigationCommands;

    public AllianceCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(AllianceCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Alliance();
    }
}