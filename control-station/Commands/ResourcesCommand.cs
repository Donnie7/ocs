namespace control_station.Commands;

using Kafka;

public class ResourcesCommand(KafkaJsonProducer kafkaProducer) : KafkaCommand(kafkaProducer), IResourcesCommands
{
    public Task UpgradeMetalMine()
    {
        return SendCommand("Upgrade Metal Mine");
    }

}