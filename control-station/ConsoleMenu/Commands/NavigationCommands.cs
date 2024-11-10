namespace control_station.ConsoleMenu.Commands;

using common.Kafka;
using common.Kafka.Commands.Navigation;
using Interfaces;

public class NavigationCommands : INavigationCommands
{
    private readonly IKafkaProducer producer;
    
    public NavigationCommands(IKafkaProducer producer)
    {
        this.producer = producer;
    }
    
    public Task Overview() => producer.SendCommand(new OverviewCommand());

    public Task Resources() => producer.SendCommand(new ResourcesCommand());

    public Task Lifeform() => producer.SendCommand(new LifeformCommand());

    public Task Facilities() => producer.SendCommand(new FacilitiesCommand());

    public Task Merchant() => producer.SendCommand(new MerchantCommand());

    public Task Research() => producer.SendCommand(new ResearchCommand());

    public Task Shipyard() => producer.SendCommand(new ShipyardCommand());

    public Task Defense() => producer.SendCommand(new DefenseCommand());

    public Task Fleet() => producer.SendCommand(new FleetCommand());

    public Task Galaxy() => producer.SendCommand(new GalaxyCommand());

    public Task Empire() => producer.SendCommand(new EmpireCommand());

    public Task Alliance() => producer.SendCommand(new AllianceCommand());
}