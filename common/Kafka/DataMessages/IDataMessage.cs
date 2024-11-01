namespace common.Kafka.DataMessages;

[MessagePack.Union(0, typeof(TestDataMessage))]
public interface IDataMessage
{
    
}