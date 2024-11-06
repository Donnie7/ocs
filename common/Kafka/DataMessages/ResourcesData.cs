namespace common.Kafka.DataMessages;

using Domain;
using MessagePack;

[MessagePackObject]
public class ResourcesData : IDataMessage
{
    [Key(0)]
    public string PlanetName { get; set; }
    [Key(1)]
    public Coordinates Coordinates { get; set; }
}