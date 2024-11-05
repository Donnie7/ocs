namespace ghost.CommandHandler.Browser;

using common.Kafka.Commands.Browser;
using MediatR;
using web_reach.Interfaces;

public class LoginCommandHandler : IRequestHandler<LoginCommand>
{
    private readonly IBrowserCommands browserCommands;

    public LoginCommandHandler(IBrowserCommands browserCommands)
    {
        this.browserCommands = browserCommands;
    }
    
    public Task Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        return browserCommands.Login();
    }
}