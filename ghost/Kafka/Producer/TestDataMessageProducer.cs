namespace ghost.Kafka.Producer;

using common.Kafka;
using common.Kafka.DataMessages;
using Interfaces;

public class TestDataMessageProducer : ITestDataMessage
{
    private readonly IKafkaProducer producer;
    
    public TestDataMessageProducer(IKafkaProducer producer)
    {
        this.producer = producer;
    }

    public Task SendTestData() => producer.SendCommand(new TestDataMessage());
}