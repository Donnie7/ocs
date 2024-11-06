namespace common.Kafka.DataMessages;

using Domain;
using MessagePack;

[MessagePackObject]
public class GlobalData : IDataMessage
{
    [Key(0)]
    public string PlanetName { get; set; }
    [Key(1)]
    public Coordinates Coordinates { get; set; }
    [Key(2)]
    public int Metal { get; set; }
    [Key(3)]
    public int Crystal { get; set; }
    [Key(4)]
    public int Deuterium { get; set; }
    [Key(5)]
    public int Energy { get; set; }
    [Key(6)]
    public int Population { get; set; }
    [Key(7)]
    public int Food { get; set; }
}