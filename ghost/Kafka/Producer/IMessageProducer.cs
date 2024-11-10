namespace ghost.Kafka.Producer;

using common.Kafka.DataMessages;

public interface IMessageProducer
{
    Task SendCollectedData(GlobalData globalData);
}