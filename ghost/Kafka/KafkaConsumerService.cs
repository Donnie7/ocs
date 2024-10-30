namespace ghost.Kafka;

using Commands;
using Confluent.Kafka;
using MessagePack;
using Microsoft.Extensions.Hosting;

public class KafkaConsumerService : BackgroundService
{
    private const string Topic = "command-bus";
    private readonly IMessageProcessor messageProcessor;
    
    public KafkaConsumerService(IMessageProcessor messageProcessor)
    {
        this.messageProcessor = messageProcessor;
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

        using var consumer = new ConsumerBuilder<Ignore, byte[]>(config).Build();
        consumer.Subscribe(Topic);

        //while (!canceled)
        while (true)
        {
            var consumeResult = consumer.Consume(stoppingToken);
            consumer.StoreOffset(consumeResult);
            
            try
            {
                var command = MessagePackSerializer.Deserialize<ICommand>(consumeResult.Message.Value);
                await messageProcessor.Process(command);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error processing message: {e}");
            }
        }
        //consumer.Close();
    }
}