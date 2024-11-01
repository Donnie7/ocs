namespace ghost.Kafka.Consumer;

using common.Kafka.Commands;
using common.Kafka.Commands.Browser;
using common.Kafka.Commands.Navigation;
using Interfaces;
using web_reach.Interfaces;

public class MessageProcessor : IMessageProcessor
{
    private readonly IOgameCommands ogameCommands;
    private readonly INavigationCommands navigationCommands;
    private readonly ITestDataMessage testDataMessage;

    public MessageProcessor(
        IOgameCommands ogameCommands,
        INavigationCommands navigationCommands, 
        ITestDataMessage testDataMessage)
    {
        this.ogameCommands = ogameCommands;
        this.navigationCommands = navigationCommands;
        this.testDataMessage = testDataMessage;
    }

    public Task Process(ICommand command)
    {
        switch (command)
        {
            case OpenOGameCommand:
                testDataMessage.SendTestData(); // remove this.
                return ogameCommands.OpenOgame();
            case LoginCommand:
                testDataMessage.SendTestData(); // remove this.
                return ogameCommands.Login();
            case CloseOGameCommand:
                testDataMessage.SendTestData(); // remove this.
                return ogameCommands.CloseOGame();
            case OverviewCommand:
                return navigationCommands.Overview();
            case ResourcesCommand:
                return navigationCommands.Resources();
            case LifeformCommand:
                return navigationCommands.Lifeform();
            case FacilitiesCommand:
                return navigationCommands.Facilities();
            case MerchantCommand:
                return navigationCommands.Merchant();
            case ResearchCommand:
                return navigationCommands.Research();
            case ShipyardCommand:
                return navigationCommands.Shipyard();
            case DefenseCommand:
                return navigationCommands.Defense();
            case FleetCommand:
                return navigationCommands.Fleet();
            case GalaxyCommand:
                return navigationCommands.Galaxy();
            case EmpireCommand:
                return navigationCommands.Empire();
            case AllianceCommand:
                return navigationCommands.Alliance();
            default:
                return Task.CompletedTask;
        }
    }
}