namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using MediatR;
using web_reach.Interfaces;

public class MerchantCommandHandler : IRequestHandler<MerchantCommand>
{
    private readonly INavigationCommands navigationCommands;

    public MerchantCommandHandler(INavigationCommands navigationCommands)
    {
        this.navigationCommands = navigationCommands;
    }
    
    public Task Handle(MerchantCommand request, CancellationToken cancellationToken)
    {
        return navigationCommands.Merchant();
    }
}