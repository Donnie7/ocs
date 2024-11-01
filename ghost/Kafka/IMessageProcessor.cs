namespace ghost.Kafka;

using busCommands;

public interface IMessageProcessor
{
    Task Process(ICommand command);
}