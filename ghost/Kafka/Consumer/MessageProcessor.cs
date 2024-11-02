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
        return command switch
        {
            OpenOGameCommand => ogameCommands.OpenOgame(),
            LoginCommand => ogameCommands.Login(),
            CloseOGameCommand => ogameCommands.CloseOGame(),
            OverviewCommand => navigationCommands.Overview(),
            ResourcesCommand => navigationCommands.Resources(),
            LifeformCommand => navigationCommands.Lifeform(),
            FacilitiesCommand => navigationCommands.Facilities(),
            MerchantCommand => navigationCommands.Merchant(),
            ResearchCommand => navigationCommands.Research(),
            ShipyardCommand => navigationCommands.Shipyard(),
            DefenseCommand => navigationCommands.Defense(),
            FleetCommand => navigationCommands.Fleet(),
            GalaxyCommand => navigationCommands.Galaxy(),
            EmpireCommand => navigationCommands.Empire(),
            AllianceCommand => navigationCommands.Alliance(),
            _ => Task.CompletedTask
        };
    }
}