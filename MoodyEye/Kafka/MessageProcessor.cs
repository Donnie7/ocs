namespace MoodyEye.Kafka;

using common.Kafka.DataMessages;

public class MessageProcessor : IMessageProcessor
{
    public Task Process(IDataMessage command)
    {
        switch (command)
        {
            case TestDataMessage:
                Console.WriteLine("Test Data Message received");
                return Task.CompletedTask;
            default:
                return Task.CompletedTask;
        }
    }
}