namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class DefenseCommandHandler : IRequestHandler<DefenseCommand>
{
    private readonly INavigationCommands navigationCommands;

    public DefenseCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(DefenseCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Defense();
    }
}