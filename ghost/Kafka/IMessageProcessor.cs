namespace ghost.Kafka;

using Commands;

public interface IMessageProcessor
{
    Task Process(ICommand command);
}