namespace ghost.Kafka;

using common.Commands;

public interface IMessageProcessor
{
    Task Process(ICommand command);
}