namespace ghost.CommandHandler.Browser;

using common.Kafka.Commands.Browser;
using MediatR;
using web_reach.Interfaces;

public class CloseOGameCommandHandler : IRequestHandler<CloseOGameCommand>
{
    private readonly IBrowserCommands browserCommands;

    public CloseOGameCommandHandler(IBrowserCommands browserCommands)
    {
        this.browserCommands = browserCommands;
    }
    
    public Task Handle(CloseOGameCommand request, CancellationToken cancellationToken)
    {
        return browserCommands.CloseOGame();
    }
}