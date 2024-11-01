namespace ghost.Kafka.Consumer;

using common.Kafka.Commands;

public interface IMessageProcessor
{
    Task Process(ICommand command);
}