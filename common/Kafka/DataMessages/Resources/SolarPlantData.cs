namespace common.Kafka.DataMessages.Resources;

public class SolarPlantData : GlobalData
{
    public int Level { get; set; }
    public bool IsUpgrading { get; set; } 
}