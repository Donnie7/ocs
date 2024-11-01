namespace MoodyEye.Kafka;

using common.Kafka.DataMessages;

public class MessageProcessor : IMessageProcessor
{

    public MessageProcessor()
    {
    }

    public Task Process(IDataMessage command)
    {
        return command switch
        {
            _ => Task.CompletedTask
        };
    }
}