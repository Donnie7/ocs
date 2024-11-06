namespace common.Kafka;

using Commands;
using DataMessages;

public interface IKafkaProducer
{
    Task SendCommand(ICommand command);
    Task SendData(IDataMessage dataMessage);
    
}