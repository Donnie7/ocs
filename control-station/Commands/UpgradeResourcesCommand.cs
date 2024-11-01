namespace control_station.Commands;

using Interfaces;
using Kafka;

public class UpgradeResourcesCommand(KafkaJsonProducer kafkaProducer) : KafkaCommand(kafkaProducer), IResourcesCommands
{
    public Task UpgradeMetalMine()
    {
        throw new NotImplementedException();
        //return SendCommand("Upgrade Metal Mine");
    }

}