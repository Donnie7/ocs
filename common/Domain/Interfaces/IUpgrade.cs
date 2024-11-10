namespace common.Domain.Interfaces;

public interface IUpgrade
{
    int Level { get; set; }
    Task UpgradeLevel();
    Task CancelUpgrade();
}