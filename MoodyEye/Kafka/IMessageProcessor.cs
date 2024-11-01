namespace MoodyEye.Kafka;

using common.Kafka.DataMessages;

public interface IMessageProcessor
{
    Task Process(IDataMessage command);
}