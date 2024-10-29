namespace ghost.Kafka;

using Confluent.Kafka;
using Microsoft.Extensions.Hosting;

public class KafkaConsumerService : BackgroundService
{
    private const string Topic = "command-bus";
    private readonly IMessageProcessor _messageProcessor;
    
    public KafkaConsumerService(IMessageProcessor messageProcessor)
    {
        _messageProcessor = messageProcessor;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "ghost-consumer",
            EnableAutoOffsetStore = false,
            EnableAutoCommit = true
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe(Topic);

        //while (!canceled)
        while (true)
        {
            var consumeResult = consumer.Consume(stoppingToken);
            Console.WriteLine(consumeResult.Message.Value);

            try
            {
                await _messageProcessor.Process(consumeResult.Message.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            consumer.StoreOffset(consumeResult);
        }
        //consumer.Close();
    }
}