namespace control_station.Commands;

using global::Commands.Navigation;
using Interfaces;
using Kafka;

public class NavigationCommands(KafkaJsonProducer kafkaProducer) : KafkaCommand(kafkaProducer), INavigationCommands
{
    public Task Overview()
    {
        return SendCommand(new OverviewCommand());
    }

    public Task Resources()
    {
        throw new NotImplementedException();
    }

    public Task Lifeform()
    {
        throw new NotImplementedException();
    }

    public Task Facilities()
    {
        throw new NotImplementedException();
    }

    public Task Merchant()
    {
        throw new NotImplementedException();
    }

    public Task Research()
    {
        throw new NotImplementedException();
    }

    public Task Shipyard()
    {
        throw new NotImplementedException();
    }

    public Task Defense()
    {
        throw new NotImplementedException();
    }

    public Task Fleet()
    {
        throw new NotImplementedException();
    }

    public Task Galaxy()
    {
        throw new NotImplementedException();
    }

    public Task Empire()
    {
        throw new NotImplementedException();
    }

    public Task Alliance()
    {
        return SendCommand(new AllianceCommand());
    }
}