namespace common.Kafka.DataMessages.Resources;

public class MetalStorageData : GlobalData
{
    public int Level { get; set; }
    public bool IsUpgrading { get; set; } 
}