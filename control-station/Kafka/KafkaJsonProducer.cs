namespace control_station.Kafka;

using Confluent.Kafka;

public class KafkaJsonProducer
{
    private readonly IProducer<string, byte[]> producer;

    public KafkaJsonProducer(string bootstrapServers)
    {
        var config = new ProducerConfig {BootstrapServers = bootstrapServers};
        producer = new ProducerBuilder<string, byte[]>(config).Build();
    }

    //public async Task<bool> SendJsonMessageAsync<T>(string topic, T message)
    public async Task<bool> SendJsonMessageAsync(string topic, byte[] message)
    {
        var kafkaMessage = new Message<string, byte[]> {Key = Guid.NewGuid().ToString(), Value = message };

        try
        {
            var deliveryResult = await producer.ProduceAsync(topic, kafkaMessage);
            Console.WriteLine($"Message sent to <{deliveryResult.TopicPartitionOffset}>");
            return true;
        }
        catch (ProduceException<string, string> ex)
        {
            Console.WriteLine($"Error sending message: {ex.Error.Reason}");
            return false;
        }
    }
}

