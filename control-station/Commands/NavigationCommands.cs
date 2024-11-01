namespace control_station.Commands;

using common.Commands.Navigation;
using Interfaces;
using Kafka;

public class NavigationCommands(KafkaJsonProducer kafkaProducer) : KafkaCommand(kafkaProducer), INavigationCommands
{
    public Task Overview() => SendCommand(new OverviewCommand());

    public Task Resources() => SendCommand(new ResourcesCommand());

    public Task Lifeform() => SendCommand(new LifeformCommand());

    public Task Facilities() => SendCommand(new FacilitiesCommand());

    public Task Merchant() => SendCommand(new MerchantCommand());

    public Task Research() => SendCommand(new ResearchCommand());

    public Task Shipyard() => SendCommand(new ShipyardCommand());

    public Task Defense() => SendCommand(new DefenseCommand());

    public Task Fleet() => SendCommand(new FleetCommand());

    public Task Galaxy() => SendCommand(new GalaxyCommand());

    public Task Empire() => SendCommand(new EmpireCommand());

    public Task Alliance() => SendCommand(new AllianceCommand());
}