namespace control_station.Commands;

using busCommands;
using Kafka;
using MessagePack;

public class KafkaCommand(KafkaJsonProducer kafkaProducer)
{
    private const string Topic = "command-bus";

    protected async Task SendCommand(ICommand command)
    {
        var bin = MessagePackSerializer.Serialize(command);
        var success = await kafkaProducer.SendJsonMessageAsync(Topic, bin);
        Console.WriteLine(success ? $"Command sent: {command}" : $"Command failed: {command}");
    }
}