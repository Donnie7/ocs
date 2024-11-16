namespace common.Domain.Interfaces;

public interface IUpgradable
{
    int Level { get; set; }
    bool IsUpgrading { get; set; }
}