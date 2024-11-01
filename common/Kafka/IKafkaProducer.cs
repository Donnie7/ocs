namespace common.Kafka;

using Commands;
using DataMessages;

public interface IKafkaProducer
{
    Task SendCommand(ICommand command);
    Task SendCommand(IDataMessage dataMessage);
}