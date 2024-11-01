namespace common.Kafka;

using Commands;
using DataMessages;
using MessagePack;

public class KafkaProducer(KafkaJsonProducer kafkaProducer) : IKafkaProducer
{
    private const string CommandBusTopic = "command-bus";
    private const string DataBusTopic = "data-bus";

    public async Task SendCommand(ICommand command)
    {
        var bin = MessagePackSerializer.Serialize(command);
        var success = await kafkaProducer.SendJsonMessageAsync(CommandBusTopic, bin);
        Console.WriteLine(success ? $"Command sent: {command}" : $"Command failed: {command}");
    }

    public async Task SendCommand(IDataMessage dataMessage)
    {
        var bin = MessagePackSerializer.Serialize(dataMessage);
        var success = await kafkaProducer.SendJsonMessageAsync(DataBusTopic, bin);
        Console.WriteLine(success ? $"DataMessage sent: {dataMessage}" : $"DataMessage failed: {dataMessage}");
    }
}