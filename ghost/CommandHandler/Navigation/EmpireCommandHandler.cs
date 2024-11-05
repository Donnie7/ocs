namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class EmpireCommandHandler : IRequestHandler<EmpireCommand>
{
    private readonly INavigationCommands navigationCommands;

    public EmpireCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(EmpireCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Empire();
    }
}