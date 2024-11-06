namespace common.Kafka.DataMessages;

[MessagePack.Union(0, typeof(GlobalData))]
[MessagePack.Union(1, typeof(ResourcesData))]
public interface IDataMessage
{
    
}