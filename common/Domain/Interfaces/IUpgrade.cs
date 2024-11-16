namespace common.Domain.Interfaces;

public interface IUpgrade
{
    Task UpgradeLevel();
    Task CancelUpgrade();
}