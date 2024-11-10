namespace ghost.Kafka.Producer;

using common.Kafka;
using common.Kafka.DataMessages;

public class DataCollectorProducer : IMessageProducer
{
    private readonly IKafkaProducer producer;
    
    public DataCollectorProducer(IKafkaProducer producer)
    {
        this.producer = producer;
    }

    public Task SendCollectedData(GlobalData globalData) => producer.SendData(globalData);
}