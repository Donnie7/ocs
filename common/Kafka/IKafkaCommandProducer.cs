namespace common.Kafka;

using Commands;
using DataMessages;

public interface IKafkaCommandProducer
{
    Task SendCommand(ICommand command);
    Task SendCommand(IDataMessage dataMessage);
}