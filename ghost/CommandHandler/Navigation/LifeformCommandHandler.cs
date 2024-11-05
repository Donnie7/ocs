namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class LifeformCommandHandler : IRequestHandler<LifeformCommand>
{
    private readonly INavigationCommands navigationCommands;

    public LifeformCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(LifeformCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Lifeform();
    }
}