namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class ResourcesCommandHandler : IRequestHandler<ResourcesCommand>
{
    private readonly INavigationCommands navigationCommands;
    
    public ResourcesCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(ResourcesCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Resources();
    }
}