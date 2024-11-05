namespace ghost.CommandHandler.Browser;

using common.Kafka.Commands.Browser;
using MediatR;
using web_reach.Interfaces;

public class OpenOGameCommandHandler : IRequestHandler<OpenOGameCommand>
{
    private readonly IBrowserCommands browserCommands;

    public OpenOGameCommandHandler(IBrowserCommands browserCommands)
    {
        this.browserCommands = browserCommands;
    }
    
    public Task Handle(OpenOGameCommand request, CancellationToken cancellationToken)
    {
        return browserCommands.OpenOgame();
    }
}