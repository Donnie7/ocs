namespace common.Domain.Interfaces;

public interface IUpgrade
{
    int Level { get; set; }
    bool IsUpgrading { get; set; }
    Task UpgradeLevel();
    Task CancelUpgrade();
}