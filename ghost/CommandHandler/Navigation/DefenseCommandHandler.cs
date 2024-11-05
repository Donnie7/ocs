namespace ghost.CommandHandler.Navigation;

using common.Kafka.Commands.Navigation;
using Interfaces;
using MediatR;
using web_reach.Interfaces;

public class DefenseCommandHandler : IRequestHandler<DefenseCommand>
{
    private readonly INavigationCommands navigationCommands;
    private readonly ITestDataMessage testDataMessage;

    public DefenseCommandHandler(INavigationCommands navigationCommands, ITestDataMessage testDataMessage)
    {
        this.navigationCommands = navigationCommands;
        this.testDataMessage = testDataMessage;
    }
    
    public Task Handle(DefenseCommand request, CancellationToken cancellationToken)
    {
        testDataMessage.SendTestData();
        return navigationCommands.Defense();
    }
}