namespace ghost.Kafka;

public interface IMessageProcessor
{
    Task Process(string message);
}