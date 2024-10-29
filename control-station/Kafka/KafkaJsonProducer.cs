namespace control_station.Kafka;

using Confluent.Kafka;
using Newtonsoft.Json;

public class KafkaJsonProducer
{
    private readonly IProducer<string, string> _producer;

    public KafkaJsonProducer(string bootstrapServers)
    {
        var config = new ProducerConfig {BootstrapServers = bootstrapServers};
        _producer = new ProducerBuilder<string, string>(config).Build();
    }

    //public async Task<bool> SendJsonMessageAsync<T>(string topic, T message)
    public async Task<bool> SendJsonMessageAsync(string topic, string message)
    {
        //var jsonMessage = JsonConvert.SerializeObject(message);
        var kafkaMessage = new Message<string, string> {Key = Guid.NewGuid().ToString(), Value = message };

        try
        {
            var deliveryResult = await _producer.ProduceAsync(topic, kafkaMessage);
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

