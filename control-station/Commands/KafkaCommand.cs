namespace control_station.Commands;

using Kafka;

public class KafkaCommand(KafkaJsonProducer kafkaProducer)
{
    private const string Topic = "command-bus";

    protected async Task SendCommand(string command)
    {
        var success = await kafkaProducer.SendJsonMessageAsync(Topic, command);
        Console.WriteLine(success ? $"Command sent: {command}" : $"Command failed: {command}");
    }
}