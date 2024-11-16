namespace common.Kafka.DataMessages.Resources;

using MessagePack;

[MessagePackObject]
public class MetalMineData : GlobalData
{
    [Key(0)]
    public int Level { get; set; }
    [Key(1)]
    public bool IsUpgrading { get; set; } 
}