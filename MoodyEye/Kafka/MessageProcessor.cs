namespace MoodyEye.Kafka;

using common.Kafka.DataMessages;

public class MessageProcessor : IMessageProcessor
{
    public Task Process(IDataMessage command)
    {
        switch (command)
        {
            case GlobalData globalData:
                Console.WriteLine($"Planet Name: {globalData.PlanetName}");
                Console.WriteLine($"Metal: {globalData.Metal}");
                return Task.CompletedTask;
            default:
                return Task.CompletedTask;
        }
    }
}