namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class FacilitiesCommandHandler : IRequestHandler<FacilitiesCommand>
{
    private readonly INavigationCommands navigationCommands;

    public FacilitiesCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(FacilitiesCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Facilities();
    }
}