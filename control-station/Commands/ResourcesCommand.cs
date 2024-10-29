namespace control_station.Commands;

using Kafka;

public class ResourcesCommand : IResourcesCommands
{
    private const string Topic = "command-bus";
    private readonly KafkaJsonProducer _producer;

    public ResourcesCommand(KafkaJsonProducer kafkaProducer)
    {
        _producer = kafkaProducer;
    }
    
    public async Task UpgradeMetalMine()
    {
        var success = await _producer.SendJsonMessageAsync(Topic, "Upgrading Metal Mine");
        if (success)
        {
            Console.WriteLine("Command sent: Upgrading Metal Mine");
        }
    }
}