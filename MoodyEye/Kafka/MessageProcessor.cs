namespace MoodyEye.Kafka;

using common.DataFillers;
using common.Domain;
using common.Kafka.DataMessages;

public class MessageProcessor : IMessageProcessor
{
    private readonly Account account;

    public MessageProcessor(Account account)
    {
        this.account = account;
    }
    
    public Task Process(IDataMessage command)
    {
        switch (command)
        {
            case GlobalData globalData:
                GlobalDataFiller.PopulateAccount(account, globalData);
                return Task.CompletedTask;
            default:
                return Task.CompletedTask;
        }
    }
}